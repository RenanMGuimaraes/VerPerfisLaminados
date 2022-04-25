using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerPerfisLaminados
{
    internal class CalculaFlexaoI
    {
        F_Principal pai;
   
        double zx = PropPerfilI.Zx;
        double zy = PropPerfilI.Zy;
        double wx = PropPerfilI.Wx;
        double wy = PropPerfilI.Wy;
        double d = PropPerfilI.d;
        double bf = PropPerfilI.bf;
        double tf = PropPerfilI.tf;
        double tw = PropPerfilI.tw;
        double ry = PropPerfilI.ry;
        double rx = PropPerfilI.rx;
        double iy = PropPerfilI.Iy;
        double ix = PropPerfilI.Ix;
        double it = PropPerfilI.It;
        double cw = PropPerfilI.Cw;
        double dlinha = PropPerfilI.dlinha;
        double mrd_flm_x = 0;
        double mrd_fla_x = 0;
        double mrd_flt = 0;
        double mxrd = 0;
        double mrd_flm_y = 0;
        double mrd_fla_y = 0;
        double myrd = 0;
        double fy = 0;
        double elast = 0;

        public CalculaFlexaoI()
        {
            
        }

        public void FlexaoX(F_Principal f_principal, double mxsd, double elast, double cb, double lx, double ly, double lz, double fy)
        {
            this.fy = fy;
            this.elast = elast;
            double bt, btp, btr;
            double mx_max;
            double taxa;
            pai = f_principal;

            //Momento Máximo
            mx_max = (1.5 * wx * fy) / 1.10;

            //FLM------------------------------------------------------------
            bt = bf / (2.0 * tf);
            btp = 0.38 * Math.Sqrt(elast / fy);
            btr = 0.83 * Math.Sqrt(elast / (0.7* fy));

            if (bt <= btp)
            {
                mrd_flm_x = Compacta(zx);
            }
            else if (bt > btp && bt <= btr)
            {
                double mr = 0.7 * fy* wx;
                mrd_flm_x = SemiCompacta(zx,wx, bt, btp, btr, mr);
            }
            else if(bt > btr)
            {
                double mcr = (0.69 * elast * wx) / (bt * bt);
                mrd_flm_x = Esbelta(mcr, zx);
            }

            //FLA--------------------------------------------------------------
            bt = dlinha / tw;
            btp = 3.76 * Math.Sqrt(elast / fy);
            btr = 5.70 * Math.Sqrt(elast / fy);

            if (bt <= btp)
            {
                mrd_fla_x = Compacta(zx);
            }
            else if (bt > btp && bt <= btr)
            {
                double mr = fy * wx;
                mrd_fla_x = SemiCompacta(zx, wx, bt, btp, btr, mr);
            }
            else if (bt > btr)
            {
                mrd_fla_x = 0;
                pai.lb_sdrd_mx.Text = "N/A";
            }

            //FLT---------------------------------------------------------------
            double lb = ly; //comprimento destravado em torno de Y
            double b1 = (0.7 * fy * wx) / (elast * it);

            bt = lb / ry;
            btp = 1.76 * Math.Sqrt(elast / fy);
            btr = ((1.38 * Math.Sqrt(iy * it)) / (ry * it * b1)) * Math.Sqrt(1 + Math.Sqrt(1 + (27 * cw * b1 * b1 ) / iy ));

            if (bt <= btp)
            {
                mrd_flt = Compacta(zx);
            }
            else if (bt > btp && bt <= btr)
            {
                double mr = 0.7 * wx * fy;
                mrd_flt = SemiCompactaFLT(zx, wx, bt, btp, btr, cb, mr);
            }
            else if (bt > btr)
            {
                double mcr = ((cb * Math.Pow(Math.PI,2.0) * elast * iy) / (ly * ly)) * Math.Sqrt((cw / iy) * (1 + (0.039* it * ly * ly) / cw ));
                mrd_flt = Esbelta(mcr, zx);
            }

            //Verificação do momento fletor final-------------------------------
            mxrd = Math.Min(mx_max, Math.Min(mrd_flt, Math.Min(mrd_flm_x, mrd_fla_x)));

            //Preenche os valores no form principal
            taxa = mxsd / mxrd;
            pai.txt_mxrd.Text = mxrd.ToString("F2");
            pai.lb_sdrd_mx.Text = $"Sd/Rd = {taxa:F2}";
            if (taxa <= 1.0)
            {
                pai.lb_sdrd_mx.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                pai.lb_sdrd_mx.ForeColor = System.Drawing.Color.Red;
            }

        }

        public void FlexaoY(F_Principal f_principal, double mysd, double elast, double cb, double lx, double ly, double lz, double fy)
        {
            this.fy = fy;
            this.elast = elast;
            pai = f_principal;
            double my_max, taxa;
            double bt, btp, btr;

            //Momento Máximo--------------------------------------------------------
            my_max = (1.5 * wy * fy) / 1.10;

            //FLM-------------------------------------------------------------------
            bt = bf / (2.0 * tf);
            btp = 0.38 * Math.Sqrt(elast / fy);
            btr = 0.83 * Math.Sqrt(elast / (0.7 * fy));

            if (bt <= btp)
            {
                mrd_flm_y = Compacta(zy);
            }
            else if (bt > btp && bt <= btr)
            {
                double mr = 0.7 * wy * fy;
                mrd_flm_y = SemiCompacta(zy, wy, bt, btp, btr, mr);
            }
            else if (bt > btr)
            {
                double mcr = (0.69 * elast * wy) / (bt * bt);
                mrd_flm_y = Esbelta(mcr, zy);
            }

            //FLA------------------------------------------------------------------
            bt = dlinha / tw;
            btp = 1.12 * Math.Sqrt(elast / fy);
            btr = 1.40 * Math.Sqrt(elast / fy);

            if (bt <= btp)
            {
                mrd_fla_y = Compacta(zy);
            }
            else if (bt > btp && bt <= btr)
            {
                double mr = fy * wy;
                mrd_fla_y = SemiCompacta(zy, wy, bt, btp, btr, mr);
            }
            else if (bt > btr)
            {
                double mcr = wy * fy;
                mrd_fla_y = Esbelta(mcr, zy);
            }

            myrd = Math.Min(my_max,Math.Min(mrd_flm_y, mrd_fla_y));


            //Preenche os valores no form principal
            taxa = mysd / myrd;
            pai.txt_myrd.Text = myrd.ToString("F2");
            pai.lb_sdrd_my.Text = $"Sd/Rd = {taxa:F2}";
            if (taxa <= 1.0)
            {
                pai.lb_sdrd_my.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                pai.lb_sdrd_my.ForeColor = System.Drawing.Color.Red;
            }

        }

        public double Compacta(double z)
        {
            double mrd;
            double mpl = z * fy;
            mrd = mpl / 1.10;
            return mrd;
        }

        public double SemiCompacta(double z, double wx, double bt, double btp, double btr, double mr)
        {
            double mrd;
            double mpl = z * fy;
            return mrd = (1.0 / 1.10) * (mpl - (mpl - mr) * ((bt - btp) / (btr - btp)));
            
        }

        public double SemiCompactaFLT(double z, double wx, double bt, double btp, double btr, double cb, double mr)
        {
            double mrd;
            double mpl = z * fy;
            return mrd = (cb / 1.10) * (mpl - (mpl - mr) * ((bt - btp) / (btr - btp)));
        }

        public double Esbelta(double mcr, double z)
        {
            double mrd;
            double mpl = z * fy;
            mrd = mcr / 1.10;

            if(mrd > mpl)
            {
                mrd = mpl;
            }

            return mrd;
        }
    }
}

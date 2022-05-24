using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerPerfisLaminados
{
    internal class FlexaoI
    {
        

        public string FlexaoX(F_Principal f_principal, double mxsd, double elast, double cb, double lx, double ly, double lz, double fy)
        {
            fy /= 10.0;
            elast /= 10.0;

            //Propriedades do perfil
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
            string perfil = PropPerfilI.perfil;

            //Propriedades do momento fletor
            double mrd_flm_x = 0;
            double mrd_fla_x = 0;
            double mrd_flt = 0;
            double mxrd = 0;
            double mplx = zx * fy;
            

            //Parametros
            double btalma, btpalma, btralma;
            double btmesa, btpmesa, btrmesa;
            double btperfil, btpperfil, btrperfil;
            double mx_max;
            double taxa;
            F_Principal pai;
            pai = f_principal;


            //Momento Máximo
            mx_max = (1.5 * wx * fy) / 1.10;

            //FLM------------------------------------------------------------
            btmesa = bf / (2.0 * tf);
            btpmesa = 0.38 * Math.Sqrt(elast / fy);
            btrmesa = 0.83 * Math.Sqrt(elast / (0.7* fy));

            if (btmesa <= btpmesa)
            {
                mrd_flm_x = CompactaX(zx, fy, mplx);
            }
            else if (btmesa > btpmesa && btmesa <= btrmesa)
            {
                double mr = 0.7 * fy* wx;
                mrd_flm_x = SemiCompactaX(zx,wx, btmesa, btpmesa, btrmesa, mr, fy, mplx);
            }
            else if(btmesa > btrmesa)
            {
                double mcr = (0.69 * elast * wx) / (btmesa * btmesa);
                mrd_flm_x = EsbeltaX(mcr, zx, fy, mplx);
            }

            //FLA--------------------------------------------------------------
            btalma = dlinha / tw;
            btpalma = 3.76 * Math.Sqrt(elast / fy);
            btralma = 5.70 * Math.Sqrt(elast / fy);

            if (btalma <= btpalma)
            {
                mrd_fla_x = CompactaX(zx, fy, mplx);
            }
            else if (btalma > btpalma && btalma <= btralma)
            {
                double mr = fy * wx;
                mrd_fla_x = SemiCompactaX(zx, wx, btalma, btpalma, btralma, mr, fy, mplx);
            }
            else if (btalma > btralma)
            {
                mrd_fla_x = 0;
                pai.lb_sdrd_mx.Text = "N/A";
            }

            //FLT---------------------------------------------------------------
            double lb = ly; //comprimento destravado em torno de Y
            double b1 = (0.7 * fy * wx) / (elast * it);

            btperfil = lb / ry;
            btpperfil = 1.76 * Math.Sqrt(elast / fy);
            btrperfil = ((1.38 * Math.Sqrt(iy * it)) / (ry * it * b1)) * Math.Sqrt(1 + Math.Sqrt(1 + (27 * cw * b1 * b1 ) / iy ));

            if (btperfil <= btpperfil)
            {
                mrd_flt = CompactaX(zx, fy, mplx);
            }
            else if (btperfil > btpperfil && btperfil <= btrperfil)
            {
                double mr = 0.7 * wx * fy;
                mrd_flt = SemiCompactaFLTX(zx, wx, btperfil, btpperfil, btrperfil, cb, mr, fy, mplx);
            }
            else if (btperfil > btrperfil)
            {
                double mcr = ((cb * Math.Pow(Math.PI,2.0) * elast * iy) / (ly * ly)) * Math.Sqrt((cw / iy) * (1 + (0.039* it * ly * ly) / cw ));
                mrd_flt = EsbeltaX(mcr, zx, fy, mplx);
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

            string resultado = "DIMENSIONAMENTO A FLEXÃO - EIXO X: \n\n" +
               $"Mx,sd: {mxsd:F2} kN*cm \n" +
               $"Mx,rd: {mxrd:F2} kN*cm \n\n" +
               $"1 - FLAMBAGEM LOCAL DA ALMA: \r\n" +
                            $"λ = b/t = {dlinha:F2} / {tw:F2} = {btalma:F1}\r\n" +
                            $"λp = b/t = 3,76 * Sqrt(E/ fy) = 3,76 * Raiz({elast:F0} / {fy:F1}) = {btpalma:F1} \n" +
                            $"λr = b/t = 5,70 * Sqrt(E/ fy) = 3,76 * Raiz({elast:F0} / {fy:F1}) = {btralma:F1} \n";
                            if (btalma <= btpalma)
            {              
                   resultado += $"SEÇÂO COMPACTA: Mrd = Mpl /1,10 = {mrd_fla_x:F2} kN*cm\n\n";
            }
            else if (btalma > btpalma && btalma <= btralma)
            {
                resultado += $"SEÇÂO SEMI-COMPACTA: Mrd = {mrd_fla_x:F2} kN*cm\n\n";
            }
            else if (btalma > btralma)
            {
                resultado += $"SEÇÂO ESBELTA - NÃO SE APLICA À FLA\n\n";
            }
            resultado += $"2 - FLAMBAGEM LOCAL DA MESA: \r\n" +
            $"λ = b/t = {bf:F2} / 2,0 * {tf:F2} = {btmesa:F1}\r\n" +
            $"λp = b/t = 0,38 * Sqrt(E/ fy) = 0,38 * Raiz({elast:F0} / {fy:F1}) = {btpmesa:F1} \n" +
            $"λr = b/t = 0,83 * Sqrt(E/ fy) = 0,83 * Raiz({elast:F0} / {fy:F1}) = {btrmesa:F1} \n";
                            if (btmesa <= btpmesa)
            {
                resultado += $"SEÇÂO COMPACTA: Mrd = Mpl /1,10 = {mrd_flm_x:F2} kN*cm\n\n";
            }
            else if (btmesa > btpmesa && btmesa <= btrmesa)
            {
                resultado += $"SEÇÂO SEMI-COMPACTA: Mrd = {mrd_flm_x:F2} kN*cm\n\n";
            }
            else if (btmesa > btrmesa)
            {
                resultado += $"SEÇÂO ESBELTA: Mrd = Mcr / 1,10 = {mrd_flm_x:F2} kN*cm \n\n";
            }
            resultado += $"3 - FLAMBAGEM LATERAL COM TORÇÃO: \r\n" +
            $"λ = Lb/ry = {ly:F2} / {ry:F2} = {btperfil:F1}\r\n" +
            $"λp = 1,76 * Sqrt(E/ fy) = 1,76 * Raiz({elast:F0} / {fy:F1}) = {btpperfil:F1} \n" +
            $"λr = {btrperfil:F1} \n";
            if (btperfil <= btpperfil)
            {
                resultado += $"SEÇÂO COMPACTA: Mrd = Mpl /1,10 = {mrd_flt:F2} kN*cm\n\n";
            }
            else if (btperfil > btpperfil && btperfil <= btrperfil)
            {
                resultado += $"SEÇÂO SEMI-COMPACTA: Mrd = {mrd_flt:F2} kN*cm\n\n";
            }
            else if (btperfil> btrperfil)
            {
                resultado += $"SEÇÂO ESBELTA: Mrd = Mcr / 1,10 = {mrd_flt:F2} kN*cm \n\n";
            }
            resultado += $"A taxa de aproveitamento do perfil é de {taxa * 100.0:F2} % \r\n \r\n";

            return resultado;

        }

        public string FlexaoY(F_Principal f_principal, double mysd, double elast, double cb, double lx, double ly, double lz, double fy)
        {
            //Propriedades do perfil
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
            string perfil = PropPerfilI.perfil;
            double mrd_flm_y = 0;
            double mrd_fla_y = 0;
            double myrd = 0;

            double mply = zy * fy;
            double btmesa, btpmesa, btrmesa;
            double btalma, btpalma, btralma;

            F_Principal pai;
            pai = f_principal;
            double my_max, taxa;

            //Momento Máximo--------------------------------------------------------
            my_max = (1.5 * wy * fy) / 1.10;

            //FLM-------------------------------------------------------------------
            btmesa = bf / (2.0 * tf);
            btpmesa = 0.38 * Math.Sqrt(elast / fy);
            btrmesa = 0.83 * Math.Sqrt(elast / (0.7 * fy));

            if (btmesa <= btpmesa)
            {
                mrd_flm_y = CompactaY(zy, fy, mply);
            }
            else if (btmesa > btpmesa && btmesa <= btrmesa)
            {
                double mr = 0.7 * wy * fy;
                mrd_flm_y = SemiCompactaY(zy, wy, btmesa, btpmesa, btrmesa, mr, fy, mply);
            }
            else if (btmesa > btrmesa)
            {
                double mcr = (0.69 * elast * wy) / (btmesa * btmesa);
                mrd_flm_y = EsbeltaY(mcr, zy, fy, mply);
            }

            //FLA------------------------------------------------------------------
            btalma = dlinha / tw;
            btpalma = 1.12 * Math.Sqrt(elast / fy);
            btralma = 1.40 * Math.Sqrt(elast / fy);

            if (btalma <= btpalma)
            {
                mrd_fla_y = CompactaY(zy, fy, mply);
            }
            else if (btalma > btpalma && btalma <= btralma)
            {
                double mr = fy * wy;
                mrd_fla_y = SemiCompactaY(zy, wy, btalma, btpalma, btralma, mr, fy, mply);
            }
            else if (btalma > btralma)
            {
                double mcr = wy * fy;
                mrd_fla_y = EsbeltaY(mcr, zy, fy, mply);
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
            string resultado = "DIMENSIONAMENTO A FLEXÃO - EIXO Y: \n\n" +
               $"Mx,sd: {mysd:F2} kN*cm \n" +
               $"Mx,rd: {myrd:F2} kN*cm \n\n" +
               $"1 - FLAMBAGEM LOCAL DA ALMA: \r\n" +
                            $"λ = b/t = {dlinha:F2}/ {tw:F2} = {btalma:F1}\r\n" +
                            $"λp = b/t = 1,12 * Sqrt(E/ fy) = 1,12 * Raiz({elast:F0} / {fy:F1}) = {btpalma:F1} \n" +
                            $"λr = b/t = 1,40 * Sqrt(E/ fy) = 1,40 * Raiz({elast:F0} / {fy:F1}) = {btralma:F1} \n";
            if (btalma <= btpalma)
            {
                resultado += $"SEÇÂO COMPACTA: Mrd = Mpl /1,10 = {mrd_fla_y:F2} kN*cm\n\n";
            }
            else if (btalma > btpalma && btalma <= btralma)
            {
                resultado += $"SEÇÂO SEMI-COMPACTA: Mrd = {mrd_fla_y:F2} kN*cm\n\n";
            }
            else if (btalma > btralma)
            {
                resultado += $"SEÇÂO ESBELTA: Mrd = {mrd_fla_y:F2} kN*cm\n\n";
            }
            resultado += $"2 - FLAMBAGEM LOCAL DA MESA: \r\n" +
            $"λ = b/t = {bf:F2} / 2,0 * {tf:F2} = {btmesa:F1}\r\n" +
            $"λp = b/t = 0,38 * Sqrt(E/ fy) = 0,38 * Raiz({elast:F0} / {fy:F1}) = {btpmesa:F1} \n" +
            $"λp = b/t = 0,83 * Sqrt(E/ fy) = 0,83 * Raiz({elast:F0} / {fy:F1}) = {btrmesa:F1} \n";
            if (btmesa <= btpmesa)
            {
                resultado += $"SEÇÂO COMPACTA: Mrd = Mpl /1,10 = {mrd_flm_y:F2} kN*cm\n\n";
            }
            else if (btmesa > btpmesa && btmesa <= btrmesa)
            {
                resultado += $"SEÇÂO SEMI-COMPACTA: Mrd = {mrd_flm_y:F2} kN*cm\n\n";
            }
            else if (btmesa > btrmesa)
            {
                resultado += $"SEÇÂO ESBELTA: Mrd = Mcr / 1,10 = {mrd_flm_y:F2} kN*cm\n\n";
            }
            resultado += $"A taxa de aproveitamento do perfil é de {taxa * 100.0:F2} % \r\n \r\n";

            return resultado;

        }

        public static double CompactaX(double z, double fy, double mplx)
        {
            double mrd;           
            mrd = mplx / 1.10;
            return mrd;
        }

        public static double CompactaY(double z, double fy, double mplx)
        {
            double mrd;
            mrd = mplx / 1.10;
            return mrd;
        }

        public static double SemiCompactaX(double z, double wx, double bt, double btp, double btr, double mr, double fy, double mplx)
        {
            double mrd;
            return mrd = (1.0 / 1.10) * (mplx - (mplx - mr) * ((bt - btp) / (btr - btp)));
            
        }

        public static double SemiCompactaY(double z, double wx, double bt, double btp, double btr, double mr, double fy, double mply)
        {
            double mrd;
            return mrd = (1.0 / 1.10) * (mply - (mply - mr) * ((bt - btp) / (btr - btp)));

        }

        public static double SemiCompactaFLTX(double z, double wx, double bt, double btp, double btr, double cb, double mr, double fy, double mplx)
        {
            double mrd;
            return mrd = (cb / 1.10) * (mplx - (mplx - mr) * ((bt - btp) / (btr - btp)));
        }

        public static double SemiCompactaFLTY(double z, double wx, double bt, double btp, double btr, double cb, double mr, double fy, double mply)
        {
            double mrd;
            return mrd = (cb / 1.10) * (mply - (mply - mr) * ((bt - btp) / (btr - btp)));
        }

        public static double EsbeltaX(double mcr, double z, double fy, double mplx)
        {
            double mrd;
            mrd = mcr / 1.10;

            if(mrd > mplx)
            {
                mrd = mplx;
            }

            return mrd;
        }

        public static double EsbeltaY(double mcr, double z, double fy, double mply)
        {
            double mrd;
            mrd = mcr / 1.10;

            if (mrd > mply)
            {
                mrd = mply;
            }

            return mrd;
        }
        
        
    }
}

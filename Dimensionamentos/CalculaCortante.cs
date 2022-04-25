using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerPerfisLaminados
{
    internal class CalculaCortante
    {
        F_Principal pai;

    public CalculaCortante()
        {
            
        }

        double aw = 0;
        double tw = 0;
        double bt = 0;
        double btp = 0;
        double btr = 0;
        double h = 0; //altura total do perfil
        double vpl = 0;
        double vrd = 0;
        double taxa = 0;

        public void CalculaCortanteX(F_Principal f_principal,string tipoperfil, double fy, double vxsd, double elast)
        {
            pai = f_principal;
            double d = 0;
            if (tipoperfil == "i")
            {
               tw = PropPerfilI.tw / 10.0;
               h = PropPerfilI.dlinha / 10.0;
               d = PropPerfilI.d / 10.0;
            }
            if (tipoperfil == "u")
            {
                tw = PropPerfilU.tw / 10.0;
                d = PropPerfilU.d;
                double tf = PropPerfilU.tf;
                h = (d - 2 * tf) / 10.0;
            }
            aw = d * tw;
            bt = h / tw;
            vpl = 0.6 * aw * fy;

            btp = 1.10 * Math.Sqrt((5.0 * elast) / fy);
            btr = 1.37 * Math.Sqrt((5.0 * elast) / fy);

            if (bt <= btp)
            {
                vrd = vpl / 1.10;
            }else if(bt > btp && bt <= btr)
                {
                vrd = (btp / bt) * (vpl / 1.10);
            }
            else if(bt > btr)
            {
                vrd = 1.24 * Math.Pow((btp / bt), 2.0) * (vpl / 1.10);
            }

            //Preenche o valor da resistencia final no txt_ntrd
            taxa = vxsd / vrd;
            pai.txt_vxrd.Text = vrd.ToString("F2");
            pai.lb_sdrd_vx.Text = $"Sd/Rd = {taxa:F2}";
            if(taxa <= 1.0)
            {
                pai.lb_sdrd_vx.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                pai.lb_sdrd_vx.ForeColor = System.Drawing.Color.Red;
            }
        }

        public void CalculaCortanteY(F_Principal f_principal, string tipoperfil, double fy, double vysd, double elast)
        {
            pai = f_principal;
            double tf = 0;
            double bf = 0;
            if (tipoperfil == "i")
            {
                tw = PropPerfilI.tf / 10.0;
                h = PropPerfilI.bf / 20.0;
                tf = PropPerfilI.tf / 10.0;
                bf = PropPerfilI.bf / 10.0;
            }
            if (tipoperfil == "u")
            { 
                tf = PropPerfilU.tf / 10.0;
                h = PropPerfilU.bf / 10.0;
                tw = PropPerfilU.tf / 10.0;
                bf = PropPerfilU.bf / 10.0;
            }
            aw = 2 * tf * bf;
            bt = h / tw;
            vpl = 0.6 * aw * fy;

            btp = 1.10 * Math.Sqrt((1.2 * elast) / fy);
            btr = 1.37 * Math.Sqrt((1.2 * elast) / fy);

            if (bt <= btp)
            {
                vrd = vpl / 1.10;
            }
            else if (bt > btp && bt <= btr)
            {
                vrd = (btp / bt) * (vpl / 1.10);
            }
            else if (bt > btr)
            {
                vrd = 1.24 * Math.Pow((btp / bt), 2.0) * (vpl / 1.10);
            }

            //Preenche o valor da resistencia final no txt_ntrd
            taxa = vysd / vrd;
            pai.txt_vyrd.Text = vrd.ToString("F2");
            pai.lb_sdrd_vy.Text = $"Sd/Rd = {taxa:F2}";
            if (taxa <= 1.0)
            {
                pai.lb_sdrd_vy.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                pai.lb_sdrd_vy.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}

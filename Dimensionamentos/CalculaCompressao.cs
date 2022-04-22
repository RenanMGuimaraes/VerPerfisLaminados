using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerPerfisLaminados
{
    internal class CalculaCompressao
    {
        F_Principal pai;
        public CalculaCompressao(F_Principal f_Principal, string tipoperfil, double fy, double fu, double ncsd, double lx, double ly, double lz, double elast, double g)
        {
            fy = fy / 10.0; //Converte de MPa para kN/cm2
            elast /= 10.0; //Converte de MPa para kN/cm2
            pai = f_Principal;
            double ncrd = 0;
            double ag = 0;
            double taxa = 0;
            double q = CalculaQ(tipoperfil, elast, fy);
            double x = CalculaX(tipoperfil, elast, g, lx, ly, lz, q, fy);
            double rmin = 0;

            if (tipoperfil == "i")
            {
                ag = PropPerfilI.area;
                rmin = PropPerfilI.ry;
                ncrd = (q * x * ag * fy) / 1.10;
                taxa = ncsd / ncrd;
                pai.lb_sdrd_nc.Text = $"Sd/Rd = {taxa:F2}";
                if (ncrd >=  ncsd){
                    pai.lb_sdrd_nc.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    pai.lb_sdrd_nc.ForeColor = System.Drawing.Color.Red;
                }
                

            }
            if (tipoperfil == "u")
            {
                ag = PropPerfilU.area;
                rmin = PropPerfilU.ry;
                ncrd = (q * x * ag * fy) / 1.10;
                taxa = ncsd / ncrd;
                pai.lb_sdrd_nc.Text = $"Sd/Rd = {taxa:F2}";
                if (ncrd >= ncsd)
                {
                    pai.lb_sdrd_nc.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    pai.lb_sdrd_nc.ForeColor = System.Drawing.Color.Red;
                }
            }
            if (tipoperfil == "l")
            {
                ag = PropPerfilL.area;
                rmin = PropPerfilL.rz;
                ncrd = (q * x * ag * fy) / 1.10;
                taxa = ncsd / ncrd;
                pai.lb_sdrd_nc.Text = $"Sd/Rd = {taxa:F2}";
                if (ncrd >= ncsd)
                {
                    pai.lb_sdrd_nc.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    pai.lb_sdrd_nc.ForeColor = System.Drawing.Color.Red;
                }
            }
            pai.txt_ncrd.Text = ncrd.ToString("F2");

            //ELS
            double l = Math.Min(lx, Math.Min(ly, lz));
            double esb = l / rmin;

            if(esb > 200)
            {
                pai.txt_ncrd_esb.Text = "Falha na esbeltez";
                pai.txt_ncrd_esb.ForeColor = System.Drawing.Color.Red;
            }


        }
        public double CalculaQ(string tipoperfil, double elast, double fy)
        {
            double q = 0;
            double qa;
            double qs = 0;
            double btlim;
            double t;
            double b;
            if (tipoperfil =="i")
            {
                //Alma
                t = PropPerfilI.tw;
                b = PropPerfilI.dlinha;
                btlim = 1.49 * Math.Sqrt(elast / fy);
                double btalma = b / t;

                if (btalma <= btlim)
                {
                    qa = 1.0;
                }
                else
                {
                    //Área efetiva
                    double ag = PropPerfilI.area;
                    t /= 10.0; //converte de mm para cm
                    b /= 10.0; //converte de mm para cm
                    double bef = 1.92 * t * Math.Sqrt(elast / fy) * (1.0 - (0.34 / btalma) * Math.Sqrt(elast / fy));
                    if (bef > b)
                    {
                        bef = b;
                    }
                    double ae = ag - (b - bef)*t;
                    qa = ae / ag;
                }

                //Mesa               
                b = PropPerfilI.bf / 2.0;
                t = PropPerfilI.tf;
                btlim = 0.56 * Math.Sqrt(elast / fy);
                double btmesa = b / t;
                if (btmesa <= btlim)
                {
                    qs = 1.0;
                }
                else
                {
                    if (btmesa > (0.56 * Math.Sqrt(elast / fy)) && btmesa <= (1.03 * Math.Sqrt(elast / fy)))
                    {
                        qs = 1.415 - 0.74 * btmesa * Math.Sqrt(elast / fy);
                    }
                    if (btmesa > 1.03 * Math.Sqrt(elast / fy))
                    {
                        qs = (0.69 * elast) / (fy * Math.Pow(btmesa, 2.0));
                    }
                }

                q = qs * qa;

            }
            if (tipoperfil =="u")
            {
                //Alma
                t = PropPerfilU.tw;
                b = PropPerfilU.d - 2*PropPerfilU.tf;
                btlim = 1.49 * Math.Sqrt(elast / fy);
                double btalma = b / t;

                if (btalma <= btlim)
                {
                    qa = 1.0;
                }
                else
                {
                    //Área efetiva
                    double ag = PropPerfilU.area;
                    t /= 10.0; //converte de mm para cm
                    b /= 10.0; //converte de mm para cm
                    double bef = 1.92 * t * Math.Sqrt(elast / fy) * (1.0 - (0.34 / btalma) * Math.Sqrt(elast / fy));
                    if (bef > b)
                    {
                        bef = b;
                    }
                    double ae = ag - (b - bef) * t;
                    qa = ae / ag;
                }

                //Mesa               
                b = PropPerfilU.bf / 2.0;
                t = PropPerfilU.tf;
                btlim = 0.45 * Math.Sqrt(elast / fy);
                double btmesa = b / t;
                if (btmesa <= btlim)
                {
                    qs = 1.0;
                }
                else
                {
                    if (btmesa > (0.56 * Math.Sqrt(elast / fy)) && btmesa <= (1.03 * Math.Sqrt(elast / fy)))
                    {
                        qs = 1.415 - 0.74 * btmesa * Math.Sqrt(elast / fy);
                    }
                    if (btmesa > 1.03 * Math.Sqrt(elast / fy))
                    {
                        qs = (0.69 * elast) / (fy * Math.Pow(btmesa, 2.0));
                    }
                }

                q = qs * qa;

            }
            if (tipoperfil == "l")
            {
                //Aba
                btlim = 0.45 * Math.Sqrt(elast / fy);
                b = PropPerfilL.b;
                t = PropPerfilL.t;
                double btaba = b / t;
                if (btaba <= btlim)
                {
                    q = 1.0;
                }
                else
                {
                    if (btaba > (0.45 * Math.Sqrt(elast / fy)) && btaba <= (0.91 * Math.Sqrt(elast / fy)))
                    {
                        qs = 1.340 - 0.76 * btaba * Math.Sqrt(elast / fy);
                    }
                    if (btaba > 0.91 * Math.Sqrt(elast / fy))
                    {
                        qs = (0.53 * elast) / (fy * Math.Pow(btaba, 2.0));
                    }
                    q = qs;

                }
                  
            }
            return q;
        }

        public double CalculaX(string tipoperfil, double elast, double g, double lx, double ly, double lz, double q, double fy)
        {
            double x = 0;
            double ne = 0;
            double lamb0 = 0;
            double ag = 0;
            
            if (tipoperfil =="i")
            {
                double Ix = PropPerfilI.Ix;
                double Iy = PropPerfilI.Iy;
                double It = PropPerfilI.It;
                double rx = PropPerfilI.rx;
                double ry = PropPerfilI.ry;
                double cw = PropPerfilI.Cw;
                double r0 = Math.Sqrt(rx * rx + ry * ry);
                ag = PropPerfilI.area;
                

                //Flambagem elastica em torno de X e Y e por torção
                double nex = (Math.Pow(Math.PI, 2.0) * elast * Ix) / Math.Pow(lx, 2.0);
                double ney = (Math.Pow(Math.PI, 2.0) * elast * Iy) / Math.Pow( ly, 2.0);
                double nez = (1.0 / Math.Pow(r0, 2.0)) * ((Math.Pow(Math.PI, 2.0) * elast * cw) / Math.Pow(lz, 2.0) + g *It);

                ne = Math.Min(nex, Math.Min(ney, nez));
           
            }
            if (tipoperfil =="u")
            {
                double Ix = PropPerfilU.Ix;
                double Iy = PropPerfilU.Iy;
                double It = PropPerfilU.It;
                double rx = PropPerfilU.rx;
                double ry = PropPerfilU.ry;
                double cw = PropPerfilU.Cw;
                double r0 = Math.Sqrt(rx * rx + ry * ry);
                double y0 = 0.0;
                ag = PropPerfilU.area;

                //Flambagem elastica em torno de X e Y e por torção
                double nex = (Math.Pow(Math.PI, 2.0) * elast * Ix) / Math.Pow(lx, 2.0);
                double ney = (Math.Pow(Math.PI, 2.0) * elast * Iy) / Math.Pow(ly, 2.0);
                double nez = (1.0 / Math.Pow(r0, 2.0)) * ((Math.Pow(Math.PI, 2.0) * elast * cw) / Math.Pow(lz, 2.0) + g * It);

                ne = ((ney + nez) / (2 * (1 - Math.Pow((y0 / r0), 2.0)))) * (1 - Math.Sqrt(1 - (4*ney*nez*(1-Math.Pow((y0/r0), 2.0)))/Math.Pow((ney + nez),2.0)));
            }
            if (tipoperfil =="l") //TODO
            {

            }

            lamb0 = Math.Sqrt((q * ag * fy) / ne);

            if(lamb0 <= 1.5)
            {
                x = Math.Pow(0.685, (lamb0 * lamb0));
            }
            else
            {
                x = 0.877 / (lamb0 * lamb0);
            }

            return x;

        }

       
    }
}

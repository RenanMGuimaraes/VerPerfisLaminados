using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerPerfisLaminados
{
    internal class CalculaCompressao
    {
        public double CalculaQ(string tipoperfil, double e, double fy)
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
                btlim = 1.49 * Math.Sqrt(e / fy);
                double btalma = b / t;

                if (btalma <= btlim)
                {
                    qa = 1.0;
                }
                else
                {
                    //Área efetiva
                    double ag = PropPerfilI.area;
                    double bef = 1.92 * t * Math.Sqrt(e / fy) * (1.0 - (0.34 / btalma) * Math.Sqrt(e / fy));
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
                btlim = 0.56 * Math.Sqrt(e / fy);
                double btmesa = b / t;
                if (btmesa <= 1.0)
                {
                    qs = 1.0;
                }
                else
                {
                    if (btmesa > (0.56 * Math.Sqrt(e / fy)) && btmesa <= (1.03 * Math.Sqrt(e / fy)))
                    {
                        qs = 1.415 - 0.74 * btmesa * Math.Sqrt(e / fy);
                    }
                    if (btmesa > 1.03 * Math.Sqrt(e / fy))
                    {
                        qs = (0.69 * e) / (fy * Math.Pow(btmesa, 2.0));
                    }
                }

                q = qs * qa;

            }
            if (tipoperfil =="u")
            {
                //Alma
                t = PropPerfilU.tw;
                b = PropPerfilU.d - 2*PropPerfilU.tf;
                btlim = 1.49 * Math.Sqrt(e / fy);
                double btalma = b / t;

                if (btalma <= btlim)
                {
                    qa = 1.0;
                }
                else
                {
                    //Área efetiva
                    double ag = PropPerfilU.area;
                    double bef = 1.92 * t * Math.Sqrt(e / fy) * (1.0 - (0.34 / btalma) * Math.Sqrt(e / fy));
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
                btlim = 0.45 * Math.Sqrt(e / fy);
                double btmesa = b / t;
                if (btmesa <= 1.0)
                {
                    qs = 1.0;
                }
                else
                {
                    if (btmesa > (0.56 * Math.Sqrt(e / fy)) && btmesa <= (1.03 * Math.Sqrt(e / fy)))
                    {
                        qs = 1.415 - 0.74 * btmesa * Math.Sqrt(e / fy);
                    }
                    if (btmesa > 1.03 * Math.Sqrt(e / fy))
                    {
                        qs = (0.69 * e) / (fy * Math.Pow(btmesa, 2.0));
                    }
                }

                q = qs * qa;

            }
            if (tipoperfil == "l")
            {
                //Aba
                btlim = 0.45 * Math.Sqrt(e / fy);
                b = PropPerfilL.b;
                t = PropPerfilL.t;
                double btaba = b / t;
                if (btaba <= btlim)
                {
                    q = 1.0;
                }
                else
                {
                    if (btaba > (0.45 * Math.Sqrt(e / fy)) && btaba <= (0.91 * Math.Sqrt(e / fy)))
                    {
                        qs = 1.340 - 0.76 * btaba * Math.Sqrt(e / fy);
                    }
                    if (btaba > 0.91 * Math.Sqrt(e / fy))
                    {
                        qs = (0.53 * e) / (fy * Math.Pow(btaba, 2.0));
                    }
                    q = qs;

                }
                  
            }
            return q;
        }

        public double CalculaX(string tipoperfil, double e, double lx, double ly, double lz)
        {
            double x;
            if (tipoperfil =="i")
            {
                double Ix = PropPerfilI.Ix;
                double Iy = PropPerfilI.Iy;
                double It = PropPerfilI.It;
                double rx = PropPerfilI.rx;
                double ry = PropPerfilI.ry;
                double cw = PropPerfilI.Cw;
                double r0 = Math.Sqrt(rx * rx + ry * ry);
                double kx = 1.0;
                double ky = 1.0;
                double kz = 1.0;
                double G = e / 2.6;
                //Flambagem elastica em torno de X e Y e por torção
                double nex = (Math.Pow(Math.PI, 2.0) * e * Ix) / Math.Pow((kx * lx), 2.0);
                double ney = (Math.Pow(Math.PI, 2.0) * e * Iy) / Math.Pow((ky * ly), 2.0);
                double nez = (1.0 / Math.Pow(r0, 2.0)) * ((Math.Pow(Math.PI, 2.0) * e * cw) / Math.Pow((kz * lz), 2.0) + G *It);

            }
            if (tipoperfil =="u")
            {

            }
            if (tipoperfil =="l")
            {

            }

            return x;

        }

        public string Compressao(string tipoperfil, double e, double fy, double lx, double ly)
        {
            fy = fy / 10.0; //Converte de MPa para kN/cm2
            e = e / 10.0; 
            double q = CalculaQ(tipoperfil, e, fy);
            double x = CalculaX(tipoperfil, e, lx, ly);

            return;

        }
    }
}

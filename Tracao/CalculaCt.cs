using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerPerfisLaminados
{
    internal class CalculaCt
    {
        double ct;
        public double Ct1()
        {
            double ct = 1.0;

            return ct;
        }
        
        public double Ct2(double ac, string tipoperfil)
        {
            
            double area = 1.0;
            if (tipoperfil == "i")
            {
                area = PropPerfilI.area;
            }
            if (tipoperfil == "u")
            {
                area = PropPerfilU.area;
            }
            if (tipoperfil == "l")
            {
                area = PropPerfilL.area;
            }
            if (tipoperfil == "chapa")
            {
                area = PropChapa.area;
            }

            ct = ac / area;
            if (ct > 0.9)
            {
                ct = 0.9;
            }

            return ct;
        }

        public double Ct3(double lc, string tipoperfil)
        {
            
            double ec = 1.0;

            //Calculo de ec para perfil I
            if (tipoperfil == "i")
            {
                double bf = PropPerfilI.bf;
                double tf = PropPerfilI.tf;
                double d = PropPerfilI.d;
                double tw = PropPerfilI.tw;
                double amesa = ((bf / 2.0) - (tw / 2.0)) * tf * 2; //area das duas abas
                double aalma = d * (tw / 2.0); //area da alma
                double ymesa = bf / 2.0; //Y da mesa
                double yalma = tw / 4.0; //Y da alma
                double cg = ((amesa * ymesa * 2.0) + (aalma * yalma)) / (amesa * 2.0 + aalma); //calculo do cg em mm
                ec = (cg - (tw / 2.0)) / 10; //retorna ec em cm    
            }

            if (tipoperfil == "u")
            {
                ec = PropPerfilU.x;
            }
            if (tipoperfil == "l")
            {
                ec = PropPerfilL.x;
            }
            if (tipoperfil == "chapa")
            {
                ec = 1.0;
            }

            ct = 1 - ec / lc;

            return ct;

        }

        public double Ct4(double b, double lw)
        {
            if ( lw >= 2 * b)
            {
                ct = 1.0;
            }
            if (lw >= (1.5 * b) && lw < (2.0 *b))
            {
                ct = 0.87;
            }
            if( lw >= b && lw < (1.5 * b))
            {
                ct = 0.75;
            }

            return ct;

        }
    }
}

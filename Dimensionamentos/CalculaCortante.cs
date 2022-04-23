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

        public CalculaCortante(F_Principal f_Principal,string tipoperfil, double fy, double vxsd, double elast)
        {
            pai = f_Principal;

            double aw = 0;
            double tw = 0, b = 0;
            double bt = 0;
            double btp = 0;
            double btr = 0;

            if (tipoperfil == "i")
            {
               tw = PropPerfilI.tw / 10.0;
               b = PropPerfilI.dlinha / 10.0;
               

            }
            if (tipoperfil == "u")
            {
                tw = PropPerfilU.tw / 10.0;
                double d = PropPerfilU.d;
                double tf = PropPerfilU.tf;
                b = (d - 2 * tf) / 10.0;
            }
            aw = tw * b;
            bt = b / tw;
            btp = 1.10 * Math.Sqrt((5.0 * elast) / fy);
            btr = 1.37 * Math.Sqrt((5.0 * elast) / fy);

            if (bt <= btp)
            {

            }else if(bt > btp && bt <= btr)
                {
                
            }
            else if(bt > btr)
            {

            }
        }
    }
}

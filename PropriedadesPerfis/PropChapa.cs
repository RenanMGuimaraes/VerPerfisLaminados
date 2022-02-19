using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace VerPerfisLaminados
{
    internal class PropChapa
    {
        public static double area;

       

        public string AreaChapa(F_Tracao1 f_Tracao1)
        {
            string propchapa = f_Tracao1.txt_prop.Text;
            propchapa = propchapa.Substring(74,2);
            area = double.Parse(propchapa);
            MessageBox.Show(area.ToString("F2"));

            return $"Área: {area:F2} \r\n \r\n";
        }


    }
}

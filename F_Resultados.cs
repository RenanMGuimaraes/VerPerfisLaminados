using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerPerfisLaminados
{
    public partial class F_ResComp : Form
    {
        public F_ResComp(string tipoperfil, string resultado)
        {
            InitializeComponent();

            txt_memorial.Text = "MEMORIAL DE CÁLCULO \n\n";
            if (tipoperfil == "i")
            {
                txt_memorial.Text += $"PERFIL: {PropPerfilI.perfil} \n\n";
            }
            if (tipoperfil == "u")
            {
                txt_memorial.Text += $"PERFIL: {PropPerfilU.perfil} \n\n";
            }
            if (tipoperfil == "l")
            {
                txt_memorial.Text += $"PERFIL: {PropPerfilL.perfil} \n\n";
            }

            txt_memorial.Text = resultado.Replace("\n", Environment.NewLine);
            

        }
       
    }
}

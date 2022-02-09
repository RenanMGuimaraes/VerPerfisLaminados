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
    public partial class F_principal : Form
    {
        public F_principal()
        {
            InitializeComponent();
        }

        private void btnPerfilLaminado_Click(object sender, EventArgs e)
        {
            F_perfilLaminado f_PerfilLaminado = new F_perfilLaminado();
            f_PerfilLaminado.Show();
        }
    }
}

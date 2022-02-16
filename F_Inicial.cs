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
    public partial class F_Inicial : Form
    {
        public F_Inicial()
        {
            InitializeComponent();
        }

        private void btn_tracao_Click(object sender, EventArgs e)
        {
            F_principal f_Principal = new F_principal();
            f_Principal.ShowDialog();
        }
    }
}

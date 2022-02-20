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
    public partial class F_DadosAco : Form
    {
        F_Principal pai;
        public F_DadosAco(F_Principal f_Principal)
        {
            InitializeComponent();
            pai = f_Principal;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txt_L_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            pai.fy = double.Parse(txt_escoamento.Text)/ 10.0;
            pai.fu = double.Parse(txt_ruptura.Text) / 10.0;
            pai.e = double.Parse(txt_escoamento.Text) / 10.0;
            pai.g = double.Parse(txt_g.Text) / 10.0;
        }
    }
}

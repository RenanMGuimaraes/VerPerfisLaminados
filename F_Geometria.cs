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
    public partial class F_Geometria : Form
    {
        F_Principal pai;
        public F_Geometria(F_Principal f_Principal, double lx, double ly, double lz)
        {
            InitializeComponent();
            pai = f_Principal;
            txt_x.Text = lx.ToString("F2");
            txt_y.Text = ly.ToString("F2");
            txt_z.Text = lz.ToString("F2");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            pai.lx = double.Parse(txt_x.Text);
            pai.ly = double.Parse(txt_y.Text);
            pai.lz = double.Parse(txt_z.Text);
            pai.txt_resultadoTracao.Text = "";
            pai.lbl_verifTracao.Text = "";
            this.Close();
        }

        private void txt_x_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_y_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_z_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}

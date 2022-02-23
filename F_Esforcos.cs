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
    public partial class F_Esforcos : Form
    {
        F_Principal pai;
        public F_Esforcos(F_Principal f_Principal, double ftsd, double fnsd, double fvsd, double mxsd, double mysd)
        {
            InitializeComponent();
            pai = f_Principal;
            txt_tracao.Text = ftsd.ToString("F2");
            txt_compressao.Text = fnsd.ToString("F2");
            txt_cortante.Text = fvsd.ToString("F2");
            txt_momx.Text = mxsd.ToString("F2");
            txt_momy.Text = mysd.ToString("F2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_tracao.Text == "")
            {

            }
            else
            {
                pai.ftsd = double.Parse(txt_tracao.Text);
            }
            if (txt_compressao.Text =="")
            {

            }
            else
            {
                pai.fnsd = double.Parse(txt_compressao.Text);
            }
            if (txt_cortante.Text =="")
            {

            }
            else
            {
                pai.fvsd = double.Parse(txt_cortante.Text);
            }
            if (txt_momx.Text == "")
            {

            }
            else
            {
                pai.mxsd = double.Parse(txt_momx.Text);
            }
            if (txt_momy.Text == "")
            {

            }
            else
            {
                pai.mysd = double.Parse(txt_momy.Text);
            }
            pai.txt_resultadoTracao.Text = "";
            pai.lbl_verifTracao.Text = "";
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Não é necessário preencher todos os campos. O aplicativo fará a verificação apenas dos preenchidos.", "Dica", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txt_tracao_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_compressao_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_momx_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_momy_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_v_KeyPress(object sender, KeyPressEventArgs e)
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

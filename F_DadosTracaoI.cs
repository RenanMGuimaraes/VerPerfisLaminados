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
    public partial class F_DadosTracao : Form
    {
        F_TracaoI pai;
        public F_DadosTracao(F_TracaoI f_Principal)
        {
            InitializeComponent();
            pai = f_Principal;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Verifica o tipo de Ct
            if (rb_ct1.Checked)
            {
                pai.tipoCt = 1;
            }
            else if (rb_ct2.Checked)
            {
                pai.tipoCt = 2;
            }
            else if (rb_ct3.Checked)
            {
                pai.tipoCt=3;
            }
            //Verifica o tipo de ligação
            if (rb_alma.Checked)
            {
                pai.lig = "alma";
            }
            else if(rb_mesa.Checked)
            {
                pai.lig = "mesa";
            }
            pai.numfuros = int.Parse(cb_numfuros.Text);
            pai.diam = double.Parse(cb_diamparafusos.Text);
            pai.punc = double.Parse(txt_puncionamento.Text);
            pai.folga = double.Parse(txt_folgaFuro.Text);
            pai.lc = double.Parse(txt_lc.Text);
            pai.ac = double.Parse(txt_ac.Text);
            pai.txt_resultado.Text = "";
            pai.lbl_verif.Text = "";
            this.Close();
        }

        private void F_DadosTracao_Load(object sender, EventArgs e)
        {

        }

        private void btn_ac_Click(object sender, EventArgs e)
        {
           F_TracaoIHelp f_TracaoHelp = new F_TracaoIHelp();
            f_TracaoHelp.ShowDialog();
        }

        private void txt_puncionamento_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_folgaFuro_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_lc_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_ac_KeyPress(object sender, KeyPressEventArgs e)
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

        private void rb_ct1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

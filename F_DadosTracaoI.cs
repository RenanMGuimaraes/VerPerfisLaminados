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
    public partial class F_DadosTracaoI : Form
    {
        F_Principal pai;
        public F_DadosTracaoI(F_Principal f_Principal, int tipoCt, int numfurosAlma, int numfurosMesa, double diam, double punc, double folga, double lc, double ac)
        {
            InitializeComponent();
            pai = f_Principal;
            cb_numfurosAlma.Text = numfurosAlma.ToString();
            cb_numfurosMesa.Text = numfurosMesa.ToString();
            cb_diamparafusos.Text = diam.ToString();
            txt_puncionamento.Text = punc.ToString();
            txt_folgaFuro.Text = folga.ToString();
            txt_lc.Text = lc.ToString();
            txt_ac.Text = ac.ToString();

            if (tipoCt == 1)
            {
                rb_ct1.Checked = true;
            }
            if (tipoCt == 2)
            {
                rb_ct2.Checked = true;
            }
            if (tipoCt == 3)
            {
                rb_ct3.Checked = true;
            }
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
            pai.numfurosAlma = int.Parse(cb_numfurosAlma.Text);
            pai.numfurosMesa = int.Parse(cb_numfurosMesa.Text);
            pai.diam = double.Parse(cb_diamparafusos.Text);
            pai.punc = double.Parse(txt_puncionamento.Text);
            pai.folga = double.Parse(txt_folgaFuro.Text);
            pai.lc = double.Parse(txt_lc.Text);
            pai.ac = double.Parse(txt_ac.Text);
            pai.txt_resultadoTracao.Text = "";
            pai.lbl_verifTracao.Text = "";
            this.Close();
        }

        private void F_DadosTracao_Load(object sender, EventArgs e)
        {

        }

        private void btn_ac_Click(object sender, EventArgs e)
        {
           F_TracaoHelp f_TracaoHelp = new F_TracaoHelp();
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
            txt_ac.Enabled = false;
            cb_diamparafusos.Enabled = true;
            cb_numfurosAlma.Enabled = true;
            cb_numfurosMesa.Enabled = true;
            txt_puncionamento.Enabled = true;
            txt_folgaFuro.Enabled = true;
            txt_lc.Enabled = false;
        }

        private void rb_ct2_CheckedChanged(object sender, EventArgs e)
        {
            txt_ac.Enabled = true;
            cb_diamparafusos.Enabled = false;
            cb_numfurosAlma.Enabled = false;
            cb_numfurosMesa.Enabled = false;
            txt_puncionamento.Enabled = false;
            txt_folgaFuro.Enabled = false;
            txt_lc.Enabled = false;
            cb_numfurosAlma.Text = "0";
            cb_numfurosMesa.Text = "0";
        }

        private void rb_ct3_CheckedChanged(object sender, EventArgs e)
        {
            txt_ac.Enabled = false;
            cb_diamparafusos.Enabled = true;
            cb_numfurosAlma.Enabled = true;
            cb_numfurosMesa.Enabled = true;
            txt_puncionamento.Enabled = true;
            txt_folgaFuro.Enabled = true;
            txt_lc.Enabled = true;
        }

        private void rb_alma_CheckedChanged(object sender, EventArgs e)
        {
            cb_numfurosMesa.Text = "0";
            cb_numfurosAlma.Enabled = true;
            cb_numfurosMesa.Enabled = false;
        }

        private void rb_mesa_CheckedChanged(object sender, EventArgs e)
        {
            cb_numfurosAlma.Text="0";
            cb_numfurosMesa.Enabled=true;
            cb_numfurosAlma.Enabled=false;
        }

        private void rb_ambos_CheckedChanged(object sender, EventArgs e)
        {
            cb_numfurosAlma.Enabled = true;
            cb_numfurosMesa.Enabled = true;
        }
    }
}

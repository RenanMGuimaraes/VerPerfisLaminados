using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace VerPerfisLaminados
{
    public partial class F_Principal : Form
    {

        public F_Principal()
        {
            InitializeComponent();
    }

        //Variáveis gerais
        string tipoperfil = "i"; //Usado para checar o tipo de perfil a ser plotado na listbox


        //Esforços solicitantes
        public double ftsd = 0;
        public double fcsd = 0;
        public double fvxsd = 0;
        public double fvysd = 0;
        public double mxsd = 0;
        public double mysd = 0;

        //Variaveis gerais - tração
        public int tipoCt = 1;
        public string lig = "alma"; // define se a ligação é feita na alma, na mesa ou ambos.
        public double punc = 2.0;
        public double folga = 1.5;
        public double diam = 12.5;
        public int numfuros = 0;
        public int numfurosAlma = 0;
        public int numfurosMesa = 0;
        public double lc = 0;
        public double ac = 0;

        //Variaveis gerais - compressão

        //Variaveis gerais - flexão

        private void btn_apagar_Click(object sender, EventArgs e)
        {

            lbl_verifTracao.Text = "";
        }    

        //PLOTA OS PERFIS DO LB_LIST NO TXT_PROP
        private void lb_perfis_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = lb_perfis.SelectedIndex;
            if (tipoperfil == "i")
            {
                PropPerfilI propPerfilI = new PropPerfilI();
                txt_prop.Text = propPerfilI.PlotarI(id);
            }
            if (tipoperfil == "l")
            {
                PropPerfilL propPerfilL = new PropPerfilL();
                txt_prop.Text = propPerfilL.PlotarL(id);
            }
            if (tipoperfil == "u")
            {
                PropPerfilU propPerfilU = new PropPerfilU();
                txt_prop.Text = propPerfilU.PlotarU(id);
            }  
        }  

        private void rb_perfilI_CheckedChanged(object sender, EventArgs e)
        {
            tipoperfil = "i";

            //Carrega Imagem Perfil I
            Assembly imagemI = Assembly.GetExecutingAssembly();
            Stream streamPerfilI = imagemI.GetManifestResourceStream("VerPerfisLaminados.Imagens.Prop_i.png");
            pct_perfil.Image = new Bitmap(streamPerfilI);

            //Carrega lista de perfis I
            Assembly ListaI = Assembly.GetExecutingAssembly();
            StreamReader readerPerfilI = new StreamReader(ListaI.GetManifestResourceStream("VerPerfisLaminados.Txt.lista_perfisI.txt"));
            string[] convertePerfilI = readerPerfilI.ReadToEnd().Split('\u000A');
            List<string> listaFinalI = new List<string>(convertePerfilI);
            lb_perfis.DataSource = listaFinalI;
        }

        private void rb_cantoneira_CheckedChanged(object sender, EventArgs e)
        {
            tipoperfil = "l";

            //Carrega Imagem Perfil L
            Assembly imagemL = Assembly.GetExecutingAssembly();
            Stream streamPerfilL = imagemL.GetManifestResourceStream("VerPerfisLaminados.Imagens.Prop_L.png");
            pct_perfil.Image = new Bitmap(streamPerfilL);

            //Carrega lista de perfis L
            Assembly ListaL = Assembly.GetExecutingAssembly();
            StreamReader readerPerfilL = new StreamReader(ListaL.GetManifestResourceStream("VerPerfisLaminados.Txt.lista_perfisL.txt"));
            string[] convertePerfilL = readerPerfilL.ReadToEnd().Split('\u000A');
            List<string> listaFinalL = new List<string>(convertePerfilL);
            lb_perfis.DataSource = listaFinalL;
        }

        private void rb_perfilU_CheckedChanged(object sender, EventArgs e)
        {
            tipoperfil = "u";

            //Carrega Imagem Perfil U
            Assembly imagemU = Assembly.GetExecutingAssembly();
            Stream streamPerfilU = imagemU.GetManifestResourceStream("VerPerfisLaminados.Imagens.Prop_U.png");
            pct_perfil.Image = new Bitmap(streamPerfilU);

            //Carrega lista de perfis U
            Assembly ListaU = Assembly.GetExecutingAssembly();
            StreamReader readerPerfilU = new StreamReader(ListaU.GetManifestResourceStream("VerPerfisLaminados.Txt.lista_perfisU.txt"));
            string[] convertePerfilU = readerPerfilU.ReadToEnd().Split('\u000A');
            List<string> listaFinalU = new List<string>(convertePerfilU);
            lb_perfis.DataSource = listaFinalU;

        }
        private void rb_duploU_CheckedChanged(object sender, EventArgs e)
        {
            tipoperfil = "2u";

            //Carrega Imagem Perfil 2U
            Assembly imagemU = Assembly.GetExecutingAssembly();
            Stream streamPerfilU = imagemU.GetManifestResourceStream("VerPerfisLaminados.Imagens.Prop_2U.png");
            pct_perfil.Image = new Bitmap(streamPerfilU);

            //Carrega lista de perfis U
            Assembly ListaU = Assembly.GetExecutingAssembly();
            StreamReader readerPerfilU = new StreamReader(ListaU.GetManifestResourceStream("VerPerfisLaminados.Txt.lista_perfis2U.txt"));
            string[] convertePerfilU = readerPerfilU.ReadToEnd().Split('\u000A');
            List<string> listaFinalU = new List<string>(convertePerfilU);
            lb_perfis.DataSource = listaFinalU;
        }
        private void rb_duploL_CheckedChanged(object sender, EventArgs e)
        {
            tipoperfil = "2l";
        }
        private void rb_chapa_CheckedChanged(object sender, EventArgs e)
        {
            tipoperfil = "chapa";
            txt_prop.Text = "";
           

            //Limpa a Lb_perfis
            List<string> vazio = new List<string>();
            vazio.Add("");
            lb_perfis.DataSource = vazio;

            //Carrega Imagem Chapa
            Assembly imagemChapa = Assembly.GetExecutingAssembly();
            Stream streamChapa = imagemChapa.GetManifestResourceStream("VerPerfisLaminados.Imagens.dimChapa.png");
            pct_perfil.Image = new Bitmap(streamChapa);
        }


        private void dadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void traçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tipoperfil =="i" || tipoperfil == "u")
            {
                F_DadosTracaoI f_DadosTracao = new F_DadosTracaoI(this, tipoCt, lig, numfurosAlma, numfurosMesa, diam, punc, folga, lc, ac);
                f_DadosTracao.ShowDialog();
            }
            if (tipoperfil == "l")
            {
                F_DadosTracaoL f_DadosTracaoL = new F_DadosTracaoL(this,tipoCt, numfuros, diam, punc, folga, lc, ac);
                f_DadosTracaoL.ShowDialog();
            }
            
        }

        private void compressãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_DadosCompressao f_DadosCompressao = new F_DadosCompressao();
            f_DadosCompressao.ShowDialog();
        }

        private void flexãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_DadosFlexao f_DadosFlexao = new F_DadosFlexao();
            f_DadosFlexao.ShowDialog();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Sobre f_Sobre = new F_Sobre();
            f_Sobre.ShowDialog();
        }

        private void F_Principal_Load(object sender, EventArgs e)
        {

        }

        private void exportarPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            //Propriedades gerais 
            double lx = double.Parse(txt_lx.Text);
            double ly = double.Parse(txt_ly.Text);
            double lz = double.Parse(txt_lz.Text);
            double lb = double.Parse(txt_lb.Text);

            //Propriedades gerais do aço
            double fy = double.Parse(txt_fy.Text);
            double fu = double.Parse(txt_fu.Text);
            double elast = double.Parse(txt_e.Text);
            double g = double.Parse(txt_g.Text);

            //Limpa os textos dos resultados
            txt_ntrd_esb.Text = "";

        CalculaCompressao compressao = new CalculaCompressao();
            CalculaFlexao flexao = new CalculaFlexao();

            //Calculo a tracao
            double ntsd = double.Parse(txt_ntsd.Text);
            CalculaTracao tracao = new CalculaTracao(this, tipoperfil, fy, fu, ntsd, lx, ly, lz);

            CalculaCortante cortante = new CalculaCortante();
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txt_ncsd_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_ntsd_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_vxsd_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_vysd_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_mxsd_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_mysd_KeyPress(object sender, KeyPressEventArgs e)
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

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void txt_elasticidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void txt_g_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

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

        //Propriedades gerais do aço
        public double fy = 34.5;
        public double fu = 45.0;
        public double e = 20.000;
        public double g = 77.000;

        //Esforços solicitantes
        public double ftsd = 0;
        public double fnsd = 0;
        public double fvsd = 0;
        public double mxsd = 0;
        public double mysd = 0;


        //Variaveis gerais - tração
        public int tipoCt = 1;
        double ct = 1.0;
        double Ftsd = 0;
        double punc = 2.0;
        double folga = 1.5;
        double diam = 12.5;
        double numfuros = 0;
        double lw = 0;

        //Variaveis gerais - compressão

        //Variaveis gerais - flexão

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            txt_resultadoTracao.Text = "";
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
            F_DadosTracao f_DadosTracao = new F_DadosTracao();
            f_DadosTracao.ShowDialog();
        }

        private void açoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_DadosAco f_DadosAco = new F_DadosAco(this);
            f_DadosAco.ShowDialog();
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

        private void btn_calcular_Click(object sender, EventArgs e)
        {

        }

        private void F_Principal_Load(object sender, EventArgs e)
        {

        }

        private void exportarPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            CalculaTracao tracao = new CalculaTracao();
            CalculaCompressao compressao = new CalculaCompressao();
            CalculaFlexao flexao = new CalculaFlexao();
        }

        private void btn_propPerfil_Click(object sender, EventArgs e)
        {
            F_DadosAco f_DadosAco = new F_DadosAco(this);
            f_DadosAco.ShowDialog();
        }

        private void btn_esforcos_Click(object sender, EventArgs e)
        {
            F_Esforcos f_Esforcos = new F_Esforcos();
            f_Esforcos.ShowDialog();
        }
    }

}

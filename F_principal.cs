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
    public partial class F_principal : Form
    {
        public F_principal()
        {
            InitializeComponent();
        }

        //Variáveis gerais
        string tipoperfil = "i"; //Usado para checar o tipo de perfil a ser plotado na listbox
        //Variaveis gerais - tração
        int tipoCt = 1;

        //Propriedades gerais do aço
        double escoamento;
        double ruptura;
        double elasticidade;

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            txt_resultado.Text = "";
        }    

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
        private void rb_ct1_CheckedChanged(object sender, EventArgs e)
        {
            tipoCt = 1;
        }

        private void rb_ct2_CheckedChanged(object sender, EventArgs e)
        {
            tipoCt = 2;
            if (rb_ct2.Checked)
            {
                txt_lc.Enabled = true;
            }
            else
            {
                txt_lc.Enabled = false;
            }          
        }

        private void rb_ct3_CheckedChanged(object sender, EventArgs e)
        {
            tipoCt = 3;
            if (rb_ct3.Checked)
            {
                txt_ac.Enabled = true;
            }
            else
            {
                txt_ac.Enabled = false;
            }
        }

        
        private void rb_perfilSoldado_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        private void btn_calcularTracao_Click(object sender, EventArgs e)
        {
            string solicitacao = tabControl1.SelectedTab.Name;

            if (solicitacao == "tabTracao")
            {
                try
                {
                    escoamento = double.Parse(txt_escoamento.Text);
                    double Ftsd = double.Parse(txt_tracao.Text);
                    double punc = double.Parse(txt_puncionamento.Text);
                    double folga = double.Parse(txt_folgaFuro.Text);
                    double diam = double.Parse(cb_diamparafusos.Text);
                    ruptura = double.Parse(txt_ruptura.Text);
                    double Lt = double.Parse(txt_L.Text);
                    int numfuros = int.Parse(cb_numfuros.Text);
                    double lc = double.Parse(txt_lc.Text);
                    double ac = double.Parse(txt_ac.Text);
                    double l = double.Parse(txt_L.Text);
                    CalculaTracao calculaTracao = new CalculaTracao();
                    txt_resultado.Text = calculaTracao.Tracao(tipoperfil, escoamento, Ftsd, ruptura, tipoCt, lc, ac, punc, folga, diam, numfuros, l);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (solicitacao == "tabCompressao")
            {

            }
            if (solicitacao == "tabFlexao")
            {

            }
        }
        
    }

}

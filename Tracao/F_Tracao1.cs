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
    public partial class F_Tracao1 : Form
    {

        public F_Tracao1()
        {
            InitializeComponent();
        }

        //Variáveis gerais
        string tipoperfil = "i"; //Usado para checar o tipo de perfil a ser plotado na listbox
        //Variaveis gerais - tração
        int tipoCt = 1;
        double areaChapa = 0; //usado para passar o valor da area da chapa por parametro no calculo

        //Propriedades gerais do aço
        double escoamento;
        double ruptura;

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

            //Configura os radios de CT
            rb_ct1.Enabled = true;
            rb_ct2.Enabled = true;
            rb_ct3.Enabled = true;
            rb_ct4.Enabled = false;

            //Torna invisivel os parametros da chapa
            btn_chapaOK.Visible = false;
            lbl_dimensoes.Visible = false;
            lbl_xChapa.Visible = false;
            txt_xChapa.Visible = false;
            lbl_mm1.Visible = false;
            lbl_yChapa.Visible = false;
            txt_yChapa.Visible = false;
            lbl_mm2.Visible = false;
            lbl_eChapa.Visible = false;
            txt_eChapa.Visible = false;
            lbl_mm3.Visible = false;
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

            //Configura os radios de CT
            rb_ct1.Enabled = true;
            rb_ct2.Enabled = true;
            rb_ct3.Enabled = true;
            rb_ct4.Enabled = false;

            //Torna invisivel os parametros da chapa
            btn_chapaOK.Visible = false;
            lbl_dimensoes.Visible = false;
            lbl_xChapa.Visible = false;
            txt_xChapa.Visible = false;
            lbl_mm1.Visible = false;
            lbl_yChapa.Visible = false;
            txt_yChapa.Visible = false;
            lbl_mm2.Visible = false;
            lbl_eChapa.Visible = false;
            txt_eChapa.Visible = false;
            lbl_mm3.Visible = false;
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

            //Configura os radios de CT
            rb_ct1.Enabled = true;
            rb_ct2.Enabled = true;
            rb_ct3.Enabled = true;
            rb_ct4.Enabled = false;

            //Torna invisivel os parametros da chapa
            btn_chapaOK.Visible = false;
            lbl_dimensoes.Visible = false;
            lbl_xChapa.Visible = false;
            txt_xChapa.Visible = false;
            lbl_mm1.Visible = false;
            lbl_yChapa.Visible = false;
            txt_yChapa.Visible = false;
            lbl_mm2.Visible = false;
            lbl_eChapa.Visible = false;
            txt_eChapa.Visible = false;
            lbl_mm3.Visible = false;
        }
        private void rb_duploU_CheckedChanged(object sender, EventArgs e)
        {
            tipoperfil = "2u";
            //Configura os radios de CT
            rb_ct1.Enabled = true;
            rb_ct2.Enabled = true;
            rb_ct3.Enabled = true;
            rb_ct4.Enabled = false;

            //Torna invisivel os parametros da chapa
            btn_chapaOK.Visible = false;
            lbl_dimensoes.Visible = false;
            lbl_xChapa.Visible = false;
            txt_xChapa.Visible = false;
            lbl_mm1.Visible = false;
            lbl_yChapa.Visible = false;
            txt_yChapa.Visible = false;
            lbl_mm2.Visible = false;
            lbl_eChapa.Visible = false;
            txt_eChapa.Visible = false;
            lbl_mm3.Visible = false;
        }
        private void rb_duploL_CheckedChanged(object sender, EventArgs e)
        {
            tipoperfil = "2l";
            //Configura os radios de CT
            rb_ct1.Enabled = true;
            rb_ct2.Enabled = true;
            rb_ct3.Enabled = true;
            rb_ct4.Enabled = false;

            //Torna invisivel os parametros da chapa
            btn_chapaOK.Visible = false;
            lbl_dimensoes.Visible = false;
            lbl_xChapa.Visible = false;
            txt_xChapa.Visible = false;
            lbl_mm1.Visible = false;
            lbl_yChapa.Visible = false;
            txt_yChapa.Visible = false;
            lbl_mm2.Visible = false;
            lbl_eChapa.Visible = false;
            txt_eChapa.Visible = false;
            lbl_mm3.Visible = false;
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

            //Configura os radios de CT
            rb_ct1.Enabled = false;
            rb_ct2.Enabled = false;
            rb_ct3.Enabled = false;
            rb_ct4.Enabled = true;

            btn_chapaOK.Visible = true;
            lbl_dimensoes.Visible = true;
            lbl_xChapa.Visible = true;
            txt_xChapa.Visible = true;
            lbl_mm1.Visible = true;
            lbl_yChapa.Visible = true;
            txt_yChapa.Visible = true;
            lbl_mm2.Visible = true;
            lbl_eChapa.Visible = true;
            txt_eChapa.Visible = true;
            lbl_mm3.Visible = true;
        }
        private void rb_ct1_CheckedChanged(object sender, EventArgs e)
        {
            tipoCt = 1;
            txt_ac.Enabled = false;
            cb_numfuros.Enabled = true;
            cb_diamparafusos.Enabled = true;
            txt_puncionamento.Enabled = true;
            txt_folgaFuro.Enabled = true;
            txt_b.Enabled = false;
            txt_lw.Enabled = false;
            txt_lc.Enabled = false;
        }
        private void rb_ct2_CheckedChanged(object sender, EventArgs e)
        {
            tipoCt = 2;
            if (rb_ct2.Checked)
            {
                txt_ac.Enabled = true;
                cb_numfuros.Enabled = false;
                cb_diamparafusos.Enabled = false;
                txt_puncionamento.Enabled = false;
                txt_folgaFuro.Enabled = false;
                txt_b.Enabled = false;
                txt_lw.Enabled = false;
                txt_lc.Enabled = false;
            }
            else
            {
                txt_lc.Enabled = false;
            }          
        }
        private void rb_ct3_CheckedChanged(object sender, EventArgs e)
        {
            tipoCt = 3;
            txt_lc.Enabled = true;
            cb_diamparafusos.Enabled = true;
            cb_numfuros.Enabled=true;
            txt_folgaFuro.Enabled = true;
            txt_puncionamento.Enabled=true;
 
        }
        private void rb_ct4_CheckedChanged(object sender, EventArgs e)
        {
            tipoCt = 4;
        }
        private void btn_calcularTracao_Click(object sender, EventArgs e)
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
                    double b = double.Parse(txt_b.Text);
                    double lw = double.Parse(txt_lw.Text);
                    double ct = 1.0;
                    CalculaCt calculaCt = new CalculaCt();
                switch (tipoCt)
                {
                    case 1:
                        ct = calculaCt.Ct1();
                        break;
                    case 2:
                        ct = calculaCt.Ct2(ac, tipoperfil);
                        break;
                    case 3:
                        ct = calculaCt.Ct3(lc, tipoperfil);
                        break;
                    case 4:
                        if(b > lw)
                        {
                            MessageBox.Show(" O valor de b não pode ser maior do que lw.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            ct = calculaCt.Ct4(b, lw);        
                        }
                        break;
                }

                CalculaTracao calculaTracao = new CalculaTracao();
                txt_resultadoTracao.Text = calculaTracao.Tracao(ct, tipoperfil, escoamento, Ftsd, ruptura, punc, folga, diam, numfuros, l, this, areaChapa);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }
        private void pct_perfil_Click(object sender, EventArgs e)
        {

        }
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btn_chapaOK_Click(object sender, EventArgs e)
        {
            double x, y, esp;

            x = double.Parse(txt_xChapa.Text);
            y = double.Parse(txt_yChapa.Text);
            esp = double.Parse(txt_eChapa.Text);


            areaChapa = (y / 10.0) * (esp / 10.0);

            txt_prop.Text = "DADOS DA CHAPA: \r\n \r\n" +
                            $"Comprimento: {x:F2} mm\r\n" +
                            $"Altura: {y:F2} mm\r\n" +
                            $"Área seção transversal: {areaChapa:F2} cm2";
        }
    }

}

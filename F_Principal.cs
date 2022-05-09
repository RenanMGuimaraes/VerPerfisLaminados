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
        int id = 0; //Usado para identificar o perfil na lista


        //Esforços solicitantes
        public double ftsd = 0;
        public double fcsd = 0;
        public double fvxsd = 0;
        public double fvysd = 0;
        public double mxsd = 0;
        public double mysd = 0;

        //Resultados dos cálculos
        public string res_ntrd = "";
        public string res_ncrd = "";
        public string res_vxrd = "";
        public string res_vyrd = "";
        public string res_mxrd = "";
        public string res_myrd = "";

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

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            txt_lx.Text = "0";
            txt_ly.Text = "0";
            txt_lz.Text = "0";
            txt_ncsd.Text = "0";
            txt_ntsd.Text = "0";
            txt_vxsd.Text = "0";
            txt_vysd.Text = "0";
            txt_mxsd.Text = "0";
            txt_mysd.Text = "0";
            txt_ncrd.Text = "";
            txt_ntrd.Text = "";
            txt_vxrd.Text = "";
            txt_vyrd.Text = "";
            txt_mxrd.Text = "";
            txt_myrd.Text = "";
            txt_cb.Text = "1";
            lbl_perfil.Text = "PERFIL:";
            lb_sdrd_nc.Text = "Sd/Rd: ";
            lb_sdrd_nc.ForeColor = System.Drawing.Color.Black;
            lbl_ncrd_esb.Text = "Esbeltez: ";
            lbl_ncrd_esb.ForeColor = System.Drawing.Color.Black;
            lb_sdrd_nt.Text = "Sd/Rd:";
            lb_sdrd_nt.ForeColor = System.Drawing.Color.Black;
            lbl_ntrd_esb.Text = "Esbeltez: ";
            lbl_ntrd_esb.ForeColor = System.Drawing.Color.Black;
        }    

        //PLOTA OS PERFIS DO LB_LIST NO TXT_PROP
        private void lb_perfis_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = lb_perfis.SelectedIndex;
            if (tipoperfil == "i")
            {
                PropPerfilI propPerfilI = new PropPerfilI();
                propPerfilI.PropI(id);
                lbl_perfil.Text = "PERFIL: " + PropPerfilI.perfil;
            }
            if (tipoperfil == "l")
            {
                PropPerfilL propPerfilL = new PropPerfilL();
                propPerfilL.PropL(id);
                lbl_perfil.Text = "PERFIL: " + PropPerfilL.perfil;
            }
            if (tipoperfil == "u")
            {
                PropPerfilU propPerfilU = new PropPerfilU();
                propPerfilU.PropU(id);
                lbl_perfil.Text = "PERFIL: " + PropPerfilU.perfil;
            }
        }  

        private void rb_perfilI_CheckedChanged(object sender, EventArgs e)
        {
            tipoperfil = "i";
            /*
            //Carrega Imagem Perfil I
            Assembly imagemI = Assembly.GetExecutingAssembly();
            Stream streamPerfilI = imagemI.GetManifestResourceStream("VerPerfisLaminados.Imagens.Prop_i.png");
            pct_perfil.Image = new Bitmap(streamPerfilI);
            */


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
            /*
            //Carrega Imagem Perfil L
            Assembly imagemL = Assembly.GetExecutingAssembly();
            Stream streamPerfilL = imagemL.GetManifestResourceStream("VerPerfisLaminados.Imagens.Prop_L.png");
            pct_perfil.Image = new Bitmap(streamPerfilL);
            */

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
            /*
            //Carrega Imagem Perfil U
            Assembly imagemU = Assembly.GetExecutingAssembly();
            Stream streamPerfilU = imagemU.GetManifestResourceStream("VerPerfisLaminados.Imagens.Prop_U.png");
            pct_perfil.Image = new Bitmap(streamPerfilU);
            */

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
            /*
            //Carrega Imagem Perfil 2U
            Assembly imagemU = Assembly.GetExecutingAssembly();
            Stream streamPerfilU = imagemU.GetManifestResourceStream("VerPerfisLaminados.Imagens.Prop_2U.png");
            pct_perfil.Image = new Bitmap(streamPerfilU);
            */

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

        private void F_Principal_Load(object sender, EventArgs e)
        {

        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            if(txt_lx.Text == "0" || txt_ly.Text == "0" || txt_lz.Text == "0")
            {
                MessageBox.Show("Preencha a geometria da barra!","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                //Preenche o texto do perfil
                if (tipoperfil == "i")
                {
                    lbl_perfil.Text = $"PERFIL: {PropPerfilI.perfil}";
                }
                if (tipoperfil == "u")
                {
                    lbl_perfil.Text = $"PERFIL: {PropPerfilU.perfil}";
                }
                if (tipoperfil == "l")
                {
                    lbl_perfil.Text = $"PERFIL: {PropPerfilL.perfil}";
                }

                //Propriedades gerais 
                double lx = double.Parse(txt_lx.Text);
                double ly = double.Parse(txt_ly.Text);
                double lz = double.Parse(txt_lz.Text);
                double cb = double.Parse(txt_cb.Text);
               
                //Propriedades gerais do aço
                double fy = double.Parse(txt_fy.Text);
                double fu = double.Parse(txt_fu.Text);
                double elast = double.Parse(txt_e.Text);
                double g = double.Parse(txt_g.Text);

                //Esforços solicitantes
                double ncsd = double.Parse(txt_ncsd.Text);
                double ntsd = double.Parse(txt_ntsd.Text);
                double vxsd = double.Parse(txt_vxsd.Text);
                double vysd = double.Parse(txt_vysd.Text);
                double mxsd = double.Parse(txt_mxsd.Text);
                double mysd = double.Parse(txt_mysd.Text);

                //Calculo a compressao
                if (cb_ncrd.Checked == true)
                {
                    if (tipoperfil == "i")
                    {
                        CompressaoI compressao = new CompressaoI();
                        res_ncrd = compressao.CalculaCompressao(this, fy,  ncsd, lx, ly, lz, elast, g);
                    }
                    if (tipoperfil == "u")
                    {
                        CompressaoU compressao = new CompressaoU();
                        res_ncrd = compressao.CalculaCompressao(this, fy, ncsd, lx, ly, lz, elast, g);
                    }
                    if (tipoperfil == "l")
                    {

                    }
                    
                }
                
                if (cb_mxrd.Checked == true)
                {
                    //Calculo a flexao em X
                    if (tipoperfil == "i")
                    {                      
                        FlexaoI flexao = new FlexaoI();
                        res_mxrd = flexao.FlexaoX(this,  mxsd,  elast,  cb,  lx,  ly, lz, fy);   
                    }
                    if (tipoperfil == "u")
                    {
                        //CalculaFlexaoI flexao = new CalculaFlexaoU(this, fy, mxsd, mysd, elast);
                    }
                }

                if (cb_myrd.Checked == true)
                {
                    //Calculo a flexao em Y
                    if (tipoperfil == "i")
                    {                      
                        FlexaoI flexao = new FlexaoI();
                        res_myrd = flexao.FlexaoY(this, mysd, elast, cb, lx, ly, lz, fy);
                    }
                    if (tipoperfil == "u")
                    {
                        // CalculaFlexaoI flexao = new CalculaFlexaoU(this, fy, mxsd, mysd, elast);
                    }
                }

                if (cb_ntrd.Checked == true)
                {
                    //Calculo a tracao
                    TracaoI tracao = new TracaoI();
                    res_ntrd = tracao.CalculaTracao(this, fy, fu, ntsd, lx, ly, lz);
                }

                if (cb_vxrd.Checked == true)
                {
                    //Calculo a cortante no eixo de maior inércia (X)
                    CortanteI cortante = new CortanteI();
                   res_vxrd = cortante.CalculaCortanteX(this, fy, vxsd, elast);

                }

                if (cb_vyrd.Checked == true)
                {
                    //Calculo a cortante no eixo de maior inércia (Y)              
                    CortanteI cortante = new CortanteI();
                    res_vyrd = cortante.CalculaCortanteY(this, fy, vxsd, elast);
                }

               

            }
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

        private void btn_prop_Click(object sender, EventArgs e)
        {
            F_Prop f_prop = new F_Prop(id, tipoperfil);
            f_prop.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void cb_ncrd_CheckedChanged(object sender, EventArgs e)
        {
            txt_ncrd.Text = "";
            lb_sdrd_nc.Text = "Sd/Rd:";
            lb_sdrd_nc.ForeColor = Color.Black;
            lbl_ncrd_esb.Text = "Esbeltez:";
            lbl_ncrd_esb.ForeColor = Color.Black;

            if (cb_ncrd.Checked == true)
            {
                txt_ncrd.Enabled = true;
                lbl_ncrd.Enabled = true;
            }
            else
            {
                txt_ncrd.Enabled = false;
                lbl_ncrd.Enabled = false;
            }
            
        }

        private void cb_ntrd_CheckedChanged(object sender, EventArgs e)
        {
            txt_ntrd.Text = "";
            lb_sdrd_nt.Text = "Sd/Rd:";
            lb_sdrd_nt.ForeColor = Color.Black;
            lbl_ntrd_esb.Text = "Esbeltez:";
            lbl_ntrd_esb.ForeColor = Color.Black;

            if (cb_ntrd.Checked == true)
            {
                txt_ntrd.Enabled = true;
                lbl_ntrd.Enabled = true;
            }
            else
            {
                txt_ntrd.Enabled = false;
                lbl_ntrd.Enabled = false;
            }
        }

        private void cb_vxrd_CheckedChanged(object sender, EventArgs e)
        {
            txt_vxrd.Text = "";
            lb_sdrd_vx.Text = "Sd/Rd:";
            lb_sdrd_vx.ForeColor = Color.Black;

            if (cb_vxrd.Checked == true)
            {
                txt_vxrd.Enabled = true;
                lbl_vxrd.Enabled = true;
            }
            else
            {
                txt_vxrd.Enabled = false;
                lbl_vxrd.Enabled = false;
            }
        }

        private void cb_vyrd_CheckedChanged(object sender, EventArgs e)
        {
            txt_vyrd.Text = "";
            lb_sdrd_vy.Text = "Sd/Rd:";
            lb_sdrd_vy.ForeColor = Color.Black;

            if (cb_vyrd.Checked == true)
            {
                txt_vyrd.Enabled = true;
                lbl_vyrd.Enabled = true;
            }
            else
            {
                txt_vyrd.Enabled = false;
                lbl_vyrd.Enabled = false;
            }
        }

        private void cb_mxrd_CheckedChanged(object sender, EventArgs e)
        {
            txt_mxrd.Text = "";
            lb_sdrd_mx.Text = "Sd/Rd:";
            lb_sdrd_mx.ForeColor = Color.Black;

            if (cb_mxrd.Checked == true)
            {
                txt_mxrd.Enabled = true;
                lbl_mxrd.Enabled = true;
            }
            else
            {
                txt_mxrd.Enabled = false;
                lbl_mxrd.Enabled = false;
            }
        }

        private void cb_myrd_CheckedChanged(object sender, EventArgs e)
        {
            txt_myrd.Text = "";
            lb_sdrd_my.Text = "Sd/Rd:";
            lb_sdrd_my.ForeColor = Color.Black;

            if (cb_myrd.Checked == true)
            {
                txt_myrd.Enabled = true;
                lbl_myrd.Enabled = true;
            }
            else
            {
                txt_myrd.Enabled = false;
                lbl_myrd.Enabled = false;
            }

        }

        private void btn_pdf_Click(object sender, EventArgs e)
        {
            F_ResComp resultados = new F_ResComp(tipoperfil, res_ncrd);
            resultados.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
                F_Sobre f_Sobre = new F_Sobre();
                f_Sobre.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_mem_tra_Click(object sender, EventArgs e)
        {
            F_ResComp resultados = new F_ResComp(tipoperfil, res_ntrd);
            resultados.ShowDialog();
        }

        private void btn_mem_vx_Click(object sender, EventArgs e)
        {
            F_ResComp resultados = new F_ResComp(tipoperfil, res_vxrd);
            resultados.ShowDialog();
        }

        private void btn_mem_vy_Click(object sender, EventArgs e)
        {
            F_ResComp resultados = new F_ResComp(tipoperfil, res_vyrd);
            resultados.ShowDialog();
        }

        private void btn_mem_mx_Click(object sender, EventArgs e)
        {
            F_ResComp resultados = new F_ResComp(tipoperfil, res_mxrd);
            resultados.ShowDialog();
        }

        private void btn_mem_my_Click(object sender, EventArgs e)
        {
            F_ResComp resultados = new F_ResComp(tipoperfil, res_myrd);
            resultados.ShowDialog();
        }
    }

}

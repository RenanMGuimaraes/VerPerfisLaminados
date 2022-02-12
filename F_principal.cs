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

namespace VerPerfisLaminados
{
    public partial class F_principal : Form
    {
        public F_principal()
        {
            InitializeComponent();
        }

        //Propriedades gerais do perfil
        string perfil;
        string tipoperfil = "i"; //Usado para checar o tipo de perfil a ser plotado na listbox
        double t, area, Ix, Wx, rx, Zx, Iy, Wy, Zy, ry, rz, x, h, d, tw, tf, bf,rt, It, Cw, dlinha, peso;

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            txt_resultado.Text = "";
        }


        //Propriedades gerais do aço
        double escoamento;
        double ruptura;
        double elasticidade;


        //Variaveis gerais - tração
        int tipoCt = 1;        


        private void lb_perfis_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = lb_perfis.SelectedIndex;
            if (tipoperfil == "i")
            {
                EscrevePerfilI(id);
            }
            if (tipoperfil == "l")
            {
                EscrevePerfilL(id);
            }
            if (tipoperfil == "u")
            {
                EscrevePerfilU(id);
            }
        }  
        
        public void EscrevePerfilI(int id)
        {
            //obter caminho do arquivo automaticamente
            //TODO
            string filename = @"C:\Users\renan\Documents\GitHub\VerPerfisLaminados\perfisI.txt";

            for (int i = id; i < id + 1; i++)
            {
                string line = File.ReadLines(filename).Skip(id).Take(1).First();
                string[] subs = line.Split(' ');
                string perfilI = $" {subs[0]}";
                perfil = perfilI;
                string pesoI = $"{subs[1]}";
                peso = double.Parse(pesoI);
                string dI = $"{subs[2]}";
                d = double.Parse(dI);
                string bfI = $"{subs[3]}";
                bf = double.Parse(bfI);
                string twI = $"{subs[4]}";
                tw = double.Parse(twI);
                string tfI = $"{subs[5]}";
                tf = double.Parse(tfI);
                string hI = $"{subs[6]}";
                h = double.Parse(hI);
                string dlinhaI = $"{subs[7]}";
                dlinha = double.Parse(dlinhaI);
                string areaI = $"{subs[8]}";
                area = double.Parse(areaI);
                string IxI = $"{subs[9]}";
                Ix = double.Parse(IxI);
                string WxI = $"{subs[10]}";
                Wx = double.Parse(WxI);
                string rxI = $"{subs[11]}";
                rx = double.Parse(rxI);
                string zxI = $"{subs[12]}";
                Zx = double.Parse(zxI);
                string IyI = $"{subs[13]}";
                Iy = double.Parse(IyI);
                string wyI = $"{subs[14]}";
                Wy = double.Parse(wyI);
                string ryI = $"{subs[15]}";
                ry = double.Parse(ryI);
                string zyI = $"{subs[16]}";
                Zy = double.Parse(zyI);
                string rtI = $"{subs[17]}";
                rt = double.Parse(rtI);
                string ItI = $"{subs[18]}";
                It = double.Parse(ItI);
                string cwI = $"{subs[19]}";
                Cw = double.Parse(cwI);

                //Escreve as propriedades do perfil I no TxT
                txt_prop.Text = $"Perfil: {perfilI} \r\n \r\n" +
                           $"Peso: {pesoI} kg/m \r\n" +
                           $"d: {dI}  mm \r\n" +
                           $"bf: {bfI} mm \r\n" +
                           $"tw: {twI} mm \r\n" +
                           $"tf: {tfI} mm \r\n" +
                           $"h: {hI} mm \r\n" +
                           $"d': {dlinhaI} mm \r\n" +
                           $"Área: {areaI} cm2 \r\n \r\n" +
                           "EIXO X-X \r\n" +
                           $"Ix: {IxI} cm4 \r\n" +
                           $"Wx: {WxI} cm3 \r\n" +
                           $"rx: {rxI} cm \r\n" +
                           $"Zx: {zxI} cm3 \r\n \r\n" +
                           "EIXO Y-Y \r\n" +
                           $"Iy: {IyI} cm4 \r\n" +
                           $"Wy: {wyI} cm3 \r\n" +
                           $"ry: {ryI} cm \r\n" +
                           $"Zy: {zyI} cm3 \r\n \r\n" +
                           "TORÇÃO \r\n" +
                           $"rt: {rtI} cm \r\n" +
                           $"It: {ItI} cm4 \r\n" +
                           $"Cw: {cwI} cm6 \r\n";

            }

        }

        public void EscrevePerfilL(int id)
        {
            //obter caminho do arquivo automaticamente
            //TODO
            string filename = @"C:\Users\renan\Documents\GitHub\VerPerfisLaminados\cantoneiras.txt";

            for (int i = id; i < id + 1; i++)
            {
                string line = File.ReadLines(filename).Skip(id).Take(1).First();
                string[] subs = line.Split(' ');
                string perfilL = $" {subs[0]}";
                perfil = perfilL;
                string pesoL = $"{subs[1]}";
                peso = double.Parse(pesoL);
                string tL = $"{subs[2]}";
                t = double.Parse(tL);
                string areaL = $"{subs[3]}";
                area = double.Parse(areaL);
                string ixL = $"{subs[4]}";
                Ix = double.Parse(ixL);
                string wxL = $"{subs[5]}";
                Wx = double.Parse(wxL);
                string rxL = $"{subs[6]}";
                rx = double.Parse(rxL);
                string rzL = $"{subs[7]}";
                rz = double.Parse(rzL);
                string xL = $"{subs[8]}";
                x = double.Parse(xL);

                //Escreve as propriedades do perfil L no TxT
                txt_prop.Text = $"Perfil: {perfilL} \r\n \r\n" +
                           $"Peso: {pesoL} kg/m \r\n" +
                           $"t: {tL}  mm \r\n" +
                           $"Área: {areaL} cm2 \r\n" +
                           $"Ix=Iy: {ixL} cm4 \r\n" +
                           $"Wx=Wy: {wxL} cm3 \r\n" +
                           $"rx=ry: {rxL} cm \r\n" +
                           $"rz min': {rzL} cm \r\n" +
                           $"x: {xL} cm \r\n \r\n";
            }

        }
        public void EscrevePerfilU(int id)
        {
            //obter caminho do arquivo automaticamente
            //TODO
            string filename = @"C:\Users\renan\Documents\GitHub\VerPerfisLaminados\perfisU.txt";

            for (int i = id; i < id + 1; i++)
            {
                string line = File.ReadLines(filename).Skip(id).Take(1).First();
                string[] subs = line.Split(' ');
                string perfilU = $" {subs[0]}";
                perfil = perfilU;
                string pesoU = $"{subs[1]}";
                peso = double.Parse(pesoU);
                string dU = $"{subs[2]}";
                d = double.Parse(dU);
                string twU = $"{subs[3]}";
                tw = double.Parse(twU);
                string bfU = $"{subs[4]}";
                bf = double.Parse(bfU);
                string tfU = $"{subs[5]}";
                tf = double.Parse(tfU);
                string areaU = $"{subs[6]}";
                area = double.Parse(areaU);
                string IxU = $"{subs[7]}";
                Ix = double.Parse(IxU);
                string WxU = $"{subs[8]}";
                Wx = double.Parse(WxU); 
                string rxU = $"{subs[9]}";
                rx = double.Parse(rxU);
                string IyU = $"{subs[10]}";
                Iy = double.Parse(IyU);
                string WyU = $"{subs[11]}";
                Wy = double.Parse(WyU);
                string ryU = $"{subs[12]}";
                ry = double.Parse(ryU);
                string xU = $"{subs[13]}";
                x = double.Parse(xU);


                //Escreve as propriedades do perfil U no TxT
                txt_prop.Text = $"Perfil: {perfilU} \r\n \r\n" +
                           $"Peso: {pesoU} kg/m \r\n" +
                           $"d: {dU}  mm \r\n" +
                           $"tw: {twU} mm \r\n" +
                           $"bf: {bfU} mm \r\n" +
                           $"tf: {tfU} mm \r\n" +
                           $"Área: {areaU} cm2 \r\n \r\n" +
                           "EIXO X-X \r\n" +
                           $"Ix: {IxU} cm4 \r\n" +
                           $"Wx: {WxU} cm3 \r\n" +
                           $"rx: {rxU} cm \r\n \r\n " +
                           "EIXO Y-Y \r\n" +
                           $"Iy: {IyU} cm4 \r\n" +
                           $"Wy: {WyU} cm3 \r\n" +
                           $"ry: {ryU} cm \r\n \r\n" +
                           $"x: {xU} cm \r\n";
            }

        }

        private void rb_perfilI_CheckedChanged(object sender, EventArgs e)
        {
            tipoperfil = "i";
            pct_perfil.Image = Image.FromFile(@"C:\Users\renan\Documents\GitHub\VerPerfisLaminados\Imagens\Prop_i.png");
            List<string> perfisI = new List<string>();
            string filename = @"C:\Users\renan\Documents\GitHub\VerPerfisLaminados\lista_perfisI.txt";

            string[] nomePerfisI = File.ReadAllLines(filename);
            List<string> ListaPerfisI = new List<string>(nomePerfisI);
            lb_perfis.DataSource = ListaPerfisI;
        }

        private void rb_cantoneira_CheckedChanged(object sender, EventArgs e)
        {
            tipoperfil = "l";
            pct_perfil.Image = Image.FromFile(@"C:\Users\renan\Documents\GitHub\VerPerfisLaminados\Imagens\Prop_L.png");
            List<string> perfisCantoneira = new List<string>();
            string filename = @"C:\Users\renan\Documents\GitHub\VerPerfisLaminados\lista_cantoneiras.txt";

            string[] nomeCantoneiras = File.ReadAllLines(filename);
            List<string> ListaCantoneiras = new List<string>(nomeCantoneiras);
            lb_perfis.DataSource = ListaCantoneiras;
        }

        private void rb_perfilU_CheckedChanged(object sender, EventArgs e)
        {
            tipoperfil = "u";
            pct_perfil.Image = Image.FromFile(@"C:\Users\renan\Documents\GitHub\VerPerfisLaminados\Imagens\Prop_U.png");
            List<string> perfisU = new List<string>();
            string filename = @"C:\Users\renan\Documents\GitHub\VerPerfisLaminados\lista_perfisU.txt";

            string[] nomePerfisU = File.ReadAllLines(filename);
            List<string> ListaPerfisU = new List<string>(nomePerfisU);
            lb_perfis.DataSource = ListaPerfisU;

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
                    double ruptura = double.Parse(txt_ruptura.Text);
                    double Lt = double.Parse(txt_comprimento.Text);
                    int numfuros = int.Parse(cb_numfuros.Text);
                    double lc = double.Parse(txt_lc.Text);
                    double ac = double.Parse(txt_ac.Text);
                    CalculaTracao calculaTracao = new CalculaTracao();
                    txt_resultado.Text = calculaTracao.Tracao(area, bf, tf, d, lc, ac, escoamento, Ftsd, punc, folga, diam, x, ruptura, t, tw, Lt, rx, ry,rz, tipoCt, numfuros, tipoperfil);

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

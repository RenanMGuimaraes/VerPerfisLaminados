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

        //Propriedades Atuais do perfil
        string perfil;
        string tipoperfil = "i"; //Usado para checar o tipo de perfil a ser plotado na listbox
        double t, area, Ix, Wx, rx, Zx, Iy, Wy, Zy, ry, rz, x, h, d, tw, tf, bf,rt, It, Cw, dlinha, peso;
        double ct = 1.0;
        double lc = 1.0;

 
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            ruptura = double.Parse(txt_ruptura.Text);
        }

        //Propriedades do aço
        double escoamento = 34.5;
        double elasticidade = 20.000;

        private void txt_lc_TextChanged(object sender, EventArgs e)
        {
            if (txt_lc.Text == "")
            {
                
            }
            else
            {
                CalculoEc();
            }
            
        }

        private void txt_ag_TextChanged(object sender, EventArgs e)
        {

        }

        double ruptura = 45.0;

       
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

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

        private void tabComb_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            escoamento = double.Parse(txt_escoamento.Text) / 10.0;
        }

        private void txt_elasticidade_TextChanged(object sender, EventArgs e)
        {
            elasticidade = double.Parse(txt_elasticidade.Text) / 10.0;
        }

        
       

        
        private void btn_selecionar_Click(object sender, EventArgs e)
        {
            int id = lb_perfis.SelectedIndex;
            if (tipoperfil == "i")
            {
                EscrevePerfilI(id);
            }
            if(tipoperfil == "l")
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
            ct = 1.0;
        }

        private void rb_ct2_CheckedChanged(object sender, EventArgs e)
        {
            CalculoEc();
        }

        private void rb_ct3_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_ct3.Checked)
            {
                txt_ag.Enabled = true;
            }
            else
            {
                txt_ag.Enabled = false;
            }
        }

        private void rb_ct1_Click(object sender, EventArgs e)
        {
            
        }

        private void rb_ct2_Click(object sender, EventArgs e)
        {
            
        }

        
        private void rb_perfilSoldado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_calcularTracao_Click(object sender, EventArgs e)
        {
            string solicitacao = tabControl1.SelectedTab.Name;

            if (solicitacao == "tabTracao")
            {
                Tracao();
            }               

            
        }

        public void CalculoEc()
        {
            lc = double.Parse(txt_lc.Text);
            if (rb_ct2.Checked)
            {
                txt_lc.Enabled = true;
            }
            else
            {
                txt_lc.Enabled = false;
            }
            switch (tipoperfil)
            {
                case "i":
                    Ct_I();
                    break;
                case "l":
                    Ct_L();
                    break;
                case "u":
                    Ct_U();
                    break;
            }

            void Ct_L()
            {
                ct = 1 - x / lc;
                if (ct > 0.9)
                {
                    ct = 0.9;
                }
            }

            void Ct_U()
            {
                ct = 1 - x / lc;
                if (ct > 0.9)
                {
                    ct = 0.9;
                }
            }
            void Ct_I()
            {
                //calculo do ec
                double amesa = ((bf / 2.0) - (tw / 2.0)) * tf * 2; //area das duas abas
                double aalma = d * (tw / 2.0); //area da alma
                double ymesa = bf / 2.0; //Y da mesa
                double yalma = tw / 4.0; //Y da alma
                double cg = ((amesa * ymesa * 2.0) + (aalma * yalma)) / (amesa * 2.0 + aalma); //calculo do cg em mm
                double ec = (cg - (tw / 2.0)) / 10;

                ct = 1 - ec / lc;
                //MessageBox.Show($"Ct: {ct.ToString("F2")}", $"ec: {ec.ToString("F2")}");
                if (ct > 0.9)
                {
                    ct = 0.9;
                }
            }
        }
        public void Tracao()
        {
            //Calcula a tração na seção bruta
            double Ftrd1 = (area * escoamento) / 1.10;
            double Ftsd = double.Parse(txt_tracao.Text);
            string ver1;

            if (Ftrd1 >= Ftsd)
            {
                ver1 = "PASSOU!";
            }
            else
            {
                ver1 = "NÃO PASSOU!";
            }


            //Calcula a tração na seção líquida
            double punc = double.Parse(txt_puncionamento.Text) / 10.0;
            double folga = double.Parse(txt_folgaFuro.Text) / 10.0;
            double diam = double.Parse(cb_diamparafusos.Text) / 10.0;
            int numfuros = int.Parse(cb_numfuros.Text);
            string verCt;
            double diamfuro = diam + folga + punc;
            double An = area - numfuros * diamfuro * t;
            double Ae = ct * An;
            double Ftrd2 = (Ae * ruptura) / 1.35;
            string ver2;
            string verfinal;

            //Calcula o valor de "t" considerando a ligação pela alma
            if (tipoperfil =="i" || tipoperfil =="u")
            {
                t = tw / 10.0;
            }
            if(tipoperfil == "l")
            {
                t = t / 10.0;
            }

            if (ct < 0.6)
            {
                verCt = "ATENÇÃO: Ct menor do que 0.6! REVER!!";
            }
            else
            {
                verCt = "OK";
            }

            if (Ftrd2 >= Ftsd)
            {
                ver2 = "PASSOU!";
            }
            else
            {
                ver2 = "NÃO PASSOU!";
            }

            if (ver1 == "PASSOU!" && ver2 == "PASSOU!")
            {
                verfinal = "PASSOU!";
            }
            else
            {
                verfinal = "NÃO PASSOU!";
            }
            //Calcula a taxa de aproveitamento do perfil
            double Ftrd = Math.Min(Ftrd1, Ftrd2);
            double taxa = (Ftsd / Ftrd) * 100.0;

            txt_resultado.Text = $"RESULTADO: {verfinal}\r\n \r\n" +
                            $"1 - ESCOAMENTO DA SEÇÃO BRUTA:{ver1} \r\n" +
                            $"Força resistente: Ft,rd = ({area.ToString("F2")} x {escoamento.ToString("F2")}) / 1,10 = {Ftrd1.ToString("F2")} \r\n" +
                            $"Força solicitante: {Ftsd.ToString("F2")} \r\n \r\n" +
                            $"2 - RUPTURA DA SEÇÃO EFETIVA: {ver2}\r\n"+
                            $"Diâmetro do furo: {diamfuro.ToString("F2")} cm \r\n" +
                            $"Ct: {ct.ToString("F2")} - {verCt} \r\n"+
                            $"Área líquida: An = Area x n°furos x Df x t ={area.ToString("F2")} - {numfuros.ToString("F2")} x {diamfuro.ToString("F2")} x {t.ToString("F2")} = {An.ToString("F2")} \r\n" +
                            $"Área líquida efetiva: Ae = {ct.ToString("F2")} x {An.ToString("F2")} \r\n \r\n" +
                            $"Força resistente: Ftrd = {Ae.ToString("F2")} x {ruptura.ToString("F2")} / 1.35  = {Ftrd2.ToString("F2")} \r\n" +
                            $"Força solicitante: {Ftsd.ToString("F2")} \r\n \r\n" +
                            $"A taxa de aproveitamento do perfil é de {taxa.ToString("F2")} %";

        }
    }

}

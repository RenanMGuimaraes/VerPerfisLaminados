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
    public partial class F_perfilLaminado : Form
    {
        public F_perfilLaminado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = lb_perfis.SelectedIndex;
            EscreveProp(id);
        }

        public void EscreveProp(int id)
        {
            //obter caminho do arquivo automaticamente
            //TODO
            string filename = @"C:\Users\renan\Documents\GitHub\DimPerfilLaminado\DimPerfilLaminado\perfis3.txt";

            for (int i = id; i < id+1; i++)
            {
                    string line = File.ReadLines(filename).Skip(id).Take(1).First();
                    string[] subs = line.Split(' ');
                    string perfil = $" {subs[0]}";
                    string peso = $"{subs[1]}";
                    string d = $"{subs[2]}";
                    string bf = $"{subs[3]}";
                    string tw = $"{subs[4]}";
                    string tf = $"{subs[5]}";
                    string h = $"{subs[6]}";
                    string dlinha = $"{subs[7]}";
                    string area = $"{subs[8]}";
                    string Ix = $"{subs[9]}";
                    string Wx = $"{subs[10]}";
                    string rx = $"{subs[11]}";
                    string zx = $"{subs[12]}";
                    string Iy = $"{subs[13]}";
                    string wy = $"{subs[14]}";
                    string ry = $"{subs[15]}";
                    string zy = $"{subs[16]}";
                    string rt = $"{subs[17]}";
                    string It = $"{subs[18]}";
                    string cw = $"{subs[19]}";
                    PlotaTextoPerfil(perfil, peso, d, bf, tw, tf, h, dlinha, area, Ix, Wx, rx, zx, Iy, wy, ry, zy, rt, It, cw);
            }

        }

        public void PlotaTextoPerfil(string perfil, string peso, string d, string bf, string tw, string tf, string h, string dlinha,
            string area, string Ix, string Wx, string rx, string zx, string Iy, string wy, string ry, string zy, string rt, string It, string cw)
        {

           

            txt_prop.Text = $"Perfil: {perfil} \r\n \r\n" +
                            $"Peso: {peso} kg/m \r\n" +
                            $"d: {d}  mm \r\n" +
                            $"bf: {bf} mm \r\n" +
                            $"tw: {tw} mm \r\n"+
                            $"tf: {tf} mm \r\n"+
                            $"h: {h} mm \r\n" +
                            $"d': {dlinha} mm \r\n" +
                            $"Área: {area} cm2 \r\n \r\n" +
                            "EIXO X-X \r\n" +
                            $"Ix: {Ix} cm4 \r\n" +
                            $"Wx: {Wx} cm3 \r\n" +
                            $"rx: {rx} cm \r\n" +
                            $"Zx: {zx} cm3 \r\n \r\n" +
                            "EIXO Y-Y \r\n" +
                            $"Iy: {Iy} cm4 \r\n" +
                            $"Wy: {wy} cm3 \r\n" +
                            $"ry: {ry} cm \r\n" +
                            $"Zy: {zy} cm3 \r\n \r\n" +
                            "TORÇÃO \r\n" +
                            $"rt: {rt} cm \r\n" +
                            $"It: {It} cm4 \r\n" +
                            $"Cw: {cw} cm6 \r\n";
        }
    }
}

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
    internal class PropPerfilI
    {
        public static double area, Ix, Wx, rx, Zx, Iy, Wy, Zy, ry, h, d, tw, tf, bf, rt, It, Cw, dlinha, peso;
        public string PlotarI(int id)
        {
            string perfil;

            Assembly ListaPerfil = Assembly.GetExecutingAssembly();
            StreamReader readerPerfil = new StreamReader(ListaPerfil.GetManifestResourceStream("VerPerfisLaminados.Txt.perfisI.txt"));
            string perfis = readerPerfil.ReadToEnd(); //lê todo o arquivo
            string[] linhas = perfis.Split('\u000A'); //Quebra o arquivo lido em linhas
            string[] subs = linhas[id].Split(' '); //Quebra as linhas em propriedades
            
                perfil = $"{subs[0]}";
                peso = double.Parse($"{subs[1]}");
                d = double.Parse($"{subs[2]}");
                bf = double.Parse($"{subs[3]}");
                tw = double.Parse($"{subs[4]}");
                tf = double.Parse($"{subs[5]}");
                h = double.Parse($"{subs[6]}");
                dlinha = double.Parse($"{subs[7]}");
                area = double.Parse($"{subs[8]}");
                Ix = double.Parse($"{subs[9]}");
                Wx = double.Parse($"{subs[10]}");
                rx = double.Parse($"{subs[11]}");
                Zx = double.Parse($"{subs[12]}");
                Iy = double.Parse($"{subs[13]}");
                Wy = double.Parse($"{subs[14]}");
                ry = double.Parse($"{subs[15]}");
                Zy = double.Parse($"{subs[16]}");
                rt = double.Parse($"{subs[17]}");
                It = double.Parse($"{subs[18]}");
                Cw = double.Parse($"{subs[19]}");

                return  $"Perfil: {perfil} \r\n \r\n" +
                           $"Peso: {peso} kg/m \r\n" +
                           $"d: {d}  mm \r\n" +
                           $"bf: {bf} mm \r\n" +
                           $"tw: {tw} mm \r\n" +
                           $"tf: {tf} mm \r\n" +
                           $"h: {h} mm \r\n" +
                           $"d': {dlinha} mm \r\n" +
                           $"Área: {area} cm2 \r\n \r\n" +
                           "EIXO X-X \r\n" +
                           $"Ix: {Ix} cm4 \r\n" +
                           $"Wx: {Wx} cm3 \r\n" +
                           $"rx: {rx} cm \r\n" +
                           $"Zx: {Zx} cm3 \r\n \r\n" +
                           "EIXO Y-Y \r\n" +
                           $"Iy: {Iy} cm4 \r\n" +
                           $"Wy: {Wy} cm3 \r\n" +
                           $"ry: {ry} cm \r\n" +
                           $"Zy: {Zy} cm3 \r\n \r\n" +
                           "TORÇÃO \r\n" +
                           $"rt: {rt} cm \r\n" +
                           $"It: {It} cm4 \r\n" +
                           $"Cw: {Cw} cm6 \r\n"; 

            
        }
    }
}

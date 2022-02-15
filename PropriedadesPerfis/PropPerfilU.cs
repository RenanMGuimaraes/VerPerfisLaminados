using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace VerPerfisLaminados
{
    internal class PropPerfilU
    {
        public static double area, Ix, Wx, rx, Iy, Wy, ry, x, d, tw, tf, bf, peso;
        public string PlotarU(int id)
        {
            string perfil;

            Assembly ListaPerfil = Assembly.GetExecutingAssembly();
            StreamReader readerPerfil = new StreamReader(ListaPerfil.GetManifestResourceStream("VerPerfisLaminados.Txt.perfisU.txt"));
            string perfis = readerPerfil.ReadToEnd(); //lê todo o arquivo
            string[] linhas = perfis.Split('\u000A'); //Quebra o arquivo lido em linhas
            string[] subs = linhas[id].Split(' '); //Quebra as linhas em propriedades

            perfil = $" {subs[0]}";
            peso = double.Parse($"{subs[1]}");
            d = double.Parse($"{subs[2]}");
            tw = double.Parse($"{subs[3]}");
            bf = double.Parse($"{subs[4]}");
            tf = double.Parse($"{subs[5]}");
            area = double.Parse($"{subs[6]}");
            Ix = double.Parse($"{subs[7]}");
            Wx = double.Parse($"{subs[8]}");
            rx = double.Parse($"{subs[9]}");
            Iy = double.Parse($"{subs[10]}");
            Wy = double.Parse($"{subs[11]}");
            ry = double.Parse($"{subs[12]}");
            x = double.Parse($"{subs[13]}");

                return $"Perfil: {perfil} \r\n \r\n" +
                           $"Peso: {peso} kg/m \r\n" +
                           $"d: {d}  mm \r\n" +
                           $"tw: {tw} mm \r\n" +
                           $"bf: {bf} mm \r\n" +
                           $"tf: {tf} mm \r\n" +
                           $"Área: {area} cm2 \r\n \r\n" +
                           "EIXO X-X \r\n" +
                           $"Ix: {Ix} cm4 \r\n" +
                           $"Wx: {Wx} cm3 \r\n" +
                           $"rx: {rx} cm \r\n \r\n " +
                           "EIXO Y-Y \r\n" +
                           $"Iy: {Iy} cm4 \r\n" +
                           $"Wy: {Wy} cm3 \r\n" +
                           $"ry: {ry} cm \r\n \r\n" +
                           $"x: {x} cm \r\n";
            
        }
    }
}

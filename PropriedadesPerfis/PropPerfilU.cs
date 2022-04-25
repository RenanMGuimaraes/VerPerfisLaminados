using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace VerPerfisLaminados
{
    //Aqui será realizada a verificação do tipo de perfil, a determinação das suas propriedades geométrica e essas propriedades serão
    //armazenadas neste arquivo (via variáveis estáticas) para consulta, ou seja, as propriedades do perfil devem ser obtidas sempre 
    //deste arquivo.
    internal class PropPerfilU
    {
        public static double area, Ix, Wx, rx, Iy, Wy, ry, x, d, tw, tf, bf, peso, It, Cw;
        public static string perfil;

        public void PropU(int id)
        {
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

        }

        public string PlotarU(int id)
        {          
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

            //Calcula It
            It = (1.0 / 3.0) * ((d /10.0) - 2 * (bf /10.0)*(tw/10.0))*(2* (bf/10.0)*(tf/10.0));

            //Calcula Cw
            Cw = ((tf*Math.Pow((bf - 0.5*tw), 3.0)*Math.Pow((d - tf),2.0) / 12.0))*((3*(bf-0.5*tw)*tf + 2*(d - tf)*tw)/(6*(bf -0.5*tw)*tf + (d - tf)*tw));

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
                       $"x: {x} cm \r\n" +
                       $"It: {It:F2} cm4 ";
                          // $"Cw: {Cw} cm6";
            
        }
    }
}

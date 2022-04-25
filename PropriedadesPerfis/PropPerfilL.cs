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
    internal class PropPerfilL
    {
        public static double t, area, Ix, Wx, rx, rz, x, peso, b;
        public static string perfil;

        public void PropL(int id)
        {
            Assembly ListaPerfil = Assembly.GetExecutingAssembly();
            StreamReader readerPerfil = new StreamReader(ListaPerfil.GetManifestResourceStream("VerPerfisLaminados.Txt.perfisL.txt"));
            string perfis = readerPerfil.ReadToEnd(); //lê todo o arquivo
            string[] linhas = perfis.Split('\u000A'); //Quebra o arquivo lido em linhas
            string[] subs = linhas[id].Split(' '); //Quebra as linhas em propriedades

            perfil = $"{subs[0]}";
            peso = double.Parse($"{subs[1]}");
            t = double.Parse($"{subs[2]}");
            area = double.Parse($"{subs[3]}");
            Ix = double.Parse($"{subs[4]}");
            Wx = double.Parse($"{subs[5]}");
            rx = double.Parse($"{subs[6]}");
            rz = double.Parse($"{subs[7]}");
            x = double.Parse($"{subs[8]}");
            b = double.Parse($"{subs[9]}");
        }

        public string PlotarL(int id)
        {
            Assembly ListaPerfil = Assembly.GetExecutingAssembly();
            StreamReader readerPerfil = new StreamReader(ListaPerfil.GetManifestResourceStream("VerPerfisLaminados.Txt.perfisL.txt"));
            string perfis = readerPerfil.ReadToEnd(); //lê todo o arquivo
            string[] linhas = perfis.Split('\u000A'); //Quebra o arquivo lido em linhas
            string[] subs = linhas[id].Split(' '); //Quebra as linhas em propriedades

            perfil = $"{subs[0]}";
            peso = double.Parse($"{subs[1]}");
            t = double.Parse($"{subs[2]}");
            area = double.Parse($"{subs[3]}");
            Ix = double.Parse($"{subs[4]}");
            Wx = double.Parse($"{subs[5]}");
            rx = double.Parse($"{subs[6]}");
            rz = double.Parse($"{subs[7]}");
            x = double.Parse($"{subs[8]}");
            b = double.Parse($"{subs[9]}");



                return $"Perfil: {perfil} \r\n \r\n" +
                           $"Peso: {peso} kg/m \r\n" +
                           $"t: {t}  mm \r\n" +
                           $"Área: {area} cm2 \r\n" +
                           $"Ix=Iy: {Ix} cm4 \r\n" +
                           $"Wx=Wy: {Wx} cm3 \r\n" +
                           $"rx=ry: {rx} cm \r\n" +
                           $"rz min: {rz} cm \r\n" +
                           $"x: {x} cm \r\n \r\n";
            

        }
    }
}

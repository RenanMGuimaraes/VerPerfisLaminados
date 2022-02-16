using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace VerPerfisLaminados

{
    class PerfilCantoneira
    {
        public PerfilCantoneira(string perfil, double peso, double t, double area, double Ix, double Wx, double rx, double rz, double x)
        {
            this.perfil = perfil;
            this.peso = peso;
            this.t = t;
            this.area = area;
            this.Ix = Ix;
            this.Wx = Wx;
            this.rx = rx;
            this.rz = rz;
            this.x = x;
        }

        public string perfil;
        public double peso;
        public double t;
        public double area;
        public double Ix;
        public double Wx;
        public double rx;
        public double rz;
        public double x;

    }

    internal class PropPerfilL
    {
        public static double t, area, Ix, Wx, rx, rz, x, peso, b;

        public string PlotarL(int id)
        {
            string perfil;
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
                           $"rz min': {rz} cm \r\n" +
                           $"x: {x} cm \r\n \r\n";
            

        }
    }
}

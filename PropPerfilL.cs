using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VerPerfisLaminados
{
    internal class PropPerfilL
    {
        public static double t, area, Ix, Wx, rx, rz, x, peso;

        public string PlotarL(int id)
        {
            string perfil;
            

            //obter caminho do arquivo automaticamente
            //TODO
            string filename = @"C:\Users\renan\Documents\GitHub\VerPerfisLaminados\cantoneiras.txt";

                string line = File.ReadLines(filename).Skip(id).Take(1).First();
                string[] subs = line.Split(' ');
                perfil = $"{subs[0]}";
                peso = double.Parse($"{subs[1]}");
                t = double.Parse($"{subs[2]}");
                area = double.Parse($"{subs[3]}");
                Ix = double.Parse($"{subs[4]}");
                Wx = double.Parse($"{subs[5]}");
                rx = double.Parse($"{subs[6]}");
                rz = double.Parse($"{subs[7]}");
                x = double.Parse($"{subs[8]}");

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

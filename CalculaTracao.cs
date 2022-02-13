using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerPerfisLaminados
{
    internal class CalculaTracao
    {
        public double CalculaEcI()
        {
            double bf = PropPerfilI.bf;
            double tf = PropPerfilI.tf;
            double d = PropPerfilI.d;
            double tw = PropPerfilI.tw;
            double ec;          
                double amesa = ((bf / 2.0) - (tw / 2.0)) * tf * 2; //area das duas abas
                double aalma = d * (tw / 2.0); //area da alma
                double ymesa = bf / 2.0; //Y da mesa
                double yalma = tw / 4.0; //Y da alma
                double cg = ((amesa * ymesa * 2.0) + (aalma * yalma)) / (amesa * 2.0 + aalma); //calculo do cg em mm
                ec = (cg - (tw / 2.0)) / 10; //retorna ec em cm          
            return ec;

        }
        public double CalculaCt(int tipoCt, double ec, double lc, double ac, double area)
        {
            double ct = 1.0;

            switch (tipoCt)
            {
                case 1:
                    ct = 1.0;
                    break;
                case 2:
                    Ct_2();
                    break;
                case 3:
                    Ct_3();
                    break;
            }

            void Ct_2()
            {
                ct = 1 - ec / lc;
                if (ct > 0.9)
                {
                    ct = 0.9;
                }
            }
            void Ct_3()
            {
                ct = ac / area;
                if (ct > 0.9)
                {
                    ct = 0.9;
                }
            }
            return ct;

        }

        public string Tracao(string tipoperfil, double escoamento, double Ftsd, double ruptura, int tipoCt, double lc, 
            double ac, double punc, double folga, double diam, double numfuros, double l)
        {
            //Variaveis dos perfis
            double area = 0;
            double t = 0;
            double rmin = 0;
            double x = 0;

            //Preenche as variáveis dos perfis em função do tipo de perfil
            if  (tipoperfil == "i")
            {
                area = PropPerfilI.area;
                t = PropPerfilI.tw /10.0; //converte pra cm
                rmin = PropPerfilI.ry;
            }
            if (tipoperfil=="u")
            {
                area = PropPerfilU.area;
                t = PropPerfilU.tw / 10.0; //converte pra cm
                rmin = PropPerfilU.ry;
                x = PropPerfilU.x;
            }
            if (tipoperfil =="l")
            {
                area = PropPerfilL.area;
                t = PropPerfilL.t /10.0; //converte pra cm
                rmin = PropPerfilL.rz;
                x = PropPerfilL.x;
            }

            //Variáveis gerais
            double esb; //raio de giracao e esbeltez
            double ec = 0;
            string verCt;
            string resultado;
            string ver1, ver2, ver3, ver4, verfinal;
            escoamento = escoamento / 10.0; //converte de MPa para kN/cm2
            ruptura = ruptura / 10.0; //converte de MPa para kN/cm2
            punc = punc / 10.0; //converte de mm para cm
            folga = folga / 10.0; //converte de mm para cm
            diam = diam / 10.0; //converte de mm para cm

            //Calcula Ec
            if (tipoperfil =="i")
            {
                ec = CalculaEcI();
            }
            if(tipoperfil == "u" || tipoperfil =="l")
            {
                ec = x;
            }

            //Calcula Ct
            double ct = CalculaCt(tipoCt, ec, lc, ac, area);
            

            //Calcula a tração na seção bruta
            double Ftrd1 = (area * escoamento) / 1.10;
            

            if (Ftrd1 >= Ftsd)
            {
                ver1 = "PASSOU!";
            }
            else
            {
                ver1 = "NÃO PASSOU!";
            }

            //Calcula a tração na seção líquida         
            double diamfuro = diam + folga + punc;
            double An = area - numfuros * diamfuro * t;
            double Ae = ct * An;
            double Ftrd2 = (Ae * ruptura) / 1.35;

            if (ct < 0.6)
            {
                verCt = "ATENÇÃO: Ct menor do que 0.6! NÃO PASSOU!!";
                ver4 = "NÃO PASSOU!";
            }
            else
            {
                verCt = "OK";
                ver4 = "PASSOU!";
            }

            if (Ftrd2 >= Ftsd)
            {
                ver2 = "PASSOU!";
            }
            else
            {
                ver2 = "NÃO PASSOU!";
            }


            //Calcula a taxa de aproveitamento do perfil
            double Ftrd = Math.Min(Ftrd1, Ftrd2);
            double taxa = (Ftsd / Ftrd) * 100.0;

            //Calcula ELS
            esb = l / rmin;
            if (esb <= 300)
            {
                ver3 = "PASSOU!";
            }
            else
            {
                ver3 = "NÃO PASSOU!";
            }

            if (ver1 == "PASSOU!" && ver2 == "PASSOU!" && ver3 == "PASSOU!" && ver4 == "PASSOU!")
            {
                verfinal = "PASSOU!";
            }
            else
            {
                verfinal = "NÃO PASSOU!";
            }

            resultado = $"RESULTADO: {verfinal}\r\n \r\n" +
                            $"1 - ESCOAMENTO DA SEÇÃO BRUTA:{ver1} \r\n" +
                            $"Força resistente: Ft,rd = ({area:F2} x {escoamento:F2}) / 1,10 = {Ftrd1:F2} kN\r\n" +
                            $"Força solicitante: {Ftsd:F2} kN \r\n \r\n" +
                            $"2 - RUPTURA DA SEÇÃO EFETIVA: {ver2}\r\n" +
                            $"Diâmetro do furo: {diamfuro:F2)} cm \r\n" +
                            $"Ct: {ct:F2} - {verCt} \r\n" +
                            $"Área líquida: An = A - nf x df x tw = {area:F2} - {numfuros:F2} x {diamfuro:F2} x {t:F2} = {An:F2}  cm2\r\n" +
                            $"Área líquida efetiva: Ae = Ct x An = {ct:F2} x {An:F2} = {Ae:F2} cm2\r\n" +
                            $"Força resistente: Ftrd = {Ae:F2} x {ruptura:F2} / 1.35  = {Ftrd2:F2} kN\r\n" +
                            $"Força solicitante: {Ftsd:F2} kN\r\n \r\n" +
                            $"3 - ESTADO LIMITE DE SERVIÇO: {ver3} \r\n" +
                            $"Esbeltez: L / r,min = {l:F2} / {rmin:F2} = {esb:F2}\r\n \r\n" +
                            $"A taxa de aproveitamento do perfil é de {taxa:F2} % \r\n \r\n" +
                            "=============================================================================== \r\n" +
                            "LEGENDA: \r\n" +
                            "A: Área da seção transversal do perfil (cm2) \r\n" +
                            "nf: Número de furos na seção transversal \r\n" +
                            "df: Diâmetro do furo (cm) \r\n" +
                            "t: Espessura da chapa que está sendo ligada " +
                            "(Obs: Em perfis I e U a ligação está sendo considerada pela alma)";

            return resultado;

        }
    }
}

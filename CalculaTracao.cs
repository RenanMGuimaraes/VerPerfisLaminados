using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerPerfisLaminados
{


    internal class CalculaTracao
    {
        public double CalculaEc(string tipoperfil, double x, double bf, double tw, double tf, double d)
        {
            double ec;
            if (tipoperfil == "l" || tipoperfil == "u")
            {
                ec = x;
            }
            else //faz o cálculo do ec para perfis I
            {
                double amesa = ((bf / 2.0) - (tw / 2.0)) * tf * 2; //area das duas abas
                double aalma = d * (tw / 2.0); //area da alma
                double ymesa = bf / 2.0; //Y da mesa
                double yalma = tw / 4.0; //Y da alma
                double cg = ((amesa * ymesa * 2.0) + (aalma * yalma)) / (amesa * 2.0 + aalma); //calculo do cg em mm
                ec = (cg - (tw / 2.0)) / 10; //retorna ec em cm

            }
            return ec;

        }
        public double CalculaCt(int tipoCt, string tipoperfil, double ec, double lc, double ac,double area)
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

        public string Tracao(double area, double bf, double tf, double d, double lc, double ac, double escoamento, double Ftsd, double punc, double folga, double diam, double x,
                double ruptura, double t, double tw, double Lt, double rx, double ry, double rz, int tipoCt, int numfuros, string tipoperfil)
        {
            //Variaveis Gerais
            string resultado;
            string ver4;
            double ec = CalculaEc(tipoperfil, x, bf, tw, tf, d);
            double ct = CalculaCt(tipoCt, tipoperfil, ec, lc, ac, area);
            escoamento = escoamento / 10.0; //converte de MPa para kN/cm2
            ruptura = ruptura / 10.0; //converte de MPa para kN/cm2

            //Calcula a tração na seção bruta
            double Ftrd1 = (area * escoamento) / 1.10;
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
            punc = punc / 10.0;
            folga = folga / 10.0;
            diam = diam / 10.0;
            string verCt;
            double diamfuro = diam + folga + punc;
            double An = area - numfuros * diamfuro * t;
            double Ae = ct * An;
            double Ftrd2 = (Ae * ruptura) / 1.35;
            string ver2;
            string verfinal;

            //Calcula o valor de "t" considerando a ligação pela alma
            if (tipoperfil == "i" || tipoperfil == "u")
            {
                t = tw / 10.0;
            }
            if (tipoperfil == "l")
            {
                t = t / 10.0;
            }

            if (ct < 0.6)
            {
                verCt = "ATENÇÃO: Ct menor do que 0.6! REVER!!";
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
            double r;
            double esb;
            string ver3;
            if (tipoperfil == "i" || tipoperfil == "u")
            {
                r = ry;
            }
            else
            {
                r = rz;
            }
            esb = Lt / r;
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
                            $"Força resistente: Ft,rd = ({area.ToString("F2")} x {escoamento.ToString("F2")}) / 1,10 = {Ftrd1.ToString("F2")} kN\r\n" +
                            $"Força solicitante: {Ftsd.ToString("F2")} kN \r\n \r\n" +
                            $"2 - RUPTURA DA SEÇÃO EFETIVA: {ver2}\r\n" +
                            $"Diâmetro do furo: {diamfuro.ToString("F2")} cm \r\n" +
                            $"Ct: {ct.ToString("F2")} - {verCt} \r\n" +
                            $"Área líquida: An = A x nf x df x t ={area.ToString("F2")} - {numfuros.ToString("F2")} x {diamfuro.ToString("F2")} x {t.ToString("F2")} = {An.ToString("F2")}  cm2\r\n" +
                            $"Área líquida efetiva: Ae = Ct x An = {ct.ToString("F2")} x {An.ToString("F2")} = {Ae.ToString("F2")} cm2\r\n" +
                            $"Força resistente: Ftrd = {Ae.ToString("F2")} x {ruptura.ToString("F2")} / 1.35  = {Ftrd2.ToString("F2")} kN\r\n" +
                            $"Força solicitante: {Ftsd.ToString("F2")} kN\r\n \r\n" +
                            $"3 - ESTADO LIMITE DE SERVIÇO: {ver3} \r\n" +
                            $"Esbeltez: L / r,min = {Lt.ToString("F2")} / {r.ToString("F2")} = {esb.ToString("F2")}\r\n \r\n" +
                            $"A taxa de aproveitamento do perfil é de {taxa.ToString("F2")} % \r\n \r\n" +
                            "=============================================================================== \r\n" +
                            "LEGENDA: \r\n" +
                            "A: Área da seção transversal do perfil (cm2) \r\n" +
                            "nf: Número de furos na seção transversal \r\n" +
                            "df: Diâmetro do furo (cm) \r\n" +
                            "t: Espessura da chapa que está sendo ligada"+
                            "Obs: No caso de perfil I ou U, a ligação é considerada pela alma.";

            return resultado;

        }
        }
    }


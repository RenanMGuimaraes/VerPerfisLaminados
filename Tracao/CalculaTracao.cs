using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerPerfisLaminados
{
    internal class CalculaTracao
    {
        F_TracaoI pai;

        public string Tracao(int tipoCt, string lig, string tipoperfil, double ac, double lc, double fy, double ftsd, double fu, double punc, double folga,
            double diam, double numfuros, double lx, double ly, double lz, F_TracaoI f_Principal)
        {
            double ct = CalculoCt(tipoCt, tipoperfil, ac, lc);
            pai = f_Principal;

            //Variaveis dos perfis
            double area = 0;
            double t = 0;
            double rmin = 0;

            //Preenche as variáveis dos perfis em função do tipo de perfil
            if (tipoperfil == "i")
            {
                area = PropPerfilI.area;
                if (lig == "alma")
                {
                    t = PropPerfilI.tw;
                }
                else if (lig == "mesa")
                {
                    t = PropPerfilI.bf;
                }
                t /= 10.0; //converte pra cm
                rmin = PropPerfilI.ry;
            }
            if (tipoperfil == "u")
            {
                area = PropPerfilU.area;
                if (lig == "alma")
                {
                    t = PropPerfilI.tw;
                }
                else if (lig == "mesa")
                {
                    t = PropPerfilI.bf;
                }
                t = PropPerfilU.tw / 10.0; //converte pra cm
                rmin = PropPerfilU.ry;
            }
            if (tipoperfil == "l")
            {
                area = PropPerfilL.area;
                t = PropPerfilL.t / 10.0; //converte pra cm
                rmin = PropPerfilL.rz;
            }

            //Variáveis gerais
            double esb; //raio de giracao e esbeltez
            string verCt;
            string ver1, ver2, ver3, ver4;
            fy /= 10.0; //converte de MPa para kN/cm2
            fu /= 10.0; //converte de MPa para kN/cm2
            punc /= 10.0; //converte de mm para cm
            folga /= 10.0; //converte de mm para cm
            diam /= 10.0; //converte de mm para cm

            //Calcula a tração na seção bruta
            double ftrd1 = (area * fy) / 1.10;

            if (ftrd1 >= ftsd)
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
            double ftrd2 = (Ae * fu) / 1.35;

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

            if (ftrd2 >= ftsd)
            {
                ver2 = "PASSOU!";
            }
            else
            {
                ver2 = "NÃO PASSOU!";
            }


            //Calcula a taxa de aproveitamento do perfil
            double Ftrd = Math.Min(ftrd1, ftrd2);
            double taxa = (ftsd / Ftrd) * 100.0;

            //Calcula ELS
            double l = Math.Max(lz, Math.Max(lx, ly)); //determina o maior comprimento do perfil
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
                pai.lbl_verif.Text = "PASSOU !";
                pai.lbl_verif.ForeColor = System.Drawing.Color.Green;
            }
            else
            { 
                pai.lbl_verif.Text = "NÃO PASSOU !";
                pai.lbl_verif.ForeColor = System.Drawing.Color.Red;
            }

            return "TRAÇÃO: \r\n" +
                            $"1 - ESCOAMENTO DA SEÇÃO BRUTA:{ver1} \r\n" +
                            $"Força resistente: Ft,rd = ({area:F2} x {fy:F2}) / 1,10 = {ftrd1:F2} kN\r\n" +
                            $"Força solicitante: {ftsd:F2} kN \r\n \r\n" +
                            $"2 - RUPTURA DA SEÇÃO EFETIVA: {ver2}\r\n" +
                            $"Diâmetro do furo: {diamfuro:F2} cm \r\n" +
                            $"Ct: {ct:F2} - {verCt} \r\n" +
                            $"Área líquida: An = A - nf x df x t = {area:F2} - {numfuros:F2} x {diamfuro:F2} x {t:F2} = {An:F2}  cm2\r\n" +
                            $"Área líquida efetiva: Ae = Ct x An = {ct:F2} x {An:F2} = {Ae:F2} cm2\r\n" +
                            $"Força resistente: Ftrd = {Ae:F2} x {fu:F2} / 1.35  = {ftrd2:F2} kN\r\n" +
                            $"Força solicitante: {ftsd:F2} kN\r\n \r\n" +
                            $"3 - ESTADO LIMITE DE SERVIÇO: {ver3} \r\n" +
                            $"Esbeltez: L / r,min = {l:F2} / {rmin:F2} = {esb:F2}\r\n \r\n" +
                            $"A taxa de aproveitamento do perfil é de {taxa:F2} % \r\n \r\n";
                           


        }

        public double CalculoCt(int tipoCt, string tipoperfil, double ac, double lc)
        {
            double ct = 1.0;
            double ec = 1.0;

            //Calculo de ec para perfil I
            if (tipoperfil == "i")
            {
                double bf = PropPerfilI.bf;
                double tf = PropPerfilI.tf;
                double d = PropPerfilI.d;
                double tw = PropPerfilI.tw;

                //Cálculo de Ec                
                double amesa = ((bf / 2.0) - (tw / 2.0)) * tf * 2; //area das duas abas
                double aalma = d * (tw / 2.0); //area da alma
                double ymesa = bf / 2.0; //Y da mesa
                double yalma = tw / 4.0; //Y da alma
                double cg = ((amesa * ymesa * 2.0) + (aalma * yalma)) / (amesa * 2.0 + aalma); //calculo do cg em mm
                ec = (cg - (tw / 2.0)) / 10; //retorna ec em cm    
            }

            if (tipoperfil == "u")
            {
                ec = PropPerfilU.x;
            }
            if (tipoperfil == "l")
            {
                ec = PropPerfilL.x;
            }

            switch (tipoCt)
            {
                case 1:
                    ct = 1.0;
                    break;
                case 2:
                    double area = 1.0;
                    if (tipoperfil == "i")
                    {
                        area = PropPerfilI.area;
                    }
                    if (tipoperfil == "u")
                    {
                        area = PropPerfilU.area;
                    }
                    if (tipoperfil == "l")
                    {
                        area = PropPerfilL.area;
                    }
                    ct = ac / area;
                    if (ct > 0.9)
                    {
                        ct = 0.9;
                    }
                    break;
                case 3:
                    ct = 1 - ec / lc;
                    break;
            }
            return ct;
        }




    }

}




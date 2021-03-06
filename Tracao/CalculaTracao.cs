using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerPerfisLaminados
{
    internal class CalculaTracao
    {
        F_Principal pai;

        public string Tracao(int tipoCt, string lig, string tipoperfil, double ac, double lc, double fy, double ftsd, double fu, double punc, double folga,
            double diam, double numfuros, double numfurosAlma, double numfurosMesa, double lx, double ly, double lz, F_Principal f_Principal)
        {


            double ct = CalculoCt(tipoCt, tipoperfil, ac, lc, lig);
            pai = f_Principal;

            //Variaveis dos perfis
            double area = 0;
            double t = 0;
            double rmin = 0;
            double tw = 0;
            double tf = 0;

            
            //Preenche as variáveis dos perfis em função do tipo de perfil
            if (tipoperfil == "i")
            {
                area = PropPerfilI.area;
                tw = PropPerfilI.tw / 10.0;
                tf = PropPerfilI.tf / 10.0;
                rmin = PropPerfilI.ry;
            }
            if (tipoperfil == "u")
            {
                area = PropPerfilU.area;
                tw = PropPerfilI.tw / 10.0;
                tf = PropPerfilI.tf / 10.0;
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
            double an = 0;
            if(tipoperfil == "i" || tipoperfil == "u")
            {
               an = area - numfurosAlma * diamfuro * tw - numfurosMesa * diamfuro - tf;
            }
            else if (tipoperfil == "l")
            {
                an = area - numfuros * diamfuro * t;
            }
            double ae = ct * an;
            double ftrd2 = (ae * fu) / 1.35;

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
                pai.lbl_verifTracao.Text = "PASSOU !";
                pai.lbl_verifTracao.ForeColor = System.Drawing.Color.Green;
            }
            else
            { 
                pai.lbl_verifTracao.Text = "NÃO PASSOU !";
                pai.lbl_verifTracao.ForeColor = System.Drawing.Color.Red;
            }

            string resultado = $"1 - ESCOAMENTO DA SEÇÃO BRUTA:{ver1} \r\n" +
                             $"Ft,rd = ({area:F2} x {fy:F2}) / 1,10 = {ftrd1:F2} kN\r\n" +
                             $"Ft,sd: {ftsd:F2} kN \r\n \r\n" +
                             $"2 - RUPTURA DA SEÇÃO EFETIVA: {ver2}\r\n" +
                             $"df: {diam:F2} + {folga:F2} + {punc:F2} = {diamfuro:F2} cm \r\n" +
                             $"Ct: {ct:F2} - {verCt} \r\n";
                            
                             if (tipoperfil =="i" || tipoperfil == "u")
            {
                if (lig == "alma")
                {
                    resultado += $"An = A - nf x df x tw = {area:F2} - {numfurosAlma:F2} x {diamfuro:F2} x {tw:F2} = {an:F2}  cm2\r\n";
                }
                if (lig == "mesa")
                {
                    resultado += $"An = A - nf x df x tf= {area:F2} - {numfurosMesa:F2} x {diamfuro:F2} x {tf:F2}= {an:F2}  cm2\r\n";
                }
                if (lig == "ambos")
                {
                    resultado += $"An = A - nf x df x tw - nf x df x tf= {area:F2} - {numfurosAlma:F2} x {diamfuro:F2} x {tw:F2} - {numfurosMesa:F2} x {diamfuro:F2} x {tf:F2}= {an:F2}  cm2\r\n";
                }
                
            }
                            else if (tipoperfil == "l")
            {
                             resultado += $"An = A - nf x df x t = {area:F2} - {numfuros:F2} x {diamfuro:F2} x {t:F2} = {an:F2}  cm2\r\n";
            }

                         resultado +=   $"Ae = Ct x An = {ct:F2} x {an:F2} = {ae:F2} cm2\r\n" +
                            $"Ft,rd = {ae:F2} x {fu:F2} / 1.35  = {ftrd2:F2} kN\r\n" +
                            $"Ft,sd = {ftsd:F2} kN\r\n \r\n" +
                            $"3 - ESTADO LIMITE DE SERVIÇO: {ver3} \r\n" +
                            $"Esbeltez: L / r,min = {l:F2} / {rmin:F2} = {esb:F2}\r\n \r\n" +
                            $"A taxa de aproveitamento do perfil é de {taxa:F2} % \r\n \r\n" +
                             " ======================================================== \r\n" +
                            "LEGENDA: \r\n" +
                            "Ft,rd = Força resistente de cálculo (kN) \r\n" +
                            "Ft,sd = Força solicitante de cálculo (kN) \r\n" +
                            "A: Área da seção transversal do perfil (cm2) \r\n" +
                            "An: Área líquida efetiva (cm2) \r\n" +
                            "nf: Número de furos na seção transversal \r\n" +
                            "df: Diâmetro do furo (cm) \r\n" +
                            "Ct: Coeficiente de redução da área líquida \r\n"+
                            "t, tw ou tf: Espessura da chapa que está sendo ligada "; 

           return resultado;


        }

       

        public double CalculoCt(int tipoCt, string tipoperfil, double ac, double lc, string lig)
        {
            double ct = 1.0;
            double ec = 1.0;

            //Calculo de ec para perfil I
            if (tipoperfil == "i")
            {
                double bf = PropPerfilI.bf / 10.0;
                double tf = PropPerfilI.tf / 10.0;
                double d = PropPerfilI.d / 10.0;
                double tw = PropPerfilI.tw / 10.0;

                //Cálculo de Ec  
                if ( lig == "alma")
                {
                    double amesa = ((bf / 2.0) - (tw / 2.0)) * tf * 2; //area das duas mesas
                    double aalma = d * (tw / 2.0); //area da alma
                    double ymesa = (((bf / 2.0) - tw / 2.0) / 2.0); //Y da mesa
                    double yalma = tw / 4.0; //Y da alma
                    double cg = ((amesa * ymesa * 2.0) + (aalma * yalma)) / (amesa * 2.0 + aalma); //calculo do cg 
                    ec = (cg - (tw / 2.0)); //retorna ec em cm    
                }

                if (lig =="mesa")
                {
                    double amesa = bf * tf; //area da mesa
                    double ymesa = d - tf / 2.0;
                    double aalma = (d - tf) / 2.0;
                    double yalma = d / 4.0;
                    double cg = (amesa * ymesa) + (aalma * yalma) / (amesa + aalma); //calcula cg
                    ec = d / 2.0 - cg;

                }
                              
               
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




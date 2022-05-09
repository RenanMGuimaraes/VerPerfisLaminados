using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerPerfisLaminados
{
    public class TracaoI
    {
   

        public string CalculaTracao(F_Principal f_principal, double fy, double fu, double ntsd, double lx, double ly, double lz)
        {
            F_Principal pai;
            pai = f_principal;
            double area = PropPerfilI.area;
            double tw = PropPerfilI.tw / 10.0;
            double tf = PropPerfilI.tf / 10.0;
            double rmin = PropPerfilI.ry;
            double esb; //esbeltez
            fy /= 10.0; //converte de MPa para kN/cm2
            fu /= 10.0; //converte de MPa para kN/cm2
            double ntrd, taxa;

            //Calcula a tração na seção bruta
            ntrd = (area * fy) / 1.10;

            //Calcula a taxa de aproveitamento do perfil
           taxa = (ntsd / ntrd);

            if (ntrd >= ntsd)
            {
                pai.lb_sdrd_nt.ForeColor = System.Drawing.Color.Green;
                pai.lb_sdrd_nt.Text = $"Sd/Rd = {taxa:F2} ";
            }
            else
            {
                pai.lb_sdrd_nt.ForeColor = System.Drawing.Color.Red;
                pai.lb_sdrd_nt.Text = $"Sd/Rd = {taxa:F2} ";
            }
           

            //Calcula ELS
            double l = Math.Max(lz, Math.Max(lx, ly)); //determina o maior comprimento do perfil
            esb = l / rmin;
            if (esb <= 300)
            {
                pai.lbl_ntrd_esb.Text = "Esbeltez: OK!";
                pai.lbl_ntrd_esb.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                pai.lbl_ntrd_esb.Text = "Esbeltez: Falhou!";
                pai.lbl_ntrd_esb.ForeColor = System.Drawing.Color.Red;
            }

            //Preenche o valor da resistencia final no txt_ntrd
            pai.txt_ntrd.Text = ntrd.ToString("F2");


            string resultado = "DIMENSIONAMENTO A TRAÇÃO: \n\n"+
                $"Nt,sd: {ntsd:F2} kN \n" +
                $"Nt,rd: {ntrd:F2} kN \n\n" +
                $"1 - ESCOAMENTO DA SEÇÃO BRUTA: \r\n" +
                             $"Ft,rd = Ag x fy /1,10 = ({area:F2} x {fy:F2}) / 1,10 = {ntrd:F2} kN\r\n" +
                             $"Ft,sd: {ntsd:F2} kN \r\n \r\n" +
                            $"2 - ESTADO LIMITE DE SERVIÇO: \r\n" +
                            $"Esbeltez: L / r,min = {l:F2} / {rmin:F2} = {esb:F2}\r\n \r\n" +
                            $"A taxa de aproveitamento do perfil é de {taxa*100.0:F2} % \r\n \r\n";
           return resultado;


        }

       
        /*
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
            */
        
    }

    }




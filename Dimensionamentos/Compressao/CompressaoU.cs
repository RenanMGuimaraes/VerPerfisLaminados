using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerPerfisLaminados
{
    internal class CompressaoU
    {
        public string CalculaCompressao(F_Principal f_Principal, double fy, double ncsd, double lx, double ly, double lz, double elast, double g)
        {
            F_Principal pai;
            pai = f_Principal;
            fy /= 10.0; //Converte de MPa para kN/cm2
            elast /= 10.0; //Converte de MPa para kN/cm2  

            //Propriedades do Perfil
            double ag = PropPerfilU.area;
            double taxa = 0;
            double rmin = PropPerfilU.ry;
            double bf = PropPerfilU.bf;
            double tf = PropPerfilU.tf;
            double tw = PropPerfilU.tw;
            double ix = PropPerfilU.Ix;
            double iy = PropPerfilU.Iy;
            double it = PropPerfilU.It;
            double rx = PropPerfilU.rx;
            double ry = PropPerfilU.ry;
            double cw = PropPerfilU.Cw;
            double d = PropPerfilU.d;
            double dlinha = d - 4.0 * tf;
            double r0 = Math.Sqrt(rx * rx + ry * ry);

            //Calculo de Xo -- Centro de cisalhamento em X
            double x0 = (tf * Math.Pow((d - tf), 2) * Math.Pow((bf - (tw / 2.0)), 2))/ (4 * ix);


            //CALCULO DE Q ---------------------------------------------------------------------
            double q, qs = 0, qa = 0;
            double btmesa, btlim_mesa;
            double btalma, btlim_alma;
            double bef = 0, ae = 0;

            //Alma
            btalma = dlinha / tw;
            btlim_alma = 1.49 * Math.Sqrt(elast / fy);

            if (btalma <= btlim_alma)
            {
                qa = 1.0;
            }
            else
            {
                //Área efetiva
                tw /= 10.0; //converte de mm para cm
                dlinha /= 10.0; //converte de mm para cm
                bef = 1.92 * tw * Math.Sqrt(elast / fy) * (1.0 - (0.34 / btalma) * Math.Sqrt(elast / fy));
                if (bef > dlinha)
                {
                    bef = dlinha;
                }
                ae = ag - (dlinha - bef) * tw;
                qa = ae / ag;
            }

            //Mesa               
            btlim_mesa = 0.56 * Math.Sqrt(elast / fy);
            btmesa = bf / (2.0 * tf);
            if (btmesa <= btlim_mesa)
            {
                qs = 1.0;
            }
            else
            {
                if (btmesa > (0.56 * Math.Sqrt(elast / fy)) && btmesa <= (1.03 * Math.Sqrt(elast / fy)))
                {
                    qs = 1.415 - 0.74 * btmesa * Math.Sqrt(elast / fy);
                }
                if (btmesa > 1.03 * Math.Sqrt(elast / fy))
                {
                    qs = (0.69 * elast) / (fy * Math.Pow(btmesa, 2.0));
                }
            }
            q = qs * qa;

            //CALCULO DE X -------------------------------------------------------------------------------
            double x;
            double ne;
            double lamb0;


            //Flambagem elastica em torno de X e Y e por torção
            double nex = (Math.Pow(Math.PI, 2.0) * elast * ix) / Math.Pow(lx, 2.0);
            double ney = (Math.Pow(Math.PI, 2.0) * elast * iy) / Math.Pow(ly, 2.0);
            double nez = (1.0 / Math.Pow(r0, 2.0)) * ((Math.Pow(Math.PI, 2.0) * elast * cw) / Math.Pow(lz, 2.0) + g * it);
            double neyz = (nex + nez) / (2 * (1 - (x0 / r0))) * (1 - Math.Sqrt(1 - (4 * nex * nez * (1 - Math.Pow((x0 / r0), 2)))/ Math.Pow((nex + nez), 2)));

            ne = Math.Min(nex, neyz);
            lamb0 = Math.Sqrt((q * ag * fy) / ne);

            if (lamb0 <= 1.5)
            {
                x = Math.Pow(0.685, (lamb0 * lamb0));
            }
            else
            {
                x = 0.877 / (lamb0 * lamb0);
            }


            //Plota resultados gerais-------------------------------------------------------------------------------------
            double ncrd = (q * x * ag * fy) / 1.10;
            taxa = ncsd / ncrd;
            pai.lb_sdrd_nc.Text = $"Sd/Rd = {taxa:F2}";
            if (ncrd >= ncsd)
            {
                pai.lb_sdrd_nc.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                pai.lb_sdrd_nc.ForeColor = System.Drawing.Color.Red;
            }
            pai.txt_ncrd.Text = ncrd.ToString("F2");

            //ELS-----------------------------------------------------------------------------------------------
            double esbmin, esbx, esby;
            esbx = lx / rx;
            esby = ly / ry;
            esbmin = Math.Min(esbx, esby);

            if (esbmin > 200)
            {
                pai.lbl_ncrd_esb.Text = "Esbeltez: Falhou!";
                pai.lbl_ncrd_esb.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                pai.lbl_ncrd_esb.Text = "Esbeltez: OK!";
                pai.lbl_ncrd_esb.ForeColor = System.Drawing.Color.Green;
            }

            //Retorna texto dos resultados
            string resultado = "DIMENSIONAMENTO A COMPRESSÃO \n\n" +
               $"Nc,sd = {ncsd:F2} kN \n" +
               $"Nc,rd = {ncrd:F2} kN \n" +
               $"Taxa = {taxa:F3} \n\n" +
               $"Verificação em ELS: \n" +
               $"Esbeltez em X: {lx:F2} / {rx:F2} = {esbx:F2}\n" +
               $"Esbeltez em Y: {ly:F2} / {ry:F2} = {esby:F2}\n\n" +
               $"Verificação em ELU: \n" +
               $"Nc,rd = χ * Q * Ag * fy / 1,10 \n\n" +
               $"Sendo, \n\n" +
               $"Q (Fator de redução associado à flambagem local):  \n\n" +
               $" - Flambagem local de mesa comprimida: \n" +
               $"Esbeltez da mesa: bf / (2,0 * tf) = {bf:F2} / (2,0 * {tf:F2}) = {btmesa:F2}\n" +
               $"Esbeltez limite da mesa: 0,56 * sqrt(E/fy) = 0,56 * sqrt({elast:F0}) / {fy:F1}) = {btlim_mesa:F2}\n";
            if (btmesa <= btlim_mesa)
            {
                resultado += $"{btmesa:F2} < = {btlim_mesa:F2} \n" +
                    $"Qs = {qs:F2} \n\n";
            }
            else
            {
                resultado += $"{btmesa:F2} > {btlim_mesa:F2} \n";
                if (btmesa > (0.56 * Math.Sqrt(elast / fy)) && btmesa <= (1.03 * Math.Sqrt(elast / fy)))
                {
                    resultado += $"Qs = 1,415 - 0,74 * {btmesa:F2} * Sqrt({elast:F0} / {fy:F1}) = {qs:F2} \n\n";
                }
                if (btmesa > 1.03 * Math.Sqrt(elast / fy))
                {
                    resultado += $"Qs = (0,69 * {elast:F0}) / ({fy:F1} * ({btmesa} ^ 2,0)) = {qs:F2} \n\n";
                }
            }
            resultado += $" - Flambagem local de alma comprimida: \n" +
            $"Esbeltez da alma: b / t = {dlinha:F2} / {tw:F2} = {btalma:F2}\n" +
            $"Esbeltez limite da mesa: 0,56 * sqrt(E/fy) = 0,56 * Sqrt({elast:F0} / {fy:F1}) = {btlim_mesa:F2}\n";
            if (btalma <= btlim_alma)
            {
                resultado += $"{btalma:F2} < = {btlim_alma:F2} \n" +
                    $"Qa = {qa:F2} \n\n";
            }
            else
            {
                resultado += $"{btalma:F2} > {btlim_alma:F2} (Deve-se efetuar o cálculo do comprimento efetivo da mesa):\n" +
                    $"bef = 1,92 * tw * Sqrt(E/fy)*((1 - 0,34/(b/t))*Sqrt(E/fy)) = 1,92 * {tw:F2} * Sqrt({elast:F0} / {fy:F1}) * (1,0 - (0,34 / {btalma:F2}) * Sqrt({elast:F0} / {fy:F1})) = {bef:F2} \n" +
                    $"Ae = Ag - (d' - bef) * tw = {ag:F2} - ({dlinha:F2} - {bef:F2}) * {tw:F2} = {ae:F2} \n" +
                    $"Qa = {qa:F2} \n\n";
            }
            resultado += $"Q = Qs * Qa = {qs:f2} * {qa:F2} = {q:F2} \n\n" +
                $"X (Fator de redução associado à flambagem global):{x:F2} \n" +
                $"Nex: (π^2 * E * Ix) / ( Kx * Lx)^2 = (π^2 * {elast:F0} * {ix:F2}) / ({lx:F0})^2 = {nex:F2} kN \n" +
                $"Nex: (π^2 * E * Iy) / ( Ky * Ly)^2 = (π^2 * {elast:F0} * {iy:F2}) / ({ly:F0})^2 = {ney:F2} kN \n" +
                $"Nez: (1 / ro^2) * ((π^2 * E * Cw) / ( Kz * Lz)^2) + G * It = 1 / {r0:F2}^2) * ((π^2 * {elast:F0} * {cw:F0}) / ({lz:F0})^2) + {g:F0} * {it:F2} = {nez:F2} kN \n" +
                $"Índice de esbeltez reduzido(λ0): Sqrt((Q * Ag * fy) / Ne) = Sqrt(({q:F2} * {ag:F2} * {fy:F1}) / {ne:F2}) = {lamb0:F2} \n ";
            if (lamb0 <= 1.5)
            {
                resultado += $"χ = (0,685^(λ0^2)) = (0,685^({lamb0:F2}^2)) = {x:F2} \n";
            }
            else
            {
                resultado += $"χ = 0.877 / (λ0^2) = 0.877 / ({lamb0:F2}^2) = {x:F2} \n";
            }
            resultado += $"Nc,rd = χ * Q * Ag * fy / 1,10 = {x:F2} * {q:F2} * {ag:F2} * {fy:F2} / 1,10 = {ncrd:F2} kN \n\n" +
             "\n\n";

            return resultado;



        }

    }
}


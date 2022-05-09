using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerPerfisLaminados
{
    public class CortanteI
    {
        

        public string CalculaCortanteX(F_Principal f_principal, double fy, double vxsd, double elast)
        {
            F_Principal pai;
            pai = f_principal;
            fy /= 10.0; //converte de MPa para kN/cm2
            elast /= 10.0; //converte de MPa para kN/cm2
            double taxa;
            double aw, vpl, vxrd = 0;
            double bt, btp, btr;
            double tw = PropPerfilI.tw / 10.0;
            double h = PropPerfilI.dlinha / 10.0;
            double d = PropPerfilI.d / 10.0;
         
            //Parametros da alma
            aw = d * tw;
            bt = h / tw;
            vpl = 0.6 * aw * fy;

            //Limites de esbeltez
            btp = 1.10 * (Math.Sqrt((5.0 * elast) / fy));
            btr = 1.37 * (Math.Sqrt((5.0 * elast) / fy));

            if (bt <= btp)
            {
                vxrd = vpl / 1.10;
            }else if(bt > btp && bt <= btr)
                {
                vxrd = (btp / bt) * (vpl / 1.10);
            }
            else if(bt > btr)
            {
                vxrd = 1.24 * Math.Pow((btp / bt), 2.0) * (vpl / 1.10);
            }

            //Preenche o valor da resistencia final no txt_ntrd
            taxa = vxsd / vxrd;
            pai.txt_vxrd.Text = vxrd.ToString("F2");
            pai.lb_sdrd_vx.Text = $"Sd/Rd = {taxa:F2}";
            if(taxa <= 1.0)
            {
                pai.lb_sdrd_vx.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                pai.lb_sdrd_vx.ForeColor = System.Drawing.Color.Red;
            }

            string resultado = "DIMENSIONAMENTO A CORTANTE - EIXO X: \n\n" +
                $"Nt,sd: {vxsd:F2} kN \n" +
                $"Nt,rd: {vxrd:F2} kN \n\n" +
                $"Aw: d * tw: {d} * {tw} = {aw:F2} \n" +
                $"Vpl: 0,6 * Aw * fy: 0,6 *{aw} * {fy} = {vpl:F2} \n" +
                $"- ESBELTEZ DA ALMA: {bt:f2} \r\n" +
                $"- ESBELTEZ LIMITE - P: {btp:f2} \r\n" +
                $"- ESBELTEZ LIMITE - R: {btr:f2} \r\n\n";
                if (bt <= btp)
            {
                resultado += $"Vrd = Vpl / 1,10 = {vxrd:F2} \n";
            }
            else if (bt > btp && bt <= btr)
            {
                resultado += $"Vrd = (btp / bt) * (Vpl / 1,10) = {(btp/bt):F2} * {vpl:F2} / 1,10 = {vxrd:F2} \n";
                
            }
            else if (bt > btr)
            {
                resultado += $"Vrd = 1,24 * ((btp / bt)^2) * (Vpl / 1,10) = 1,24 * ({btp:F2} / {bt:F2}) * ({vpl:F2} / 1,10) = {vxrd:F2}\n";
            }
            resultado +=  $"A taxa de aproveitamento do perfil é de {taxa*100.0:F2} % \r\n \r\n";
            return resultado;
        }

        

        public string CalculaCortanteY(F_Principal f_principal, double fy, double vysd, double elast)
        {
            F_Principal pai;
            elast /= 10.0; //converte de MPa para kN/cm2
            fy /= 10.0; //converte de MPa para kN/cm2
            pai = f_principal;
            double tf = PropPerfilI.tf / 10.0;
            double bf = PropPerfilI.bf / 10.0;
            double tw = PropPerfilI.tf / 10.0;
            double h = PropPerfilI.bf / 20.0;
            double aw, bt, vpl, btp, btr, vyrd = 0;
            double taxa = 0;
  
            //Resistencia da alma
            aw = 2 * tf * bf;
            bt = h / tw;
            vpl = 0.6 * aw * fy;

            btp = 1.10 * (Math.Sqrt((1.2 * elast) / fy));
            btr = 1.37 * (Math.Sqrt((1.2 * elast) / fy));

            if (bt <= btp)
            {
                vyrd = vpl / 1.10;
            }
            else if (bt > btp && bt <= btr)
            {
                vyrd = (btp / bt) * (vpl / 1.10);
            }
            else if (bt > btr)
            {
                vyrd = 1.24 * Math.Pow((btp / bt), 2.0) * (vpl / 1.10);
            }

            //Preenche o valor da resistencia final no txt_ntrd
            taxa = vysd / vyrd;
            pai.txt_vyrd.Text = vyrd.ToString("F2");
            pai.lb_sdrd_vy.Text = $"Sd/Rd = {taxa:F2}";
            if (taxa <= 1.0)
            {
                pai.lb_sdrd_vy.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                pai.lb_sdrd_vy.ForeColor = System.Drawing.Color.Red;
            }

            string resultado = "DIMENSIONAMENTO A CORTANTE - EIXO Y: \n\n" +
                $"Nt,sd: {vysd:F2} kN \n" +
                $"Nt,rd: {vyrd:F2} kN \n\n" +
                $"Aw: 2 * tf * bf: 2 * {tf} * {bf} = {aw:F2} \n" +
                $"Vpl: 0,6 * Aw * fy: 0,6 *{aw} * {fy} = {vpl:F2} \n" +
                $"- ESBELTEZ DA ALMA: {bt:f2} \r\n" +
                $"- ESBELTEZ LIMITE - P: {btp:f2} \r\n" +
                $"- ESBELTEZ LIMITE - R: {btr:f2} \r\n\n";
            if (bt <= btp)
            {
                resultado += $"Vrd = Vpl / 1,10 = {vyrd:F2} \n";
            }
            else if (bt > btp && bt <= btr)
            {
                resultado += $"Vrd = (btp / bt) * (Vpl / 1,10) = {(btp / bt):F2} * {vpl:F2} / 1,10 = {vyrd:F2} \n";

            }
            else if (bt > btr)
            {
                resultado += $"Vrd = 1,24 * ((btp / bt)^2) * (Vpl / 1,10) = 1,24 * ({btp:F2} / {bt:F2}) * ({vpl:F2} / 1,10) = {vyrd:F2}\n";
            }
            resultado += $"A taxa de aproveitamento do perfil é de {taxa*100.0:F2} % \r\n \r\n";
            return resultado;
        }
    }
}

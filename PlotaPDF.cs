using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace VerPerfisLaminados
{
    internal class PlotaPDF
    {
        public void Plotar(F_Principal f_principal, string tipoperfil)
        {
            try
            {
                //caminho do diretório atual
                string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                string nomeArquivo = dir + @"\Memorial.pdf";
                FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
                Document doc = new Document(PageSize.A4);
                PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF);

                //Full path to the Unicode Arial file
                string ARIALUNI_TFF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIALUNI.TTF");

                //Create a base font object making sure to specify IDENTITY-H
                BaseFont bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                //Create a specific font object
                Font f = new Font(bf, 10, Font.NORMAL);
                Font f_bold12 = new Font(bf, 12, Font.BOLD);
                Font f_bold14 = new Font(bf, 14, Font.BOLD);
                //Create a specific font object
                Font sub = new Font(bf, 10, Font.NORMAL);
                sub.SetStyle(7);

                F_Principal pai;
                pai = f_principal;
                string dados = "";
                string perfil = "";

                //Escreve o nome do perfil
                if (tipoperfil == "i")
                {
                    perfil = PropPerfilI.perfil;
                }
                if (tipoperfil == "u")
                {
                    perfil = PropPerfilU.perfil;
                }
                if (tipoperfil == "l")
                {
                    perfil = PropPerfilL.perfil;
                }


                //Cabeçalho
                Paragraph paragrafo1 = new Paragraph(dados, new iTextSharp.text.Font(f_bold14));
                paragrafo1.Alignment = Element.ALIGN_CENTER;
                paragrafo1.Add("MEMORIAL DE CÁLCULO\n\n");
                paragrafo1.Add($"Perfil: {perfil}\n\n");

                //ADICIONAR AS PROPRIEDADES DO PERFIL 
                //TODO
                doc.Open();
                doc.Add(paragrafo1);
                

                if (pai.cb_ncrd.Checked) //Imprime compressão
                {
                    //Titulo
                    Paragraph paragrafo2 = new Paragraph(dados, new iTextSharp.text.Font(f));
                    paragrafo2.Alignment = Element.ALIGN_CENTER;
                    paragrafo2.Add("DIMENSIONAMENTO A COMPRESSÃO \n\n");



                }

                if (pai.cb_ntrd.Checked) //Imprime tração
                {
                    //Titulo
                    Paragraph paragrafo2 = new Paragraph(dados, new iTextSharp.text.Font(f_bold12));
                    paragrafo2.Alignment = Element.ALIGN_CENTER;
                    paragrafo2.Add("-- DIMENSIONAMENTO A TRAÇÃO --\n");

                    Paragraph paragrafo3 = new Paragraph(dados, new iTextSharp.text.Font(f));
                    paragrafo3.Alignment = Element.ALIGN_CENTER;
                    paragrafo3.Add("ABNT NBR 8800/2008 - Item 5.2 \n\n");

                    Paragraph paragrafo4 = new Paragraph(dados, new iTextSharp.text.Font(f));
                    paragrafo4.Alignment = Element.ALIGN_LEFT;
                    paragrafo4.Add($"- Nt,sd: Esforço solicitante de cálculo): {Tracao.ntsd1:F2} kN \n");
                    paragrafo4.Add($"- Nt,rd (Esforço resistente de cálculo): {Tracao.ntrd1:F2} kN \n");
                    paragrafo4.Add($"- Nt,sd / Nt,rd: {Tracao.taxa:F3} \n\n");

                    Paragraph paragrafo5 = new Paragraph(dados, new iTextSharp.text.Font(f));
                    paragrafo5.Alignment = Element.ALIGN_LEFT;
                    paragrafo5.Add($"Escoamento da seção bruta: \n\n");                 

                    Paragraph paragrafo6 = new Paragraph(dados, new iTextSharp.text.Font(f));
                    paragrafo6.Alignment = Element.ALIGN_LEFT;
                    paragrafo6.Add("O escoamento da seção bruta é dado por: \n");

                    System.IO.Stream s = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("VerPerfisLaminados.Imagens.ntrd.png");
                    iTextSharp.text.Image ntrd = iTextSharp.text.Image.GetInstance(System.Drawing.Image.FromStream(s), System.Drawing.Imaging.ImageFormat.Png);
                    ntrd.ScaleToFit(80f, 80f);
                  
                    Paragraph paragrafo7 = new Paragraph(dados, new iTextSharp.text.Font(f));
                    paragrafo7.Alignment = Element.ALIGN_LEFT;
                    paragrafo7.Add("Sendo,\n");
                    paragrafo7.Add($"Ag: Área bruta da seção transversal = {Tracao.area:F2} cm2 \n");
                    paragrafo7.Add($"fy: Tensão de escoamento do aço = {Tracao.fyt:F2} MPa \n");
                    paragrafo7.Add($" \u0263 : Coeficiente de minoração = 1,10 \n");
                    paragrafo7.Add($"Nt,rd: Esforço resistente de cálculo = {Tracao.ntrd1:F2} kN \n");
                    paragrafo7.Add("\n\n");

                    
                    doc.Add(paragrafo2);
                    doc.Add(paragrafo3);
                    doc.Add(paragrafo4);
                    doc.Add(paragrafo5);
                    doc.Add(paragrafo6);    
                    doc.Add(ntrd);
                    doc.Add(paragrafo7);
                    

                    
                }

                if (pai.cb_vxrd.Checked) //Imprime cortante X
                {
                    

                    //Titulo
                    Paragraph paragrafo2 = new Paragraph(dados, new iTextSharp.text.Font(f_bold12));
                    paragrafo2.Alignment = Element.ALIGN_CENTER;
                    paragrafo2.Add("DIMENSIONAMENTO A CORTANTE - EIXO X \n");

                    Paragraph paragrafo3 = new Paragraph(dados, new iTextSharp.text.Font(f));
                    paragrafo3.Alignment = Element.ALIGN_CENTER;
                    paragrafo3.Add("ABNT NBR 8800/2008 - Item 5.4.3 \n\n");

                    Paragraph paragrafo4 = new Paragraph(dados, new iTextSharp.text.Font(f));
                    paragrafo4.Alignment = Element.ALIGN_LEFT;
                    paragrafo4.Add($"- Vx,sd (Esforço solicitante de cálculo): {CalculaCortante.vxsd:F2} kN \n");
                    paragrafo4.Add($"- Vx,rd (Esforço resistente de cálculo): {CalculaCortante.vxrd:F2} kN \n");
                    paragrafo4.Add($"- Vx,sd / Vx,rd: {CalculaCortante.taxax:F3} \n\n");

                    System.IO.Stream s1 = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("VerPerfisLaminados.Imagens.vx1.png");
                    iTextSharp.text.Image vx1rd = iTextSharp.text.Image.GetInstance(System.Drawing.Image.FromStream(s1), System.Drawing.Imaging.ImageFormat.Png);
                    vx1rd.ScaleToFit(180f, 180f);

                    System.IO.Stream s2 = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("VerPerfisLaminados.Imagens.vx2.png");
                    iTextSharp.text.Image vx2rd = iTextSharp.text.Image.GetInstance(System.Drawing.Image.FromStream(s2), System.Drawing.Imaging.ImageFormat.Png);
                    vx2rd.ScaleToFit(160f, 160f);

                    Paragraph paragrafo5 = new Paragraph(dados, new iTextSharp.text.Font(f));
                    paragrafo5.Alignment = Element.ALIGN_LEFT;
                    paragrafo5.Add($"\u03BB: {CalculaCortante.bt:F2}\n");
                    paragrafo5.Add($"\u03BBp: {CalculaCortante.btp:F2}\n");
                    paragrafo5.Add($"\u03BBr: {CalculaCortante.btr:F2}\n");

                    Paragraph paragrafo6 = new Paragraph(dados, new iTextSharp.text.Font(f));
                    paragrafo6.Alignment = Element.ALIGN_LEFT;             
                    paragrafo6.Add("Sendo,\n");
                    paragrafo6.Add($"h: Comprimento da alma = {CalculaCortante.h:F2} mm \n");
                    paragrafo6.Add($"tw: Espessura da alma = {CalculaCortante.tw:F2} mm \n");
                    paragrafo6.Add($"Aw: Área da alma = {CalculaCortante.aw:F2} cm2\n");
                    paragrafo6.Add($"Vpl: Força cortante correspondente à plastificação da alma por cisalhamento\n");
                    paragrafo6.Add($"Vpl: 0,6 * Aw * fy = {CalculaCortante.vpl:F2} kN \n");
                    

                    doc.Add(paragrafo2);
                    doc.Add(paragrafo3);
                    doc.Add(paragrafo4);                   
                    doc.Add(vx1rd);
                    doc.Add(vx2rd);
                    doc.Add(paragrafo5);
                    doc.Add(paragrafo6);

                    
                }

                if (pai.cb_vyrd.Checked) //Imprime cortante Y
                {
                    //Titulo
                    Paragraph paragrafo2 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Bold));
                    paragrafo2.Alignment = Element.ALIGN_CENTER;
                    paragrafo2.Add("DIMENSIONAMENTO A CORTANTE - EIXO Y \n\n");
                }

                if (pai.cb_mxrd.Checked) //Imprime momento x
                {
                    //Titulo
                    Paragraph paragrafo2 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Bold));
                    paragrafo2.Alignment = Element.ALIGN_CENTER;
                    paragrafo2.Add("DIMENSIONAMENTO A MOMENTO FLETOR - EIXO X \n\n");
                }

                if (pai.cb_myrd.Checked) //Imprime momento y
                {
                    //Titulo
                    Paragraph paragrafo2 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Bold));
                    paragrafo2.Alignment = Element.ALIGN_CENTER;
                    paragrafo2.Add("DIMENSIONAMENTO A MOMENTO FLETOR - EIXO Y \n\n");
                }

                System.Diagnostics.Process.Start(dir + @"\memorial.pdf");
                doc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
    }
}


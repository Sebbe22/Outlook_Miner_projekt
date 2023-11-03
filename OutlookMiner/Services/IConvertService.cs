using ceTe.DynamicPDF.PageElements;
using ceTe.DynamicPDF;
using OutlookMiner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.PortableExecutable;
using iTextSharp.text.pdf.parser;
using iTextSharp.text.pdf;

namespace OutlookMiner.Services
{
    public interface IConvertService
    {
        void Convert(string saveFilePath, List<Text> mails);
    }

    public class ConvertServicePDF : IConvertService
    {
        public void Convert(string saveFilePath, List<Text> mails)
        {
            ceTe.DynamicPDF.Document document = new ceTe.DynamicPDF.Document();

            string labelText = "";
            foreach (Text txt in mails)
            {
                labelText = labelText + $" \n \n {txt.body}";
            }

            FormattedTextArea text = new FormattedTextArea(labelText, 0, 0, 504, 600, ceTe.DynamicPDF.FontFamily.Helvetica, 12, true);

            while (text != null)
            {
                ceTe.DynamicPDF.Page page = new ceTe.DynamicPDF.Page();
                document.Pages.Add(page);
                page.Elements.Add(text);
                text = text.GetOverflowFormattedTextArea();
            }

            document.Draw(saveFilePath);
        }

        public string ExtractTextFromPdf(string path)
        {
            ITextExtractionStrategy its = new iTextSharp.text.pdf.parser.LocationTextExtractionStrategy();

            using (PdfReader reader = new PdfReader(path))
            {
                StringBuilder text = new StringBuilder();

                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    string thePage = PdfTextExtractor.GetTextFromPage(reader, i, its);
                    string[] theLines = thePage.Split('\n');
                    foreach (var theLine in theLines)
                    {
                        text.AppendLine(theLine);
                    }
                }
                return text.ToString();
            }
        }
    }
}

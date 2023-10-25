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
                labelText = labelText + $" \n \n {txt.text}";
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
    }
}

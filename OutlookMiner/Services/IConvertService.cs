﻿using ceTe.DynamicPDF.PageElements;
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
        void ConvertIndividualText(string saveFilePath, List<IndividualMailText> mails);
        void ConvertJson(string saveFilePath, string JsonFormat);
        void ConvertThreads( string saveFilePath, List<ThreadModel> mails);

    }

    public class ConvertServicePDF : IConvertService
    {
        public void ConvertJson(string saveFilePath, string JsonFormat)
        {
            ceTe.DynamicPDF.Document document = new ceTe.DynamicPDF.Document();

            string labelText = "";
        
                labelText = labelText + $" \n \n {JsonFormat}";
            

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
        public void ConvertIndividualText(string saveFilePath, List<IndividualMailText> mails)
        {
            ceTe.DynamicPDF.Document document = new ceTe.DynamicPDF.Document();

            string labelText = "";
            foreach (Text txt in mails)
            {
                labelText = labelText + $" \n {txt.body}";
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

        public void ConvertThreads(string saveFilePath, List<ThreadModel> mails)
        {
            ceTe.DynamicPDF.Document document = new ceTe.DynamicPDF.Document();

            string labelText = "";

            foreach (ThreadModel thread in mails)
            {
                labelText += $"\n\n{thread.ThreadID}\n\n";

                foreach (var message in thread.Messages)
                {
                    labelText += $"Labels: {string.Join(", ", message.Labels)}\n\n";
                    message.Message.body = string.Join("\n", message.Message.body.Split('\n').Where(line => !string.IsNullOrWhiteSpace(line)));
                    labelText += $"{message.Message.body}\n\n";
                }
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

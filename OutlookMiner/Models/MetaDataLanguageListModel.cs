using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookMiner.Models
{
    public class MetaDataLanguageListModel
    {
        public string Language { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Sent { get; set; }
        public string Subject { get; set; }

        public MetaDataLanguageListModel(string language, string from, string to, string sent, string subject)
        {
            Language = language;
            From = from;
            To = to;
            Sent = sent;
            Subject = subject;
        }
        public static List<MetaDataLanguageListModel> Languages = new List<MetaDataLanguageListModel>
        {
        new MetaDataLanguageListModel("GB", "From", "To", "Sent", "Subject"),
        new MetaDataLanguageListModel("DK", "Fra", "Til", "Sendt", "Emne"),
         //Load fra Json
        };
       
    }

}


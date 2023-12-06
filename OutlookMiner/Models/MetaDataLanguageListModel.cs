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
            new MetaDataLanguageListModel("ZA", "Van", "Om", "Gestuur", "Onderwerp"),
            new MetaDataLanguageListModel("AL", "Nga", "te", "Dërguar", "Subjekti"),
            new MetaDataLanguageListModel("FR", "Depuis", "Jusqu'à", "Envoyer", "Sujet"),
            new MetaDataLanguageListModel("DE", "Aus", "Zu", "Gesendet", "Thema"),
            new MetaDataLanguageListModel("ES", "De", "A", "Enviado", "Asunto"), 
            new MetaDataLanguageListModel("SE", "Från", "Till", "Skickat", "Ämne"),
            new MetaDataLanguageListModel("NO", "Fra", "Til", "Sendt", "Emne"),
            new MetaDataLanguageListModel("PL", "Od", "Do", "Wysłano", "Temat"), 
            new MetaDataLanguageListModel("FI", "Lähettäjä", "Vastaanottaja", "Lähetetty", "Aihe"),
            new MetaDataLanguageListModel("RU", "От", "Кому", "Отправлено", "Тема")

        };
       
    }

}


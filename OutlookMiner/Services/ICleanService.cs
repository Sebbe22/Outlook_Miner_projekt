using OutlookMiner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OutlookMiner.Services
{
    public interface ICleanService
    {
        List<Text> RemoveLinksFromEmailString(List <Text> mails);
    }

    public class CleanService : ICleanService
    {
        public List<Text> RemoveLinksFromEmailString(List<Text> mails)
        {
            foreach(Text mail in mails)
            {
                // (?:<https?|<www|\bhttps?|\bwww)\S*?(?=\s|>)(?:>)?
                string pattern = @"(<\w+:\/\/\S+>|www\.\w+\.\w+(?:\.\w+)?|\w+\.\w+\.\w+(?:\.\w+)?|\w+:\/\/\S+|<\w+\.\w+\.\w+(?:\.\w+)?>)";

                mail.text = Regex.Replace(mail.text, pattern, string.Empty);

                return mails;
            }
            return null;
        }

        public string RemoveEmailsFromEmailString(string emailString)
        {
            string pattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}";

            string result = Regex.Replace(emailString, pattern, string.Empty);

            return result;
        }

        public string RemoveSenderNameFromEmail(string senderName, string emailString)
        {
            return "";
        }
    }

}

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

        List<Text> RemoveEmailsFromEmailString(List<Text> emailString);
    }

    public class CleanService : ICleanService
    {
        /// <summary>
        /// uses regular expressions to detect and remove links from a string
        /// </summary>
        /// <param name="mails">the list of mails/strings from which links will be removed</param>
        /// <returns>returns the same list but with links removed</returns>
        public List<Text> RemoveLinksFromEmailString(List<Text> mails)
        {
            foreach(Text mail in mails)
            {
                string pattern = @"(<\w+:\/\/\S+>|www\.\w+\.\w+(?:\.\w+)?|\w+\.\w+\.\w+(?:\.\w+)?|\w+:\/\/\S+|<\w+\.\w+\.\w+(?:\.\w+)?>)";

                mail.body = Regex.Replace(mail.body, pattern, string.Empty);
            }
            return mails;
        }

        public List<Text> RemoveEmailsFromEmailString(List<Text> emailString)
        {
            // [a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}
            string pattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]+";

            foreach(Text email in emailString)
            {
                email.body = Regex.Replace(email.body, pattern, string.Empty);
            }
            return emailString;
        }

        public string RemoveSenderNameFromEmail(string senderName, string emailString)
        {
            return "";
        }
    }

}

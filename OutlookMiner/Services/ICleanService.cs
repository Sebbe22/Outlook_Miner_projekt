using Org.BouncyCastle.Crypto.Tls;
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

        List<Text> RemoveSenderAndRecieverNameFromEmail(List<Text> emailString);
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
                string pattern = @"(<\w+:\/\/\S+>|www\.\w+\.\w+(?:\.\w+)?|\w+\.\w+\.
                S\w+(?:\.\w+)?|\w+:\/\/\S+|<\w+\.\w+\.\w+(?:\.\w+)?>)";
                if (mail.body != null){

                    mail.body = Regex.Replace(mail.body, pattern, string.Empty);
                }
            }
            return mails;
        }

        /// <summary>
        /// detects and removes emails from a string using regular expressions 
        /// </summary>
        /// <param name="emailString"> list of mails to be cleaned </param>
        /// <returns>returns the cleaned list where emails are removed.</returns>
        public List<Text> RemoveEmailsFromEmailString(List<Text> emailString)
        {
            string pattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]+";
        

            foreach(Text email in emailString)
            {
                if(email.body != null)
                {
                    email.body = Regex.Replace(email.body, pattern, string.Empty);
                }
               
            }
            return emailString;
        }

        /// <summary>
        /// removes both recipipents and senders names from the email string.
        /// </summary>
        /// <param name="emailString"> the list of emails from which names will be removed </param>
        /// <returns> returns a list of emails where names has been removed </returns>
        public List<Text> RemoveSenderAndRecieverNameFromEmail(List<Text> emailString)
        {
            // removes senders name
            foreach (Text email in emailString)
            {
                string sirName = email.sender.Split(" ")[0];
                string lastName = email.sender.Split(" ")[1];

                email.body = email.body.Replace(sirName.ToLower(), "");
                email.body = email.body.Replace(lastName.ToLower(), "");
                email.body = email.body.Replace(email.sender.ToLower(), "");
            }

            // removes recievers name
            foreach (Text email in emailString)
            {
                for (int i = 0; i < email.recipients.Count; i++)
                {   
                    string sirName = email.recipients[i].Split(" ")[0];
                    string lastName = email.recipients[i].Split(" ")[1];

                    email.body = email.body.Replace(sirName.ToLower(), "");
                    email.body = email.body.Replace(lastName.ToLower(), "");
                    email.body = email.body.Replace(email.recipients[i].ToLower(), "");
                }
            }
            return emailString;
        }
    }

}

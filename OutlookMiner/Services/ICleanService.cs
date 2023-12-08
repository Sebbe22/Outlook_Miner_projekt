using iTextSharp.xmp.impl;
using Org.BouncyCastle.Crypto.Tls;
using OutlookMiner.Models;
using PhoneNumbers;
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
        List<IndividualMailText> RemoveLinksFromEmailString(List<IndividualMailText> mails);

        List<IndividualMailText> RemoveEmailsFromEmailString(List<IndividualMailText> emailString);

        List<IndividualMailText> RemoveSenderAndRecieverNameFromEmail(List<IndividualMailText> emailString);

        List<IndividualMailText> RemovePhoneNumbersFromEmail(List<IndividualMailText> emailString);

        List<IndividualMailText> RemovePasswordAndUserNameFromEmail(List<IndividualMailText> emailString);
    }

    public class CleanService : ICleanService
    {

        public List<IndividualMailText> RemoveLinksFromEmailString(List<IndividualMailText> mails)
        {
            foreach(Text mail in mails)
            {
                string pattern = @"(<\w+:\/\/\S+>|www\.\w+\.\w+(?:\.\w+)?|\w+\.\w+\.
                S\w+(?:\.\w+)?|\w+:\/\/\S+|<\w+\.\w+\.\w+(?:\.\w+)?>)";
                if (mail.body != null){

                    mail.body = Regex.Replace(mail.body, pattern, string.Empty);
                }
            }
            IDataAccessService dataAccessService = new DataAccessService();
            LabelModel test = new LabelModel(9, "det virker", "be happy");
            dataAccessService.Push("INSERT INTO Labels values(@Id, @Category, @LabelName)", test);

            return mails;
        }

        /// <summary>
        /// detects and removes emails from a string using regular expressions 
        /// </summary>
        /// <param name="emailString"> list of mails to be cleaned </param>
        /// <returns>returns the cleaned list where emails are removed.</returns>
        public List<IndividualMailText> RemoveEmailsFromEmailString(List<IndividualMailText> emailString)
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
        public List<IndividualMailText> RemoveSenderAndRecieverNameFromEmail(List<IndividualMailText> emailString)
        {
            // removes senders name
            foreach (Text email in emailString)
            {
                email.body = email.body.ToLower();

                if (email.sender != null)
                {
                    string[] splitNameArray = email.sender.Split(" ");

                    if (email.body != null && email.sender.Length >= 1)
                    {
                        foreach (string name in splitNameArray)
                        {
                            email.body = email.body.Replace(name.ToLower(), "");
                        }
                    }
                }
            }

            // removes recievers name
            foreach (Text email in emailString)
            {
                email.body = email.body.ToLower();
                for (int i = 0; i < email.recipients.Count; i++)
                {
                    string[] splitNameArray = email.recipients[i].Split(" ");

                    if(email.body != null)
                    {
                        foreach (string name in splitNameArray)
                        {
                            email.body = email.body.Replace(name.ToLower(), "");
                        }
                    }
                }
            }
            return emailString;
        }

        public List<IndividualMailText> RemovePhoneNumbersFromEmail(List<IndividualMailText> emailString)
        {
            PhoneNumberUtil phoneNumberUtil = PhoneNumberUtil.GetInstance();

            foreach(var email in emailString)
            {
                foreach (var language in MetaDataLanguageListModel.Languages)
                {
                    var matches = phoneNumberUtil.FindNumbers(email.body, language.Language);

                    if (matches != null && matches.Count() > 0)
                    {
                        foreach (var match in matches)
                        {
                            email.body = email.body.Replace(match.RawString, "");
                        }
                    }
                }
            };

            return emailString;
        }

        public List<IndividualMailText> RemovePasswordAndUserNameFromEmail(List<IndividualMailText> emailString)
        {
            foreach (var email in emailString)
            {
                if (email.body != null)
                {
                    string pattern = "(?i)(\\bPassword:\\s+|\\bUsername:\\s)[\"\\']?(\\w+)[\"\\']?";
                    email.body = Regex.Replace(email.body, pattern, "");
                }
            }

            return emailString;
        }
    }

}

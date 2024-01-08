using ceTe.DynamicPDF;
using iTextSharp.xmp.impl;
using OutlookMiner.Models;
using PhoneNumbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace OutlookMiner.Services
{


    public interface ICleanManualService
    {
        string AddIndicatorsToMail(string mailBody, string pattern);
        List<RemovedContentModel> FindSubstrings(string text);
        List<IndividualMailText> RemoveEmailsFromEmailString(List<IndividualMailText> mails);
        List<IndividualMailText> RemoveEverythingPastBestRegards(List<IndividualMailText> mails);
        List<IndividualMailText> RemoveLinksFromEmailString(List<IndividualMailText> mails);
        string DeleteStringsFromText(string text, List<RemovedContentModel> stringsToDelete);
        List<IndividualMailText> RemovePasswordAndUserNameFromEmail(List<IndividualMailText> emailString);
        public List<IndividualMailText> RemovePhoneNumbersFromEmail(List<IndividualMailText> emailString);
        List<IndividualMailText> RemoveSenderAndRecieverNameFromEmail(List<IndividualMailText> emailString);
    }

    public class CleanManualService : ICleanManualService
    {

        public List<IndividualMailText> RemoveLinksFromEmailString(List<IndividualMailText> mails)
        {
            foreach (IndividualMailText mail in mails)
            {
                string pattern = @"(<\w+:\/\/\S+>|www\.\w+\.\w+(?:\.\w+)?|\w+\.\w+\.\w\w+(?:\.\w+)?|\w+:\/\/\S+|<\w+\.\w+\.\w+(?:\.\w+)?>)";

                mail.body = AddIndicatorsToMail(mail.body, pattern);

            }

            return mails;

        }

        public List<IndividualMailText> RemoveEmailsFromEmailString(List<IndividualMailText> mails)
        {
            foreach (IndividualMailText mail in mails)
            {
                string pattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]+";
                mail.body = AddIndicatorsToMail(mail.body, pattern);
            }

            return mails;
        }

        public List<IndividualMailText> RemoveEverythingPastBestRegards(List<IndividualMailText> mails)
        {
            foreach (IndividualMailText mail in mails)
            {
                string pattern = @"(?i)Best regards([\s\S]+)";
                mail.body = AddIndicatorsToMail(mail.body, pattern);


            }
            return mails;
        }

        public string AddIndicatorsToMail(string mailBody, string pattern)
        {
            MatchEvaluator evaluator = new MatchEvaluator(match =>
            {
                string matchedValue = match.Value;

              
                if (!matchedValue.StartsWith("[") || !matchedValue.EndsWith("]"))
                {
                   
                    matchedValue = "[" + matchedValue + "]";
                }

                return matchedValue;
            });
            
            string modifiedPattern = @"(?<!\[.+?)" + pattern + @"(?![^\[]*?\])";

            mailBody = Regex.Replace(mailBody, modifiedPattern, evaluator);

            return mailBody;
        }


        public List<RemovedContentModel> FindSubstrings(string text)
        {
            List<RemovedContentModel> substrings = new List<RemovedContentModel>();
            int openBracketIndex;
            int closeBracketIndex;
            int startPos = 0;
            while (true)
            {
                openBracketIndex = text.IndexOf('[', startPos);
                closeBracketIndex = text.IndexOf(']', openBracketIndex + 1);

                if (openBracketIndex != -1 && closeBracketIndex != -1)
                {
                    string content = text.Substring(openBracketIndex + 1, closeBracketIndex - openBracketIndex - 1);
                    substrings.Add(new RemovedContentModel(content, openBracketIndex, closeBracketIndex));
                    startPos = closeBracketIndex + 1;


                }
                else
                {
                    break;
                }
            }

            return substrings;
        }

        public string DeleteStringsFromText(string text, List<RemovedContentModel> stringsToDelete)
        {
            foreach (RemovedContentModel str in stringsToDelete)
            {
                text = text.Replace("[" + str.Content + "]", string.Empty);
            }
            return text;
        }

        public List<IndividualMailText> RemovePasswordAndUserNameFromEmail(List<IndividualMailText> mails)
        {
            foreach (IndividualMailText mail in mails)
            {
                string pattern = "(?i)(\\bPassword:\\s+|\\bUsername:\\s)[\"\\']?(\\w+)[\"\\']?";
                mail.body = AddIndicatorsToMail(mail.body, pattern);
            }

            return mails;
        }

        public List<IndividualMailText> RemoveSenderAndRecieverNameFromEmail(List<IndividualMailText> mails)
        {
            foreach (Text mail in mails)
            {
                mail.body = mail.body.ToLower();

                if (mail.sender != null)
                {
                    string[] splitNameArray = mail.sender.Split(" ");

                    foreach (string name in splitNameArray)
                    {
                        string pattern = @"(?<!\[)" + Regex.Escape(name.ToLower()) + @"(?![^\]]*\])";
                        mail.body = Regex.Replace(mail.body, pattern, "[" + name.ToLower() + "]");
                    }
                }

                foreach (string recipient in mail.recipients)
                {
                    string[] splitNameArray = recipient.Split(" ");

                    foreach (string name in splitNameArray)
                    {
                        string pattern = @"(?<!\[)" + Regex.Escape(name.ToLower()) + @"(?![^\]]*\])";
                        mail.body = Regex.Replace(mail.body, pattern, "[" + name.ToLower() + "]");
                    }
                }
            }

            return mails;
        }


        public List<IndividualMailText> RemovePhoneNumbersFromEmail(List<IndividualMailText> emailString)
        {
            try
            {
                PhoneNumberUtil phoneNumberUtil = PhoneNumberUtil.GetInstance();
                DataAccessService dataAccessService = new DataAccessService();
                var languages = dataAccessService.Get<MetaDataLanguageListModel>("SELECT LanguageCode AS language FROM Languages");
                foreach (var email in emailString)
                {
                    foreach (var language in languages)
                    {
                        var matches = phoneNumberUtil.FindNumbers(email.body, language.Language);

                        if (matches != null && matches.Count() > 0)
                        {
                            foreach (var match in matches)
                            {
                                string phoneNumber = match.RawString;

                         
                                string pattern = @"(?<!\[.+?)" + Regex.Escape(phoneNumber) + @"(?![^\[]*?\])";

                           
                                if (Regex.IsMatch(email.body, pattern))
                                {
                                
                                    email.body = Regex.Replace(email.body, Regex.Escape(phoneNumber), "[" + phoneNumber + "]");
                                }
                            }
                        }
                    }
                }
                return emailString;
            }
            catch 
            {
                return emailString;

            }


           
        }
    }
}

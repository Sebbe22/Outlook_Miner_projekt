using OutlookMiner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OutlookMiner.Services
{

  
    public interface ICleanManualService
    {
        string AddIndicatorsToMail(string mailBody, string pattern);
        List<RemovedContentModel> FindSubstrings(string text);
        List<IndividualMailText> RemoveEmailsFromEmailString(List<IndividualMailText> mails);
        string RemoveEverythingPastBestRegards(string mailBody);
        List<IndividualMailText> RemoveLinksFromEmailString(List<IndividualMailText> mails);
        string DeleteStringsFromText(string text, List<RemovedContentModel> stringsToDelete);

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

        public string RemoveEverythingPastBestRegards(string mailBody)
        {
            string pattern = @"^(.*?)\bBest Regards\b.*$";
            mailBody = AddIndicatorsToMail(mailBody, pattern);
            return mailBody;
        }
        public string AddIndicatorsToMail(string mailBody, string pattern)
        {
            MatchEvaluator evaluator = new MatchEvaluator(match =>
            {
                return "[" + match.Value + "]";
            });

            mailBody = Regex.Replace(mailBody, pattern, evaluator);

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
                text = text.Replace("["+str.Content+"]", string.Empty);
            }
            return text;
        }
    }
}

using OutlookMiner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OutlookMiner.Services
{
    public class IEmailBasicInfoService
    {
        public List<Text> SeparateThreadsIntoMails(List<Text> mails)
        {
            List<Text> resultList = new List<Text>();

            // Define the pattern that includes the entire block
            string pattern = @"From:.*[\r\n]+Sent:.*[\r\n]+To:.*[\r\n]+Subject:.*";
            foreach (Text mail in mails)
            {
                // Use regular expressions to split the text based on the pattern
                string[] parts = Regex.Split(mail.body, pattern);

                // Assign a common ThreadID for all parts
                string currentThreadID = mail.threadID;

                foreach (string part in parts)
                {
                    // Remove empty lines and leading/trailing white spaces
                    string cleanedPart = string.Join("\n", part.Split('\n', StringSplitOptions.RemoveEmptyEntries)).Trim();

                    if (!string.IsNullOrEmpty(cleanedPart))
                    {
                        Text separatedMail = new Text(cleanedPart, currentThreadID);
                        resultList.Add(separatedMail);
                    }
                }
            }

            return resultList;
        }
        public int CountMessages(List<Text> mails)
        {
            int result = mails.Count;
            return result;
        }
        public int CountThreads(List<Text> mails)
        {
            int result = mails.Count;
            return result;
        }

    }
}

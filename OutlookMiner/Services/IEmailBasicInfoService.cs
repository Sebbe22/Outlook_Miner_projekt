using OutlookMiner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OutlookMiner.Services
{
    public interface IEmailBasicInfoService
    {
        /// <summary>
        /// Takes a list of IndividualMailText and Counts the instances
        /// </summary>
        /// <param name="mails"></param>
        /// <returns> int number of items in list</returns>
        int CountMessages(List<IndividualMailText> mails);

        /// <summary>
        /// Takes a list of Text and counts instances. 
        /// </summary>
        /// <param name="mails"></param>
        /// <returns>int number of items in list/returns>
        int CountThreads(List<Text> mails);

        /// <summary>
        /// Method takes a list of <Text> and splits it into separate messages with messagesID's.
        /// </summary>
        /// <param name="mails"></param>
        /// <returns>List of IndividualMailText</returns>
        List<IndividualMailText> SeparateThreadsIntoMails(List<Text> mails);
    }

    public class EmailBasicInfoService : IEmailBasicInfoService
    {
        public List<IndividualMailText> SeparateThreadsIntoMails(List<Text> mails)
        {
            List<IndividualMailText> resultList = new List<IndividualMailText>();
            int mailId;
            // Define the pattern that includes the entire block
            string pattern = @"From:.*[\r\n]+Sent:.*[\r\n]+To:.*[\r\n]+Subject:.*";
            foreach (Text mail in mails)
            {
                mailId = 1;
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

                        IndividualMailText separatedMail = new IndividualMailText(cleanedPart, currentThreadID, mailId);
                        resultList.Add(separatedMail);
                        mailId++;
                    }
                }
            }

            return resultList;
        }
        public int CountMessages(List<IndividualMailText> mails)
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

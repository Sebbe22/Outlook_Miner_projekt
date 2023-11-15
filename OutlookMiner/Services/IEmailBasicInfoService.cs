using ceTe.DynamicPDF;
using OutlookMiner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.util;
using static System.Net.Mime.MediaTypeNames;
using Text = OutlookMiner.Models.Text;

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
        /// <summary>
        /// Method takes a list of mails, loops through and if there are more occurences of one thread it takes the newest based on time.
        /// </summary>
        /// <param name="mails"></param>
        /// <returns>A list of Text</returns>
        List<Text> RemoveDuplicateThreads(List<Text> mails);
    }

    public class EmailBasicInfoService : IEmailBasicInfoService
    {
        public List<Text> RemoveDuplicateThreads(List<Text> mails)
        {
            var groupedMails = mails.GroupBy(m => m.threadID);

            foreach (var group in groupedMails)
            {
                if (group.Count() > 1)
                {
                    var newestText = group.OrderByDescending(m => m.recievedTime).First();

                    foreach (var text in group)
                    {
                        if (text != newestText)
                        {
                            mails.Remove(text);
                            
                        }
                    }
                }
            }

            return mails;
        }
        private List<string> ExtractInformationBetweenMatches(string text, string pattern)
        {
            // Create a regex object
            Regex regex = new Regex(pattern);

            // Find all matches in the text
            MatchCollection matches = regex.Matches(text);

            // Initialize a list to store the extracted information
            List<string> result = new List<string>();

            // Capture the text before the first match
            int start = 0;
            int end = matches.Count > 0 ? matches[0].Index : 0;
            string beforeFirstMatch = text.Substring(start, end).Trim();
            result.Add(beforeFirstMatch);

            // Iterate through the matches
            foreach (Match match in matches)
            {
                // Extract the start and end positions of the match
                start = match.Index + match.Length;
                end = (match.NextMatch().Success ? match.NextMatch().Index : text.Length) - start;

                // Extract the information between matches
                string infoBetween = text.Substring(start, end).Trim();

                // Append the extracted information to the result list
                result.Add(infoBetween);
            }


            return result;
        }

        public List<IndividualMailText> SeparateThreadsIntoMails(List<Text> mails)
        {
            List<IndividualMailText> resultList = new List<IndividualMailText>();
            //Step 1, define regex pattern
            string fromPart = "(";
            string sentPart = @"):[^\r\n]*[\r\n]+(";
            string toPart = @"):[\s\S]*?[\r\n]+(";
            string subjectPart = @"):[\s\S]*?[\r\n]+(";
            string endPart =  @"):[\s\S]*?[\r\n](.*)";
            foreach (var language in MetaDataLanguageListModel.Languages)
            {
                fromPart = fromPart + language.From + "|";
                sentPart = sentPart + language.Sent + "|";
                toPart = toPart + language.To + "|";
                subjectPart = subjectPart + language.Subject + "|";
                
            }
            string pattern = fromPart + sentPart + toPart + subjectPart + endPart;
            //Step 2
            Regex regex = new Regex(pattern);
            foreach (Text mail in mails)
            {
                if (regex.IsMatch(mail.body))
                {
                    List<string> result = ExtractInformationBetweenMatches(mail.body, pattern);

                    // Print the result for each string
                    for (int i = 0; i < result.Count; i++)
                    {
                       
                            IndividualMailText individualMail = new IndividualMailText(result[i], mail.threadID, i + 1);
                            individualMail.sender = mail.sender;
                            individualMail.senderEmail = mail.senderEmail;
                            individualMail.recipients = mail.recipients;
                            resultList.Add(individualMail);

                    }
                   

                }
                else
                {

                    resultList.Add(new IndividualMailText(mail.body, mail.threadID, 1));
                }
                

            }
            return resultList;

        }
        public int CountMessages(List<IndividualMailText> mails)
        {
            if(mails != null)
            {
                int result = mails.Count;
                return result;

            }
            return 0;
        }
        public int CountThreads(List<Text> mails)
        {
            if (mails != null)
            {
                int result = mails.Count;
                return result;
            }
            return 0;
        }

    }
}

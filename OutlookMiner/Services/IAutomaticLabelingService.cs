using OutlookMiner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookMiner.Services
{
    public interface IAutomaticLabelingService
    {
        void AddSystemKeyword(string system, string keyword);
        List<IndividualMailTextLabelingModel> CheckForSystems(List<IndividualMailText> mails);
        void DeleteSystemKeyword(string system, string keyword);
    }

    public class AutomaticLabelingService : IAutomaticLabelingService
    {

        private readonly Dictionary<string, List<string>> systemKeywords;

        public AutomaticLabelingService()
        {
            // Initialize the dictionary in the constructor
            systemKeywords = new Dictionary<string, List<string>>();
            //Needs to be deleted
            AddSystemKeyword("EMS", "EMS");
            AddSystemKeyword("Valsuite", "Valsuite");

        }
        public void AddSystemKeyword(string system, string keyword)
        {
            if (systemKeywords.ContainsKey(system))
            {
                // If the system already exists, add the keyword to its list
                if (!systemKeywords[system].Contains(keyword))
                {
                    systemKeywords[system].Add(keyword);
                }
            }
            else
            {
                // If the system doesn't exist, create a new entry with the keyword
                systemKeywords[system] = new List<string> { keyword };
            }
        }

        public void DeleteSystemKeyword(string system, string keyword)
        {
            if (systemKeywords.ContainsKey(system))
            {
                // Remove the keyword if it exists under the system
                systemKeywords[system].Remove(keyword);

                // If the system has no more keywords, remove the system entry
                if (systemKeywords[system].Count == 0)
                {
                    systemKeywords.Remove(system);
                }
            }
        }

        public List<IndividualMailTextLabelingModel> CheckForSystems(List<IndividualMailText> mails)
        {
            List<IndividualMailTextLabelingModel> labeledMails = new List<IndividualMailTextLabelingModel>();

            foreach (IndividualMailText mail in mails)
            {
                List<string> labels = new List<string>();

                foreach (var system in systemKeywords)
                {
                    if (system.Value.Any(keyword => mail.body.Contains(keyword)))
                    {
                        labels.Add(system.Key);
                    }
                }

                labeledMails.Add(new IndividualMailTextLabelingModel(mail, labels));
            }

            return labeledMails;
        }

    }

}


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
        List<IndividualMailTextLabelingModel> CheckForSystems(List<IndividualMailText> mails);
    }

    public class AutomaticLabelingService : IAutomaticLabelingService
    {

        private readonly Dictionary<string, List<string>> systemKeywords  = new Dictionary<string, List<string>>();
        ILabelService labelService;

        public AutomaticLabelingService()
        {
            labelService =  new LabelService();
            List<LabelModel> labelModels = new List<LabelModel>(labelService.GetLabels());
           
            systemKeywords = labelModels
            .GroupBy(l => l.LabelName)
            .ToDictionary(
            grp => grp.Key,
            grp => grp.Select(x => x.SearchWord).ToList()
            );

        }


        public List<IndividualMailTextLabelingModel> CheckForSystems(List<IndividualMailText> mails)
        {
            List<IndividualMailTextLabelingModel> labeledMails = new List<IndividualMailTextLabelingModel>();

            Dictionary<string, List<string>> threadLabels = new Dictionary<string, List<string>>();

            foreach (IndividualMailText mail in mails)
            {
                List<string> labels = new List<string>();

                foreach (var system in systemKeywords)
                {
                    if (system.Value != null) // Check if the list of keywords is not null
                    {
                        foreach (var keyword in system.Value)
                        {
                            if (!string.IsNullOrEmpty(keyword) && mail.body.Contains(keyword))
                            {
                                labels.Add(system.Key);
                            }
                        }
                    }
                }

                if (!threadLabels.ContainsKey(mail.threadID))
                {
                    threadLabels[mail.threadID] = new List<string>();
                }

                threadLabels[mail.threadID].AddRange(labels);

          
                labeledMails.Add(new IndividualMailTextLabelingModel(mail, labels));
            }

        
            foreach (var labeledMail in labeledMails)
            {
                if (threadLabels.ContainsKey(labeledMail.Message.threadID))
                {
                    List<string> threadLabelsWithoutDuplicates = threadLabels[labeledMail.Message.threadID].Distinct().ToList();
                    labeledMail.Labels.AddRange(threadLabelsWithoutDuplicates.Except(labeledMail.Labels));
                }
            }

            return labeledMails;
        }


    }

}


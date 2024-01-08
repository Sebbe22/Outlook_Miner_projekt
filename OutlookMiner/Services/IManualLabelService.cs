using OutlookMiner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OutlookMiner.Services
{
    public interface IManualLabelService
    {
        IndividualMailTextLabelingModel AddMessageWithLabels( IndividualMailText message, List<string> labels);
        List<ThreadModel> CreateThreads(List<IndividualMailTextLabelingModel> messages);

    }

    public class ManualLabelService : IManualLabelService
    {
        private List<string> labels;


      
        public ManualLabelService()
        {
        }


        public List<string> Labels
        {
            get { return labels; }
            set { labels = value; }
        }
        public List<ThreadModel> CreateThreads(List<IndividualMailTextLabelingModel> messages)
        {
            
            var groupedMessages = messages
                .GroupBy(msg => msg.Message.threadID)
                .Select(group => new ThreadModel
                {
                    ThreadID = group.Key,
                    Messages = group.OrderBy(msg => msg.Message.messageID).ToList()
                })
                .ToList();

            return groupedMessages;
        }

        public IndividualMailTextLabelingModel AddMessageWithLabels(IndividualMailText message, List<string> labels)
        {
            IndividualMailTextLabelingModel newMessage = new IndividualMailTextLabelingModel(message, labels);

            return newMessage;
        }
    }
}

   

       


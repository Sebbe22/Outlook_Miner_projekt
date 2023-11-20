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
        List<String> Labels { get; set; }
    }

    public class ManualLabelService : IManualLabelService
    {
        private List<string> labels;
        private static ManualLabelService instance;

        // Private constructor to prevent external instantiation
        private ManualLabelService()
        {
            // Initialize the list of labels
            labels = new List<string> { "Label 1", "Label 2", "Label 3" };
        }
        public static ManualLabelService GetInstance()
        {
            if (instance == null)
            {
                instance = new ManualLabelService();
            }
            return instance;
        }

        public List<string> Labels
        {
            get { return labels; }
            set { labels = value; }
        }
        public List<ThreadModel> CreateThreads(List<IndividualMailTextLabelingModel> messages)
        {
            // Group messages by ThreadID
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

   

       


using Newtonsoft.Json;
using OutlookMiner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;

namespace OutlookMiner.Services
{
    
    public interface IManualLabelingService
    {
        IndividualMailTextLabelingModel AddMessageWithLabels( IndividualMailText message, List<string> labels);
        List<ThreadModel> CreateThreads(List<IndividualMailTextLabelingModel> messages);
        String ConvertToJson(List<ThreadModel> threadModels);
       
        List<String> Labels { get; set; }
    }

    public class ManualLabelingService : IManualLabelingService
    {
        private List<string> labels;
        private static ManualLabelingService instance;

        // Private constructor to prevent external instantiation
        private ManualLabelingService()
        {
            // Initialize the list of labels
            labels = new List<string> { "Label 1", "Label 2", "Label 3" };
        }
        public static ManualLabelingService GetInstance()
        {
            if (instance == null)
            {
                instance = new ManualLabelingService();
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
                .GroupBy(msg => msg.message.threadID)
                .Select(group => new ThreadModel
                {
                    ThreadID = group.Key,
                    Messages = group.OrderBy(msg => msg.message.messageID).ToList()
                })
                .ToList();

            return groupedMessages;
        }

        public IndividualMailTextLabelingModel AddMessageWithLabels( IndividualMailText message, List<string> labels)
        {
            string body = message.body;
            string threadID = message.threadID;
            int messageID = message.messageID;
            IndividualMailTextLabelingModel newMessage = new IndividualMailTextLabelingModel(body, threadID, messageID);
            newMessage.Labels = labels;
            

            return newMessage;
        }

        public string ConvertToJson(List<ThreadModel> threadModels)
        {
            string jsonThreads = JsonConvert.SerializeObject(threadModels, Formatting.Indented);
            return jsonThreads;
        }
    }
}

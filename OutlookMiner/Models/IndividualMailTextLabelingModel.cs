using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookMiner.Models
{
    public class IndividualMailTextLabelingModel 
    {
            public IndividualMailText message { get; set; } // Composition

            public List<string> Labels { get; set; }

            public IndividualMailTextLabelingModel(string body, string threadID, int messageID)
            {
                message = new IndividualMailText(body, threadID, messageID);
            }
    }
}

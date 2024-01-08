using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookMiner.Models
{
    /// <summary>
    /// Represents a model for a mail thread.
    /// </summary>
    public class ThreadModel
    {
        /// <summary>
        /// Gets or sets the ID of the mail thread.
        /// </summary>
        public string ThreadID { get; set; }

        /// <summary>
        /// Gets or sets the list of messages within the mail thread.
        /// </summary>
        public List<IndividualMailTextLabelingModel> Messages { get; set; }

        /// <summary>
        /// Initializes a new instance of the ThreadModel class.
        /// </summary>
        public ThreadModel()
        {
            Messages = new List<IndividualMailTextLabelingModel>();
        }
    }
}

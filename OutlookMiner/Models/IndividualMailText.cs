using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookMiner.Models
{
    /// <summary>
    /// Represents individual mail text extending a base text class.
    /// </summary>
    public class IndividualMailText : Text
    {
        /// <summary>
        /// Gets or sets the ID of the message.
        /// </summary>
        public int messageID { get; set; }

        /// <summary>
        /// Gets or sets the list of removed content models.
        /// </summary>
        public List<RemovedContentModel> removedContent { get; set; }

        /// <summary>
        /// Initializes a new instance of the IndividualMailText class with body, thread ID, and message ID.
        /// </summary>
        /// <param name="_body">The body content of the mail.</param>
        /// <param name="_threadID">The thread ID associated with the mail.</param>
        /// <param name="_messageID">The ID of the message.</param>
        public IndividualMailText(string _body, string _threadID, int _messageID) : base(_body, _threadID)
        {
            this.messageID = _messageID;
        }
    }
}

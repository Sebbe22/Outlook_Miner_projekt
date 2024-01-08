using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookMiner.Models
{
    /// <summary>
    /// Represents a basic text message.
    /// </summary>
    public class Text
    {
        /// <summary>
        /// Gets or sets the body of the text.
        /// </summary>
        public string body { get; set; }

        /// <summary>
        /// Gets or sets the thread ID associated with the text.
        /// </summary>
        public string threadID { get; set; }

        /// <summary>
        /// Gets or sets the sender of the text.
        /// </summary>
        public string sender { get; set; }

        /// <summary>
        /// Gets or sets the sender's email address.
        /// </summary>
        public string senderEmail { get; set; }

        /// <summary>
        /// Gets or sets the received time of the text.
        /// </summary>
        public DateTime recievedTime { get; set; }

        /// <summary>
        /// Gets or sets the list of recipients of the text.
        /// </summary>
        public List<string> recipients { get; set; } = new List<string>();

        /// <summary>
        /// Initializes a new instance of the Text class with body and thread ID.
        /// </summary>
        /// <param name="_body">The body content of the text.</param>
        /// <param name="_threadID">The thread ID associated with the text.</param>
        public Text(string _body, string _threadID)
        {
            this.body = _body;
            this.threadID = _threadID;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookMiner.Models
{
    /// <summary>
    /// Represents a model for metadata of a language list.
    /// </summary>
    public class MetaDataLanguageListModel
    {
        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// Gets or sets the sender.
        /// </summary>
        public string From { get; set; }

        /// <summary>
        /// Gets or sets the recipient.
        /// </summary>
        public string To { get; set; }

        /// <summary>
        /// Gets or sets the sent date.
        /// </summary>
        public string Sent { get; set; }

        /// <summary>
        /// Gets or sets the subject.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Initializes a new instance of the MetaDataLanguageListModel class with metadata details.
        /// </summary>
        /// <param name="language">The language.</param>
        /// <param name="from">The sender.</param>
        /// <param name="to">The recipient.</param>
        /// <param name="sent">The sent date.</param>
        /// <param name="subject">The subject.</param>
        public MetaDataLanguageListModel(string language, string from, string to, string sent, string subject)
        {
            Language = language;
            From = from;
            To = to;
            Sent = sent;
            Subject = subject;
        }

        /// <summary>
        /// Initializes a new instance of the MetaDataLanguageListModel class with language information.
        /// </summary>
        /// <param name="language">The language.</param>
        public MetaDataLanguageListModel(string language)
        {
            Language = language;
        }
    }

}


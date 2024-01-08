using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookMiner.Models
{
    /// <summary>
    /// Represents a model for removed content.
    /// </summary>
    public class RemovedContentModel
    {
        /// <summary>
        /// Gets or sets the content that was removed.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets the original start index of the removed content.
        /// </summary>
        public int OriginalStartIndex { get; set; }

        /// <summary>
        /// Gets or sets the original end index of the removed content.
        /// </summary>
        public int OriginalEndIndex { get; set; }

        /// <summary>
        /// Initializes a new instance of the RemovedContentModel class with removed content details.
        /// </summary>
        /// <param name="_content">The content that was removed.</param>
        /// <param name="_originalStartIndex">The original start index of the removed content.</param>
        /// <param name="_originalEndIndex">The original end index of the removed content.</param>
        public RemovedContentModel(string _content, int _originalStartIndex, int _originalEndIndex)
        {
            Content = _content;
            OriginalEndIndex = _originalEndIndex;
            OriginalStartIndex = _originalStartIndex;
        }
    }
}

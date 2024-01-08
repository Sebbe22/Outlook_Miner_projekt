using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookMiner.Models
{
    /// <summary>
    /// Represents a model containg list of labels and a individualMailText object
    /// </summary>
    public class IndividualMailTextLabelingModel
    {
        /// <summary>
        /// Gets or sets the individual mail text.
        /// </summary>
        public IndividualMailText Message { get; set; }

        /// <summary>
        /// Gets or sets the list of labels associated with the mail text.
        /// </summary>
        public List<string> Labels { get; set; }

        /// <summary>
        /// Initializes a new instance of the IndividualMailTextLabelingModel class.
        /// </summary>
        /// <param name="_message">The individual mail text to label.</param>
        /// <param name="_labels">The list of labels associated with the mail text.</param>
        public IndividualMailTextLabelingModel(IndividualMailText _message, List<string> _labels)
        {
            Message = _message;
            Labels = _labels;
        }
    }
}

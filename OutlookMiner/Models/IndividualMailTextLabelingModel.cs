using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookMiner.Models
{
    public class IndividualMailTextLabelingModel
    {
        public IndividualMailText Message { get; set; }
        public List<string> Labels { get; set; }

        public IndividualMailTextLabelingModel(IndividualMailText _message, List<string> _labels)
        {
            Message = _message;
            Labels = _labels;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookMiner.Models
{
    public class ThreadModel
    {
        public string ThreadID { get; set; }
        public List<IndividualMailTextLabelingModel> Messages { get; set; }
    }
}

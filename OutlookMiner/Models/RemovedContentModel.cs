using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookMiner.Models
{
    public class RemovedContentModel
    {
        

        public string Content { get; set; }
        public int OriginalStartIndex { get; set; }
        public int OriginalEndIndex { get; set; }

        public RemovedContentModel(string _content, int _originalStartIndex, int _originalEndIndex)
        {
            Content = _content;
            OriginalEndIndex = _originalEndIndex;
            OriginalStartIndex = _originalStartIndex;
        }
    }
}

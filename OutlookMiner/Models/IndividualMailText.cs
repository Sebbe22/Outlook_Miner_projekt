using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookMiner.Models
{
    public class IndividualMailText : Text
    {

        public int messageID { get; set; }

        public IndividualMailText(string _body, string _threadID, int _messageID) : base(_body, _threadID)
        {
            this.messageID = _messageID;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookMiner.Models
{
    public class PositionList
    {
        public int OpenIndex;
        public int CloseIndex;

       public PositionList(int openIndex, int closeIndex)
        {
            OpenIndex = openIndex;
            CloseIndex = closeIndex;
        }
    }
}

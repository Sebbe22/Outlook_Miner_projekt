using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookMiner.Models
{
    public class CheckBoxModel
    {
        public string methodName { get; set; }
        public bool isChecked { get; set; }

        public CheckBoxModel(string MethodName, bool IsChecked) 
        {
            methodName = MethodName;
            isChecked = IsChecked;
        }
    }
}

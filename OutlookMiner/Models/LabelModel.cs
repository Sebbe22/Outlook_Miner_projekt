using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookMiner.Models
{
    public class LabelModel
    {
        public int Id { get; set; } 
        public string Category { get; set; }
        public string LabelName { get; set; }

        public LabelModel(int id, string category, string labelName) 
        {
            Id = id;
            Category = category;
            LabelName = labelName;
        }

        public LabelModel(string category, string labelName)
        {
            Category = category;
            LabelName = labelName;
        }

        public LabelModel() { }

        public override string ToString()
        {
            return $"ID: {Id}, Category: {Category}, labelName: {LabelName}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookMiner.Models
{
    /// <summary>
    /// Represents a model for a label.
    /// </summary>
    public class LabelModel
    {
        /// <summary>
        /// Gets or sets the ID of the label.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the category of the label.
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets the name of the label.
        /// </summary>
        public string LabelName { get; set; }

        /// <summary>
        /// Gets or sets the search word associated with the label.
        /// </summary>
        public string SearchWord { get; set; }

        /// <summary>
        /// Initializes a new instance of the LabelModel class with specified parameters.
        /// </summary>
        /// <param name="id">The ID of the label.</param>
        /// <param name="category">The category of the label.</param>
        /// <param name="labelName">The name of the label.</param>
        /// <param name="searchWord">The search word associated with the label.</param>
        public LabelModel(int id, string category, string labelName, string searchWord)
        {
            Id = id;
            Category = category;
            LabelName = labelName;
            SearchWord = searchWord;
        }

        /// <summary>
        /// Initializes a new instance of the LabelModel class with specified parameters.
        /// </summary>
        /// <param name="category">The category of the label.</param>
        /// <param name="labelName">The name of the label.</param>
        /// <param name="searchWord">The search word associated with the label.</param>
        public LabelModel(string category, string labelName, string searchWord)
        {
            Category = category;
            LabelName = labelName;
            SearchWord = searchWord;
        }

        /// <summary>
        /// Initializes a new instance of the LabelModel class.
        /// </summary>
        public LabelModel() { }

        /// <summary>
        /// Returns a string representation of the LabelModel object.
        /// </summary>
        /// <returns>A string containing label information.</returns>
        public override string ToString()
        {
            return $"ID: {Id}, Category: {Category}, LabelName: {LabelName}, SearchWord: {SearchWord}";
        }
    }
}

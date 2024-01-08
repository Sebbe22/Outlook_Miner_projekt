using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookMiner.Models
{
    /// <summary>
    /// Represents a model for a checkbox.
    /// </summary>
    public class CheckBoxModel
    {
        /// <summary>
        /// Gets or sets the name of the method associated with the checkbox.
        /// </summary>
        public string methodName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the checkbox is checked or not.
        /// </summary>
        public bool isChecked { get; set; }

        /// <summary>
        /// Initializes a new instance of the CheckBoxModel class with the provided method name and checked status.
        /// </summary>
        /// <param name="_methodName">The name of the method associated with the checkbox.</param>
        /// <param name="_isChecked">The status indicating whether the checkbox is checked or not.</param>
        public CheckBoxModel(string _methodName, bool _isChecked)
        {
            methodName = _methodName;
            isChecked = _isChecked;
        }
    }
}

using OutlookMiner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OutlookMiner.Services.ICheckBoxService;

namespace OutlookMiner.Services
{
    public interface ICheckBoxService
    {
        List<CheckBoxModel> GetCheckBoxes();
        void UpdateCheckBox(string targetName, bool isChecked);


    }
    public class CheckBoxService : ICheckBoxService
    {
        private static CheckBoxService instance = null;

        private List<CheckBoxModel> checkBoxes;

        private CheckBoxService()
        {
            // Initialize the list of checkboxes with data
            checkBoxes = new List<CheckBoxModel>
            {
                new CheckBoxModel("RemoveLinksFromEmailString", false),
                new CheckBoxModel("RemoveEmailsFromEmailString", false),
                new CheckBoxModel("RemoveSenderAndRecieverNameFromEmail", false),
                new CheckBoxModel("RemovePhoneNumbersFromEmail", false),
                new CheckBoxModel("RemovePasswordAndUserNameFromEmail", false)
            };
        }

        public static ICheckBoxService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CheckBoxService();
                }
                return instance;
            }
        }

        public List<CheckBoxModel> GetCheckBoxes()
        {
            return checkBoxes;
        }

        public void UpdateCheckBox(string targetName, bool isChecked)
        {
            var targetCheckBox = checkBoxes.Find(c => c.methodName == targetName);
            if (targetCheckBox != null)
            {
                targetCheckBox.isChecked = isChecked;
            }
        }
    }
}

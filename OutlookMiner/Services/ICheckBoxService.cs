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
        List<CheckBoxModel> GetCheckBoxesManual();
        void UpdateCheckBox(string targetName, bool isChecked);


    }
    public class CheckBoxService : ICheckBoxService
    {
        private static CheckBoxService instance = null;

        private List<CheckBoxModel> checkBoxes;
        private List<CheckBoxModel> checkBoxesManual;

        private CheckBoxService()
        {
            
            checkBoxes = new List<CheckBoxModel>
            {
                new CheckBoxModel("RemoveEverythingPastBestRegards", false),
                new CheckBoxModel("RemoveSenderAndRecieverNameFromEmail", false),
                new CheckBoxModel("RemoveEmailsFromEmailString", false),
                new CheckBoxModel("RemoveLinksFromEmailString", false),
                new CheckBoxModel("RemovePhoneNumbersFromEmail", false),
                new CheckBoxModel("RemovePasswordAndUserNameFromEmail", false),
                new CheckBoxModel("CheckForSystems", false) //Has to be last

            };

            checkBoxesManual = new List<CheckBoxModel>
            {
                new CheckBoxModel("RemoveEverythingPastBestRegards", false),
                new CheckBoxModel("RemoveLinksFromEmailString", false),
                new CheckBoxModel("RemoveEmailsFromEmailString", false),
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

        public List<CheckBoxModel> GetCheckBoxesManual()
        {
            return checkBoxesManual;
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

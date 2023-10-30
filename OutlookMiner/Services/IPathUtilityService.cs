using OutlookMiner.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookMiner.Services
{
    public interface IPathUtilityService
    {
        public string SavePath(string fileExtension);
        public string LoadPath();
    }
    public class PathUtilityService: IPathUtilityService 
    {
        public string SavePath(string fileExtension)
        {
            string path = null;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = "C:\\"; // Set the initial directory
                saveFileDialog.Filter = "Text Files (*." + fileExtension + ")|*." + fileExtension+"|All Files (*.*)|*.*"; // Set the file filter
                saveFileDialog.DefaultExt = fileExtension; // Set the default file extension

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                  

                  path = saveFileDialog.FileName; // Get the selected file path

                }
            }
            return path;
        }
        public string LoadPath()
        {
            string path = null;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                
                openFileDialog.InitialDirectory = "C:\\"; // Set the initial directory
                openFileDialog.Filter = "Outlook Files (*.pst)|*.pst"; // Set the file filter

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = openFileDialog.FileName; // Get the selected file path

                }
            }
            return path;
        }

    }
}

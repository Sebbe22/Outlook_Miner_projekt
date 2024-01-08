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
        /// <summary>
        /// Gets the path where a file with the specified extension should be saved.
        /// </summary>
        /// <param name="fileExtension">The file extension to be used for the file.</param>
        /// <returns>The path for saving the file.</returns>
        string SavePath(string fileExtension);

        /// <summary>
        /// Gets the path for loading a file, typically used for opening existing files.
        /// </summary>
        /// <returns>The path for loading a file.</returns>
        string LoadPath();
    }

    public class PathUtilityService : IPathUtilityService
    {
        public string SavePath(string fileExtension)
        {
            string path = null;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = "C:\\"; 
                saveFileDialog.Filter = "Text Files (*." + fileExtension + ")|*." + fileExtension + "|All Files (*.*)|*.*"; // Set the file filter
                saveFileDialog.DefaultExt = fileExtension; 

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = saveFileDialog.FileName; 
                }
            }
            return path;
        }

        public string LoadPath()
        {
            string path = null;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\"; 
                openFileDialog.Filter = "Outlook Files (*.pst)|*.pst"; 

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = openFileDialog.FileName; 
                }
            }
            return path;
        }
    }

}


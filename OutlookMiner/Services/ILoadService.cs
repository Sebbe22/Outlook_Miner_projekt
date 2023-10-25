using OutlookMiner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace OutlookMiner.Services
{
    public interface ILoadService
    {
        List<Text> LoadMail(string pstFilePath);
    }

    public class LoadService : ILoadService
    {
        public List<Text> LoadMail(string pstFilePath)
        {
            List<Text> result = new List<Text>();
            try
            {
                // Create an instance of the Outlook Application.
                Outlook.Application oApp = new Outlook.Application();

                // Get the MAPI namespace.
                Outlook.NameSpace oNS = oApp.GetNamespace("MAPI");

                // Log on to the default Outlook profile.
                oNS.Logon(Missing.Value, Missing.Value, false, true);

                // Add the PST file to the current session.
                oNS.AddStore(pstFilePath);

                // Get the root folder of the PST file.
                Outlook.Store pstStore = null;
                foreach (Outlook.Store store in oNS.Stores)
                {
                    if (store.FilePath == pstFilePath)
                    {
                        pstStore = store;
                        break;
                    }
                }

                if (pstStore != null)
                {
                    Outlook.MAPIFolder pstFolder = pstStore.GetRootFolder();

                    // Get the Items collection in the PST folder.
                    Outlook.Items pstItems = pstFolder.Items;

                    HashSet<string> printedThreads = new HashSet<string>();

                    // Iterate through the email items and print them.
                    foreach (object item in pstItems)
                    {
                        if (item is Outlook.MailItem oMsg)
                        {
                            string currentThreadID = oMsg.ConversationID;

                            // Check if the email thread has already been printed.
                            if (!printedThreads.Contains(currentThreadID))
                            {
                                printedThreads.Add(currentThreadID);
                                Console.WriteLine("New Email Thread (ConversationID): " + currentThreadID);
                            }
                            result.Add(new Text(oMsg.Body));
                        }
                    }

                    // Release objects.
                    Marshal.ReleaseComObject(pstItems);
                    Marshal.ReleaseComObject(pstFolder);
                }

                // Log off from Outlook.
                oNS.Logoff();

                // Release objects.
                Marshal.ReleaseComObject(pstStore);
                Marshal.ReleaseComObject(oNS);
                Marshal.ReleaseComObject(oApp);
                return result;
            }
            catch
            {
                Console.WriteLine("An error occurred: ");
                return null;
            }
        }
    }
}

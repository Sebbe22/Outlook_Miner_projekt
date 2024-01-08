﻿using OutlookMiner.Models;
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
                //instance of the Outlook Application.
                Outlook.Application oApp = new Outlook.Application();

                // Get MAPI namespace.
                Outlook.NameSpace oNS = oApp.GetNamespace("MAPI");

                // Log on default Outlook profile.
                oNS.Logon(Missing.Value, Missing.Value, false, true);

                // Add the PST file to the current session.
                oNS.AddStore(pstFilePath);

                // Get root folder of the PST file.
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

                    //Items collection in the PST folder.
                    Outlook.Items pstItems = pstFolder.Items;

                  
                    foreach (object item in pstItems)
                    {
                        if (item is Outlook.MailItem oMsg)
                        {
                            string currentThreadID = oMsg.ConversationID;
                            Text email = new Text(oMsg.Body, currentThreadID);
                            email.sender = oMsg.Sender.Name;
                            email.senderEmail = oMsg.SenderEmailAddress;
                            email.recievedTime = oMsg.ReceivedTime; 
                            for (int i = 1; i < oMsg.Recipients.Count+1; i++)
                            {
                                email.recipients.Add(oMsg.Recipients[i].Name);
                            }
                            result.Add(email);
                        }
                    }

                 
                    Marshal.ReleaseComObject(pstItems);
                    Marshal.ReleaseComObject(pstFolder);
                }

               
                oNS.Logoff();

                Marshal.ReleaseComObject(pstStore);
                Marshal.ReleaseComObject(oNS);
                Marshal.ReleaseComObject(oApp);
                return result;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
    }
}

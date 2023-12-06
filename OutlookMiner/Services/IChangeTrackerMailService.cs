using OutlookMiner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OutlookMiner.Services
{
    public interface IChangeTrackerMailService
    {
        //public List<IndividualMailText> InsertLinksBackIntoEmailString(List<IndividualMailText> mails, List<RemovedContentModel> removedContentList);
        //public (List<RemovedContentModel>, string) ProcessMatchesIntoRemovedContent(List<RemovedContentModel> removedContents, MatchCollection matches, string mail);
    }

    public class ChangeTrackerMailService: IChangeTrackerMailService
    {
       //public (List<RemovedContentModel>, string) ProcessMatchesIntoRemovedContent(List<RemovedContentModel> removedContents, MatchCollection matches, string mail)
       // {

       //     int offSet = 0;
       //     foreach (Match match in matches)
       //     {

       //         var removedContent = new RemovedContentModel
       //         {
       //             Content = match.Value,
       //             originalStartIndex = match.Index - offSet,
       //             originalEndIndex = match.Index + match.Length - 1 - offSet
       //         };

       //         removedContents.Add(removedContent);
       //         mail = mail.Remove(match.Index - offSet, match.Length);

       //         foreach (var rc in removedContents)
       //         {
       //             if (removedContent.originalStartIndex > removedContent.originalStartIndex)
       //             {
       //                 removedContent.originalStartIndex -= offSet;
       //                 removedContent.originalEndIndex -= offSet;
       //             }
       //         }

       //         offSet = offSet + match.Value.Length; // Update currentLocation
       //     }
       //     return (removedContents, mail);

       // }

       // public List<IndividualMailText> InsertLinksBackIntoEmailString(List<IndividualMailText> mails, List<RemovedContentModel> removedContentList)
       // {
       //     foreach (var mail in mails)
       //     {
       //         int offSet = 0;
       //         foreach (var removedContent in removedContentList.OrderBy(rc => rc.originalStartIndex))
       //         {

       //             mail.body = mail.body.Insert(removedContent.originalStartIndex + offSet, removedContent.Content);
       //             offSet = offSet + removedContent.Content.Length;
       //         }
       //     }


       //     return mails; 
       // }
    }

}

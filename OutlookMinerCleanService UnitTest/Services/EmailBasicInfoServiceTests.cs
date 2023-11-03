using Microsoft.VisualStudio.TestTools.UnitTesting;
using OutlookMiner.Models;
using OutlookMiner.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookMiner.Services.Tests
{
    [TestClass()]
    public class EmailBasicInfoServiceTests
    {

        [DataRow("Oki doki det er helt fint \r\n//Kirstine\r\nMed venlig hilsen / Best regards,\r\nKirstine Juncker Berantzino\r\nIntern R&D\r\nkjb@ellab.com \t | \twww.ellab.com\r\nFrom: Kirstine Juncker Berantzino\r\nSent: Thursday, 26 October 2023 11.04\r\nTo: Kirstine Juncker Berantzino\r\nSubject: Test af OutlookMiner\r\nJeg har bare brug for nogle mails til at teste\r\nPeace out\r\n// Kirstine\r\nMed venlig hilsen / Best regards,\r\nEvaluating unlicensed DynamicPDF feature. Click here for details. [1:0:v12.10]\r\nDynamicPDF Core Suite (Generator, Merger and ReportWriter) for .NET v12.10\r\nKirstine Juncker Berantzino\r\nIntern R&D\r\nkjb@ellab.com\r\n |\r\nwww.ellab.com\r\nTrollesmindealle 29\r\n3400\r\nHillerød\r\n |\r\nDenmark", 2)]
        [DataRow("Oki doki det er helt fint \r\n//Kirstine\r\nMed venlig hilsen / Best regards,\r\nKirstine Juncker Berantzino\r\nIntern R&D\r\nkjb@ellab.com \t | \twww.ellab.com\r\nFrom: Kirstine Juncker Berantzino\r\nSent: Thursday, 26 October 2023 11.04\r\nTo: Kirstine Juncker Berantzino\r\nSubject: Test af OutlookMiner", 1)]

        [TestMethod()]
        public void SeparateThreadsIntoMailsTest(string mail, int expectedResult)
        {
            //Arrange
            EmailBasicInfoService service = new EmailBasicInfoService();
            List<Text> texts = new List<Text>();
            texts.Add(new Text(mail, "1"));


            List<IndividualMailText> individualMail = service.SeparateThreadsIntoMails(texts);

            int actualResult = individualMail.Count();

            Assert.AreEqual(expectedResult, actualResult);


        }

        [TestMethod]
        public void SeparateThreadsIntoMails_ShouldAssignMessageIdsCorrectly()
        {
            // Arrange
            List<Text> mails = new List<Text>
        {
            new Text("Message 1", "Thread 1"),
            new Text("Oki doki det er helt fint \r\n//Kirstine\r\nMed venlig hilsen / Best regards,\r\nKirstine Juncker Berantzino\r\nIntern R&D\r\nkjb@ellab.com \t | \twww.ellab.com\r\nFrom: Kirstine Juncker Berantzino\r\nSent: Thursday, 26 October 2023 11.04\r\nTo: Kirstine Juncker Berantzino\r\nSubject: Test af OutlookMiner\r\nJeg har bare brug for nogle mails til at teste\r\nPeace out\r\n// Kirstine\r\nMed venlig hilsen / Best regards,\r\nEvaluating unlicensed DynamicPDF feature. Click here for details. [1:0:v12.10]\r\nDynamicPDF Core Suite (Generator, Merger and ReportWriter) for .NET v12.10\r\nKirstine Juncker Berantzino\r\nIntern R&D\r\nkjb@ellab.com\r\n |\r\nwww.ellab.com\r\nTrollesmindealle 29\r\n3400\r\nHillerød\r\n |\r\nDenmark", "Thread 3"),
            new Text("Message 3", "Thread 2"),
        };

            IEmailBasicInfoService textProcessor = new EmailBasicInfoService(); // Replace with the actual class name

            // Act
            List<IndividualMailText> result = textProcessor.SeparateThreadsIntoMails(mails);

            // Assert
            int expectedMailId = 1;
            string threadID = "";
            foreach (IndividualMailText mail in result)
            {

                if (mail.threadID != threadID)
                {
                    expectedMailId = 1;

                }
                threadID = mail.threadID;
                // Check if the message ID is assigned correctly
                Assert.AreEqual(expectedMailId, mail.messageID);
                expectedMailId++;
            }
        }


        [TestMethod]
        public void CountMessages_ShouldReturnCorrectCount()
        {
            // Arrange
            List<IndividualMailText> mails = new List<IndividualMailText>
        {
            new IndividualMailText("Message 1", "1", 1),
            new IndividualMailText("Message 2", "1", 2),
            new IndividualMailText("Message 3", "2", 1)
        };

            IEmailBasicInfoService mailTextProcessor = new EmailBasicInfoService(); // Replace with the actual class name

            // Act
            int result = mailTextProcessor.CountMessages(mails);

            // Assert
            int expectedCount = 3;
            Assert.AreEqual(expectedCount, result);
        }

        [TestMethod]
        public void CountThreads_ShouldReturnCorrectCount()
        {
            // Arrange
            List<Text> mails = new List<Text>
        {
            new Text("Message 1", "Thread 1"),
            new Text("Message 2", "Thread 1"),
            new Text("Message 3", "Thread 2"),
        };

            IEmailBasicInfoService textProcessor = new EmailBasicInfoService(); // Replace with the actual class name

            // Act
            int result = textProcessor.CountThreads(mails);

            // Assert
            int expectedCount = 3;
            Assert.AreEqual(expectedCount, result);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OutlookMiner.Models;

using OutlookMiner.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutlookMiner.Services.Tests
{
    [TestClass()]
    public class CleanManualServiceTests
    {
        private CleanManualService cleanManualService;

        [TestInitialize]
        public void Setup()
        {
            cleanManualService = new CleanManualService();
        }
        [TestMethod]
        [DataRow("This is a test email. Best regards, John Doe", "This is a test email. [Best regards, John Doe]", "thread1", 1)]
        [DataRow("Hello! Best Regards to you.", "Hello! [Best Regards to you.]", "thread2", 2)]
        // Add more DataRow entries with different input-output pairs for testing
        public void RemoveEverythingPastBestRegards_RemovesTextAfterBestRegards(string inputBody, string expectedBody, string threadId, int messageId)
        {
            // Arrange
            List<IndividualMailText> mails = new List<IndividualMailText>();
            IndividualMailText mail = new IndividualMailText(inputBody, threadId, messageId);
            mails.Add(mail);

            // Act
            var result = cleanManualService.RemoveEverythingPastBestRegards(mails);

            // Assert
            Assert.AreEqual(expectedBody, result[0].body);
        }
        [TestMethod]
        [DataRow("Bla bla bla bla email@example.com", "Bla bla bla bla [email@example.com]", "thread1", 1)]
        [DataRow("user@example.com and info@test.com", "[user@example.com] and [info@test.com]", "thread2", 2)]
        // Add more DataRow entries with different input-output pairs for testing
        public void RemoveEmailsFromEmailString_RemovesEmails(string inputBody, string expectedBody, string threadId, int messageId)
        {
            // Arrange
            List<IndividualMailText> mails = new List<IndividualMailText>();
            IndividualMailText mail = new IndividualMailText(inputBody, threadId, messageId);
            mails.Add(mail);

            // Act
            var result = cleanManualService.RemoveEmailsFromEmailString(mails);

            // Assert
            Assert.AreEqual(expectedBody, result[0].body);
        }

        [TestMethod]
        [DataRow("Bla bla bla bla", "Bla bla bla bla", "thread1", 1)]

        // Add more DataRow entries with different input-output pairs for testing
        public void RemoveEmailsFromEmailString_DoesNotRemove(string inputBody, string expectedBody, string threadId, int messageId)
        {
            // Arrange
            List<IndividualMailText> mails = new List<IndividualMailText>();
            IndividualMailText mail = new IndividualMailText(inputBody, threadId, messageId);
            mails.Add(mail);

            // Act
            var result = cleanManualService.RemoveEmailsFromEmailString(mails);

            // Assert
            Assert.AreEqual(expectedBody, result[0].body);
        }
        [TestMethod]
        [DataRow("This is a test email with a link https://www.example.com", "This is a test email with a link [https://www.example.com]", "thread1", 1)]
        [DataRow("Another email with a website www.test.com", "Another email with a website [www.test.com]", "thread2", 2)]
        // Add more DataRow entries with different input-output pairs for testing
        public void RemoveLinksFromEmailString_RemovesLinks(string inputBody, string expectedBody, string threadId, int messageId)
        {
            // Arrange
            List<IndividualMailText> mails = new List<IndividualMailText>();
            IndividualMailText mail = new IndividualMailText(inputBody, threadId, messageId);
            mails.Add(mail);

            // Act
            var result = cleanManualService.RemoveLinksFromEmailString(mails);

            // Assert
            Assert.AreEqual(expectedBody, result[0].body);
        }

        [TestMethod]
        [DataRow("ertretretert", "ertretretert", "thread1", 1)]

        // Add more DataRow entries with different input-output pairs for testing
        public void RemoveLinksFromEmailString_DoesNotRemoveAnything(string inputBody, string expectedBody, string threadId, int messageId)
        {
            // Arrange
            List<IndividualMailText> mails = new List<IndividualMailText>();
            IndividualMailText mail = new IndividualMailText(inputBody, threadId, messageId);
            mails.Add(mail);

            // Act
            var result = cleanManualService.RemoveLinksFromEmailString(mails);

            // Assert
            Assert.AreEqual(expectedBody, result[0].body);
        }

        [TestMethod()]
        [DataRow("This is a test email without phone numbers", "DefaultThreadID", 1)]
        [DataRow("Another email body that doesn't contain phone numbers", "DefaultThreadID", 2)]
        public void RemovePhoneNumbersFromEmail_NoPhoneNumbers_ReturnsOriginalEmails(string body, string threadID, int messageID)
        {
            // Arrange
            List<IndividualMailText> emails = new List<IndividualMailText>();
            IndividualMailText email = new IndividualMailText(body, threadID, messageID);
            emails.Add(email);

            // Act
            var result = cleanManualService.RemovePhoneNumbersFromEmail(emails);

            // Assert
            CollectionAssert.AreEqual(emails, result);
        }

        [TestMethod()]
        [DataRow("This is a test email with phone number 20105866", "thread1", 1, "This is a test email with phone number [20105866]")]
        [DataRow("Another email body that contains phone number +45 49 20 10 58", "thread2", 2, "Another email body that contains phone number [+45 49 20 10 58]")]
        public void RemovePhoneNumbersFromEmail_WithPhoneNumbers_RemovesPhoneNumbers(string body, string threadId, int messageId, string expectedResult)
        {
            // Arrange
            List<IndividualMailText> emails = new List<IndividualMailText>();
            IndividualMailText email = new IndividualMailText(body, threadId, messageId);
            emails.Add(email);

            // Act
            var actualResult = cleanManualService.RemovePhoneNumbersFromEmail(emails);

            // Assert
            Assert.AreEqual(actualResult[0].body, expectedResult);
        }

        [TestMethod]
        [DataRow("sdfdsfsdf example@example.com", @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]+", "sdfdsfsdf [example@example.com]")]
        [DataRow("www.example.com", @"www\.\w+\.\w+(?:\.\w+)?", "[www.example.com]")]
        // Add more DataRow entries with different input-output pairs for testing
        public void AddIndicatorsToMail_AddsIndicatorsToMatches(string inputBody, string pattern, string expectedBody)
        {
            // Act
            var result = cleanManualService.AddIndicatorsToMail(inputBody, pattern);

            // Assert
            Assert.AreEqual(expectedBody, result);
        }

        [TestMethod]
        public void FindSubstrings_FindsCorrectSubstrings()
        {
            // Arrange
            string text = "Det her [a] er en test [string] med [substrings].";
            List<RemovedContentModel> expectedSubstrings = new List<RemovedContentModel>
            {
                new RemovedContentModel("a", 8, 10),
                new RemovedContentModel("string", 19, 25),
                new RemovedContentModel("substrings", 31, 41)
            };

            // Act
            var result = cleanManualService.FindSubstrings(text);

            // Assert
            Assert.AreEqual(expectedSubstrings.Count, result.Count);
        }
        [TestMethod]
        public void FindSubstrings_FindsCorrectSubstring()
        {
            // Arrange
            string text = "Det her [a]";

            RemovedContentModel Expectedresult = new RemovedContentModel("a", 8, 10);
               

            // Act
            List<RemovedContentModel> Actualresult = cleanManualService.FindSubstrings(text);

            // Assert
            Assert.AreEqual(Actualresult[0].Content, Expectedresult.Content);
       
        }

        [TestMethod]
        [DataRow("test skal fjernes i brackets [test]", "test skal fjernes i brackets ")]
        public void DeleteStringsFromText_DeletesCorrectStrings(string input ,string expectedResult)
        {
            // Arrange

            List<RemovedContentModel> stringsToDelete = new List<RemovedContentModel>
        {
            new RemovedContentModel("test", 13, 17)
        };
            string expectedText = "This is a string substrings.";

            // Act
            string actualResult = cleanManualService.DeleteStringsFromText(input, stringsToDelete);

            // Assert
            Assert.AreEqual(actualResult, expectedResult);
        }

    }


}
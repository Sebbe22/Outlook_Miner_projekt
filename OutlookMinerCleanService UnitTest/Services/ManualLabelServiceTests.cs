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
    public class ManualLabelServiceTests
    {
        private IManualLabelService threadProcessor; // Replace ThreadProcessor with your actual class name

        [TestInitialize]
        public void Setup()
        {
            threadProcessor = new ManualLabelService(); 
        }

        [TestMethod]
        [DataRow("besked 1", "Thread1", 1, "Label1", "Label3")]
        [DataRow("besked 2", "Thread2", 2, "Label2")]
        [DataRow("besked 3", "Thread1", 3, "Label1", "Label3")]
        public void CreateThreads_GroupsMessagesByThreadID(string messageBody, string threadId, int messageId, params string[] labels)
        {
            // Arrange
            var messages = new List<IndividualMailTextLabelingModel>
        {
            new IndividualMailTextLabelingModel(new IndividualMailText(messageBody, threadId, messageId), labels.ToList())
        };

            var expectedThreads = new List<ThreadModel>
        {
            new ThreadModel
            {
                ThreadID = threadId,
                Messages = messages
            }
        };

            // Act
            var result = threadProcessor.CreateThreads(messages);

            // Assert
            Assert.AreEqual(expectedThreads.Count, result.Count);

            for (int i = 0; i < expectedThreads.Count; i++)
            {
                Assert.AreEqual(expectedThreads[i].ThreadID, result[i].ThreadID);
                CollectionAssert.AreEqual(expectedThreads[i].Messages, result[i].Messages);
            }
        }

        [TestMethod]
        [DataRow("Test Message", "Thread1", 1, "Label1", "Label2")]
        [DataRow("Another Message", "Thread2", 2, "Label3")]
        public void AddMessageWithLabels_CreatesIndividualMailTextLabelingModel(string messageBody, string threadId, int messageId, params string[] labels)
        {
            // Arrange
            var message = new IndividualMailText(messageBody, threadId, messageId);
            var expectedMessage = new IndividualMailTextLabelingModel(message, labels.ToList());

            // Act
            var result = threadProcessor.AddMessageWithLabels(message, labels.ToList());

            // Assert
            Assert.AreEqual(expectedMessage.Message, result.Message);
            CollectionAssert.AreEqual(expectedMessage.Labels, result.Labels);
        }
    }
}
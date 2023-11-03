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
    public class CleanServiceTests
    {
        [TestMethod()]
        [DataRow("https://www.facebook.com/watch?v=294229483582067", "")]
        [DataRow("www.test.dk", "")]
        [DataRow("her er et link du kan følge som måske kan hjælpe: www.test.dk", "her er et link du kan følge som måske kan hjælpe: ")]
        [DataRow("www.test.dk dette tekst burde gerne blive", " dette tekst burde gerne blive")]
        [DataRow("<www.test.dk>", "")]
        [DataRow("<where to do stuff>", "<where to do stuff>")]
        [DataRow("test test test <https://www.youtube.com/watch?v=dQw4w9WgXcQ> test test test", "test test test  test test test")]
        [DataRow("test<www.test.dk>test", "testtest")]
        [DataRow("https://trello.com/b/sPuVZtVH/hovedprojektet-2023-2024", "")]
        public void RemoveLinksFromEmailStringTest(string test, string expectedResult)
        {
            // arrange
            List<Text> emailList = new List<Text>() { new Text(test, "") };
            ICleanService cleanService = new CleanService();
            string actualResult = "";

            // act
            emailList = cleanService.RemoveLinksFromEmailString(emailList);

            foreach (var item in emailList)
            {
                actualResult = actualResult + item.body;
            }

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        [DataRow("blahblah@mail.com", "")]
        [DataRow("denne teks skal blive test@test.dk skal blive", "denne teks skal blive  skal blive")]
        [DataRow("where to do stuff", "where to do stuff")]
        [DataRow("", "")]
        [DataRow("pepepep @mai.com", "pepepep @mai.com")]
        [DataRow("er@mail dk", "er@mail dk")]
        [DataRow("keke@mail.dkdddakaldw", "")]
        [DataRow("seba124m@edu.zealand.dk", "")]
        public void RemoveEmailsFromEmailStringTest(string test, string expectedResult)
        {
            // arrange 
            List<Text> emailList = new List<Text> { new Text(test, "1") };
            ICleanService cleanService = new CleanService();
            string actualResult = "";

            // act
            emailList = cleanService.RemoveEmailsFromEmailString(emailList);
            foreach (var item in emailList)
            {
                actualResult = actualResult + item.body;
            }

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
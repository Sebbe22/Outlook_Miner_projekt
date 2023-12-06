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
        public void RemoveLinksFromEmailStringTest(string testValue, string expectedResult)
        {
            // arrange
            List<IndividualMailText> emailList = new List<IndividualMailText>() { new IndividualMailText(testValue, "",1) };
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
        public void RemoveEmailsFromEmailStringTest(string testValue, string expectedResult)
        {
            // arrange 
            List<IndividualMailText> emailList = new List<IndividualMailText> { new IndividualMailText(testValue, "1", 1) };
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

        [TestMethod]
        [DataRow("Hej sebastian dette er en lille test", "hej  dette er en lille test")]
        [DataRow("Hej sebastian gylstorff!", "hej  !")]
        [DataRow("ælkjsænfaioæsebastianmklæawjæ", "ælkjsænfaioæmklæawjæ")]
        [DataRow("Hr.gylstorff det var en fornøjelse at møde dem", "hr. det var en fornøjelse at møde dem")]
        [DataRow(" seb astian ", " seb astian ")]
        [DataRow(" 235sebastian29jkæ532 jk235 j ¤gylstorff!!#¤", " 23529jkæ532 jk235 j ¤!!#¤")]
        [DataRow(" Henrik Olsen Jensen", "   ")]
        [DataRow("sebastian Gylstorff, HenrikOlsenJensen", " , ")]
        [DataRow("gesgsegy4 Zealand awdagerg", "gesgsegy4  awdagerg")]
        [DataRow("pls virk 测试 hehe", "pls virk  hehe")]
        public void RemoveSenderAndRecieverNameFromMailTest(string testValue, string expectedResult)
        {
            //arrange
            List<IndividualMailText> emailList = new List<IndividualMailText> { new IndividualMailText(testValue, "1", 1) };
            emailList[0].sender = "Sebastian Gylstorff";
            emailList[0].recipients.Add("Henrik Olsen Jensen");
            emailList[0].recipients.Add("Zealand");
            emailList[0].recipients.Add("测试");
            ICleanService cleanService = new CleanService();
            string actualResult = "";

            //act
            emailList = cleanService.RemoveSenderAndRecieverNameFromEmail(emailList);
            actualResult = emailList[0].body;

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [DataRow("Hej her har du password: hehe", "Hej her har du ")]
        [DataRow("Hej her har du username: heheheh heh", "Hej her har du  heh")]
        [DataRow("username skal ikke fjerne noget her samme gælder password her", "username skal ikke fjerne noget her samme gælder password her")]
        [DataRow("ngælaesusername: test noiærghoæpassword: test", "ngælaesusername: test noiærghoæpassword: test")]
        [DataRow("username: test1 password: test1 username: test2 password: test2", "   ")]
        public void RemovePasswordAndUsernameFromEmail(string testValue, string expectedResult)
        {
            //arrange
            List<IndividualMailText> emailList = new List<IndividualMailText> { new IndividualMailText(testValue, "1", 2) };
            ICleanService cleanService = new CleanService();
            string actualResult = "";

            //act
            actualResult = cleanService.RemovePasswordAndUserNameFromEmail(emailList)[0].body;

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [DataRow("20105866", "")]
        [DataRow("hej her har du mit nummer: 24981740", "hej her har du mit nummer: ")]
        [DataRow("+45 49 20 10 58", "")]
        [DataRow("hvad er  34+45 421852811", "hvad er  34+45 421852811")]
        [DataRow("1122334", "1122334")]
        [DataRow("jklæawjeælawj48291452fkæsejf", "jklæawjeælawj48291452fkæsejf")]
        public void RemovePhoneNumbersFromEmailTest(string testValue, string expectedResult)
        {
            //arrange 
            List<IndividualMailText> emailList = new List<IndividualMailText> { new IndividualMailText(testValue, "1", 2) };
            ICleanService cleanService = new CleanService();
            string actualResult = "";

            //act
            actualResult = cleanService.RemovePhoneNumbersFromEmail(emailList)[0].body;

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
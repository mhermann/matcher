using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matcher;
namespace MatcherTests
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void TestLowercaseUsername()
        //{
        //    Assert.IsTrue(Matcher.Matcher.LowercaseUsernames("skinke", 3, 16).Any());
        //    Assert.IsTrue(!Matcher.Matcher.LowercaseUsernames("Sk as as", 3, 16).Any());
        //    Assert.IsTrue(Matcher.Matcher.LowercaseUsernames("skinke, skinke, tu", 3, 16).Count() == 2);
        //    Assert.IsTrue(!Matcher.Matcher.LowercaseUsernames("mathias", 4, 6).Any());
        //}

        [TestMethod]
        public void TestIncorrectUrl()
        {
            Assert.IsTrue(!Matcher.Matcher.Urls("skinke").Any());
        }

        [TestMethod]
        public void TestTwoIncorrectUrl()
        {
            Assert.IsTrue(!Matcher.Matcher.Urls("skinke ww.te").Any());
        }

        [TestMethod]
        public void TestCorrectUrlWithHttp()
        {
            Assert.IsTrue(Matcher.Matcher.Urls("http://lyn.dk").Any());
        }

        [TestMethod]
        public void TestTwoCorrectUrlWithHttp()
        {
            Assert.IsTrue(Matcher.Matcher.Urls("http://lyn.dk http://fiske.dk").Count() == 2);
        }

        [TestMethod]
        public void TestIncorrectEmail()
        {
            Assert.IsTrue(!Matcher.Matcher.Emails("http://lyn.dk").Any());
        }

        [TestMethod]
        public void TestCorrectEmail()
        {
            Assert.IsTrue(Matcher.Matcher.Emails("fisk@dr.dk").Any());
        }

        [TestMethod]
        public void TestCorrectHashtags()
        {
            Assert.IsTrue(Matcher.Matcher.Emails("fisk@dr.dk #test").Any());
        }

        [TestMethod]
        public void TestCorrectHashtagsWithHyphen()
        {
            Assert.IsTrue(Matcher.Matcher.Emails("fisk@dr.dk #test-igen").Any());
        }

        [TestMethod]
        public void TestTwoCorrectHashtags()
        {
            Assert.IsTrue(Matcher.Matcher.Emails("fisk@dr.dk #test #lun").Any());
        }
    }
}

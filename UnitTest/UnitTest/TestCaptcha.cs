using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CaptchaGenerator;
using System.Drawing;

namespace UnitTest
{
    [TestClass]
    public class TestCaptcha
    {
        [TestMethod]
        public void TestOfGeneratingText()
        {
            string generatedText = "";
            generatedText = TextGenerator.GetText();
            Assert.AreNotEqual("", generatedText);
        }

        [TestMethod]
        public void TestOfGeneratingDifferentText()
        {
            string generatedText1 = TextGenerator.GetText();
            string generatedText2 = TextGenerator.GetText();
            Assert.AreNotEqual(generatedText1, generatedText2);
        }

        [TestMethod]
        public void TestOfGeneratingImage()
        {
            string generatedText = TextGenerator.GetText();
            Bitmap captcha = CaptchaGenerator.CaptchaGenerator.GetCaptcha(100, 100, generatedText, Color.White);
            Assert.IsNotNull(captcha);
        }
    }
}

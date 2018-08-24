using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projet1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1.Tests
{
    [TestClass()]
    public class MessageTests
    {
        [TestMethod()]
        public void BonjourTest()
        {
            DateTime date = new DateTime(2018, 8, 24, 9, 0, 0);
            Message m = new Message(new FakeDateTime(date));
            String result = m.GetHelloMessage();
            //Message m = new Message(9, 13, 18);
            //String result = m.GetHelloMessage();
            Assert.IsTrue(result.Contains("Bonjour"));
        }

        [TestMethod()]
        public void BonAPTest()
        {
            DateTime date = new DateTime(2018, 8, 24, 17, 0, 0);
            Message m = new Message(new FakeDateTime(date));
            String result = m.GetHelloMessage();
            Assert.IsTrue(result.Contains("Bon après-midi"));
        }

        [TestMethod()]
        public void BonsoirTest()
        {
            DateTime date = new DateTime(2018, 8, 27, 22, 0, 0);
            Message m = new Message(new FakeDateTime(date));
            String result = m.GetHelloMessage();
            Assert.IsTrue(result.Contains("Bonsoir"));
        }

        [TestMethod()]
        public void BonWDTest()
        {
            DateTime date = new DateTime(2018, 8,27,8,0,0);
            Message m = new Message(new FakeDateTime(date));
            String result = m.GetHelloMessage();
            Assert.IsTrue(result.Contains("Bon week-end"));
        }
    }
}
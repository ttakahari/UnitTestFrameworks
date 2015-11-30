using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestFrameworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestFrameworks.MSTest
{
    [TestClass()]
    public class SampleTests
    {
        [TestMethod()]
        public void GetStringTest()
        {
            var sample = new Sample();
            var value  = sample.GetString();

            Assert.AreEqual("", value);
            Assert.AreNotEqual("hoge", value);
        }

        [TestMethod()]
        public void GetInt32Test()
        {
            var sample = new Sample();
            var value  = sample.GetInt32();

            Assert.AreEqual(0, value);
            Assert.AreNotEqual(1, value);
            Assert.AreNotEqual("0", value); // コレが比較できるのおかしい
            Assert.AreNotEqual("1", value); // コレが比較できるのおかしい
        }

        [TestMethod()]
        public void GetBooleanTest()
        {
            var sample = new Sample();
            var value  = sample.GetBoolean();

            Assert.AreEqual(false, value);
            Assert.AreNotEqual(true, value);
            Assert.AreNotEqual("false", value); // コレが比較できるのおかしい
            Assert.AreNotEqual("true", value);  // コレが比較できるのおかしい
        }
    }
}
using Xunit;
using UnitTestFrameworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestFrameworks.XUnit
{
    public class SampleTests
    {
        [Fact()]
        public void GetStringTest()
        {
            var sample = new Sample();
            var value  = sample.GetString();

            Assert.Equal("", value);
            Assert.NotEqual("hoge", value);
        }

        [Fact()]
        public void GetInt32Test()
        {
            var sample = new Sample();
            var value  = sample.GetInt32();

            Assert.Equal(0, value);
            Assert.NotEqual(1, value);
        }

        [Fact()]
        public void GetBooleanTest()
        {
            var sample = new Sample();
            var value  = sample.GetBoolean();

            Assert.Equal(false, value);
            Assert.NotEqual(true, value);
        }
    }
}
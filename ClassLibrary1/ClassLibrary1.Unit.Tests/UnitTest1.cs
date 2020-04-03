using Xunit;

namespace ClassLibrary1.Unit.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var result = Class1.SayHello("Jason");

            Assert.Equal("Hello, Jason!", result);
        }
    }
}
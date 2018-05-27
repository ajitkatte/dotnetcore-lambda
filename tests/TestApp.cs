using System;
using Xunit;
using LambdaTestApp;
using Amazon.Lambda.TestUtilities;

namespace LambdaAppTest
{
    public class TestApp
    {
        private LambdaHandler _handler;
        private TestLambdaContext _context;

        public TestApp()
        {
            _handler = new LambdaHandler();
            _context = new TestLambdaContext();
        }

        [Fact]
        public void Test_Lambda_Success()
        {            
            var response = _handler.Handler("world", _context);
            Assert.Equal("HELLO WORLD", response);
        }

        [Fact]
        public void Test_Lambda_Failure()
        {
            var context = new TestLambdaContext();
            var response = _handler.Handler("Logging", _context);
            Assert.NotEqual("Hello World", response);
        }
    }
}
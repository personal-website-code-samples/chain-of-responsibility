namespace ChainOfResponsibility.Tests.Problem
{
    using ChainOfResponsibility.Problem;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FirstServiceIntegrationTests
    {
        private readonly FirstService _firstService;

        public FirstServiceIntegrationTests()
        {
            _firstService = new FirstService(new SecondService(new ThirdService()));
        }

        [TestMethod]
        public void MyMethod_Does_Something_Correctly()
        {
            var result = _firstService.DoSomething(new Widget());

            // Assert our final result is correct
        }
    }
}

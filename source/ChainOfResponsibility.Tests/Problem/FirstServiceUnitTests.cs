namespace ChainOfResponsibility.Tests.Problem
{
    using ChainOfResponsibility.Problem;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;

    [TestClass]
    public class FirstServiceUnitTests
    {
        private readonly FirstService _firstService;

        public FirstServiceUnitTests()
        {
            var secondService = new Mock<ISecondService>();

            // Mock second service returns original widget passed to verify state
            secondService.Setup(service => service.DoSomething(It.IsAny<Widget>()))
                .Returns((Widget widget) => widget);

            _firstService = new FirstService(secondService.Object);
        }

        [TestMethod]
        public void MyMethod_Does_Something_Correctly()
        {
            var result = _firstService.DoSomething(new Widget());

            // Assert that my function did something correctly.
        }
    }
}

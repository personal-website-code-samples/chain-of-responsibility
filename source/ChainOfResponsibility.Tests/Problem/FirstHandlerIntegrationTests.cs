namespace ChainOfResponsibility.Tests.Problem
{
    using System.Threading.Tasks;
    using ChainOfResponsibility.Chain;
    using ChainOfResponsibility.New;
    using ChainOfResponsibility.Problem;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FirstHandlerIntegrationTests
    {
        private readonly IChainHandler<Widget> _handler;

        public FirstHandlerIntegrationTests()
        {
            // Inject real dependencies for integration test.
            _handler = new FirstChainHandler(null);
        }

        [TestMethod]
        public async Task Handle_Does_Something_Correctly()
        {
            var result = await _handler.Handle(new Widget());

            // Assert the result is correct.
        }
    }
}

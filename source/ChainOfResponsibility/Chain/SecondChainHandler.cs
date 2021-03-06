namespace ChainOfResponsibility.Chain
{
    using System.Threading.Tasks;
    using ChainOfResponsibility.New;
    using ChainOfResponsibility.Problem;

    public class SecondChainHandler : ChainHandler<Widget>
    {
        public SecondChainHandler(IChainHandler<Widget> successor)
            : base(successor)
        {
        }

        protected override Task<Widget> DoWork(Widget request)
        {
            // Do something with the widget and return.
            return Task.FromResult(request);
        }
    }
}

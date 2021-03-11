namespace ChainOfResponsibility.New
{
    using System.Threading.Tasks;
    using ChainOfResponsibility.Problem;

    public class GoodChainCreationHandler
    {
        private readonly IChainFactory<Widget> _chainFactory;

        public GoodChainCreationHandler(IChainFactory<Widget> chainFactory)
        {
            _chainFactory = chainFactory;
        }

        public async Task<Widget> Handle(Widget widget)
        {
            var chain = _chainFactory.CreateChain();

            return await chain.Handle(widget);
        }
    }
}

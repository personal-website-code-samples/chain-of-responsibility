namespace ChainOfResponsibility.Old
{
    using System.Threading.Tasks;
    using ChainOfResponsibility.Chain;
    using ChainOfResponsibility.Problem;

    public class BadChainCreationHandler
    {
        // IFirstChainDependency;
        // ISecondChainDependency;
        // IThirdChainDependency;
        public async Task<Widget> Handle(Widget widget)
        {
            var handlerChain = new FirstChainHandler(new SecondChainHandler(new ThirdChainHandler(null)));

            return await handlerChain.Handle(widget);
        }
    }
}

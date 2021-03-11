namespace ChainOfResponsibility.New
{
    using ChainOfResponsibility.Chain;
    using ChainOfResponsibility.Problem;

    public class WidgetChainFactory : IChainFactory<Widget>
    {
        // IFirstChainDependency;
        // ISecondChainDependency;
        // IThirdChainDependency;
        public IChainHandler<Widget> CreateChain()
        {
            return new FirstChainHandler(new SecondChainHandler(new ThirdChainHandler(null)));
        }
    }
}

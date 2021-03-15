namespace ChainOfResponsibility.New
{
    using ChainOfResponsibility.Chain;
    using ChainOfResponsibility.Problem;

    public class WidgetChainFactory : IChainFactory<Widget>
    {
        // private readonly IFirstDependency _firstDependency;
        // private readonly ISecondDependency _secondDependency;
        // private readonly IThirdDependency _thirdDependency;

        // public WidgetChainFactory(IFirstDependency firstDependency, ISecondDependency secondDependency, IThirdDependency thirdDependency)
        // {
        //     _firstDependency = firstDependency;
        //     _secondDependency = secondDependency;
        //     _thirdDependency = thirdDependency;
        // }
        public IChainHandler<Widget> CreateChain()
        {
            return new FirstChainHandler(new SecondChainHandler(new ThirdChainHandler(null)));
        }
    }
}

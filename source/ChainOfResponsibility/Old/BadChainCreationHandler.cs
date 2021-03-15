namespace ChainOfResponsibility.Old
{
    using System.Threading.Tasks;
    using ChainOfResponsibility.Chain;
    using ChainOfResponsibility.Problem;

    public class BadChainCreationHandler
    {
        // private readonly IFirstDependency _firstDependency;
        // private readonly ISecondDependency _secondDependency;
        // private readonly IThirdDependency _thirdDependency;

        // public BadChainCreationHandler(IFirstDependency firstDependency, ISecondDependency secondDependency, IThirdDependency thirdDependency)
        // {
        //     _firstDependency = firstDependency;
        //     _secondDependency = secondDependency;
        //     _thirdDependency = thirdDependency;
        // }
        public async Task<Widget> Handle(Widget widget)
        {
            var handlerChain = new FirstChainHandler(new SecondChainHandler(new ThirdChainHandler(null)));

            return await handlerChain.Handle(widget);
        }
    }
}

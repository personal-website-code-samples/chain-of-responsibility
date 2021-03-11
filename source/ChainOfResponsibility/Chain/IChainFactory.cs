namespace ChainOfResponsibility.New
{
    public interface IChainFactory<T>
    {
        IChainHandler<T> CreateChain();
    }
}

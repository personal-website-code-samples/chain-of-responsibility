namespace ChainOfResponsibility.New
{
    using System.Threading.Tasks;

    public interface IChainHandler<T>
    {
        Task<T> Handle(T request);
    }
}

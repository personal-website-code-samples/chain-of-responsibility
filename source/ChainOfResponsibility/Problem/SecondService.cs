namespace ChainOfResponsibility.Problem
{
    public class SecondService : ISecondService
    {
        private readonly IThirdService _thirdService;

        public SecondService(IThirdService thirdService)
        {
            _thirdService = thirdService;
        }

        public Widget DoSomething(Widget widget)
        {
            // Do something and pass to third service.
            return _thirdService.DoSomething(widget);
        }
    }
}

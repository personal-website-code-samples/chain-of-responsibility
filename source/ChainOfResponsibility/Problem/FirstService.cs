namespace ChainOfResponsibility.Problem
{
    public class FirstService : IFirstService
    {
        private readonly ISecondService _secondService;

        public FirstService(ISecondService secondService)
        {
            _secondService = secondService;
        }

        public Widget DoSomething(Widget widget)
        {
            // Do something with the widget and pass to second service.
            return _secondService.DoSomething(widget);
        }
    }
}

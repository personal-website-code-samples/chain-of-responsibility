namespace ChainOfResponsibility.Problem
{
    public class ThirdService : IThirdService
    {
        public Widget DoSomething(Widget widget)
        {
            // Complete operation and return final widget.
            return widget;
        }
    }
}

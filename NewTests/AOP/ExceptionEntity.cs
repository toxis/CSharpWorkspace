using PostSharp.Aspects;

namespace NewTests.AOP;

public class ExceptionEntity
{
    public FlowBehavior Behavior { get; set; }
    public ExceptionResult Result { get; private set; }

    public ExceptionEntity(FlowBehavior behavior)
    {
        Behavior = behavior;
    }

    [ExceptionAspect]
    public bool Method()
    {
        throw new Exception("Exception thrown");
        return false;
    }
}

public enum ExceptionResult
{
    Before,
    After
}

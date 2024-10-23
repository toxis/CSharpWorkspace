namespace NewTests.AOP;

public class LoggingEntity
{
    public bool EntryCalled { get; set; } = false;
    public bool ExitCalled { get; set; } = false;

    [LoggingAspect]
    public void Method()
    {
    }
}

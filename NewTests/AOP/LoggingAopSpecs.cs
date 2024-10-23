using Moq;

namespace NewTests.AOP;

public class LoggingAopSpecs
{
    [Test]
    public void It_calls_entry_exit_aspects()
    {
        var loggingMoq = new LoggingEntity();

        Assert.That(loggingMoq.EntryCalled, Is.False);
        Assert.That(loggingMoq.ExitCalled, Is.False);

        loggingMoq.Method();

        Assert.That(loggingMoq.EntryCalled, Is.True);
        Assert.That(loggingMoq.ExitCalled, Is.True);
    }
}

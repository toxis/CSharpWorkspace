using PostSharp.Aspects;

namespace NewTests.AOP;

public class ExceptionAopSpecs
{
    [Test]
    public void It_throws_exception()
    {
        var entity = new ExceptionEntity(FlowBehavior.RethrowException);

        Assert.Throws<Exception>(() => entity.Method());
    }

    [Test]
    public void It_returns_false_after_exception()
    {
        var entity = new ExceptionEntity(FlowBehavior.Return);

        var result = entity.Method();

        Assert.That(result, Is.False);
    }

    [Test]
    public void It_returns_true_after_exception()
    {
        var entity = new ExceptionEntity(FlowBehavior.Continue);

        var result = entity.Method();

        Assert.That(result, Is.True);
    }
}

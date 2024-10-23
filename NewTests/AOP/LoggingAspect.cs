using PostSharp.Aspects;
using PostSharp.Serialization;

namespace NewTests.AOP;

[PSerializable]
public class LoggingAspect : OnMethodBoundaryAspect
{
    public override void OnEntry(MethodExecutionArgs args)
    {
        var loggingMoq = (LoggingEntity)args.Instance;
        loggingMoq.EntryCalled = true;
    }

    public override void OnExit(MethodExecutionArgs args)
    {
        var loggingMoq = (LoggingEntity)args.Instance;
        loggingMoq.ExitCalled = true;
    }
}

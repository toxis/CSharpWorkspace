using PostSharp.Aspects;
using PostSharp.Serialization;

namespace NewTests.AOP;

[PSerializable]
public class ExceptionAspect : OnExceptionAspect
{
    public override void OnException(MethodExecutionArgs args)
    {
        Console.WriteLine($"Catched exception in: {args.Method.Name}");
        Console.WriteLine($"Exception message: {args.Exception.Message}");

        args.FlowBehavior = ((ExceptionEntity)args.Instance).Behavior;
        args.ReturnValue = args.FlowBehavior == FlowBehavior.Continue;
    }
}

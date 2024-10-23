using PostSharp.Aspects;
using PostSharp.Serialization;

namespace NewTests.AOP;

[PSerializable]
public class SecurityAspect : MethodInterceptionAspect
{
    public override void OnInvoke(MethodInterceptionArgs args)
    {
        if (((SecurityEntity)args.Instance).IsAuthorized == false)
        {
            args.ReturnValue = SecurityResult.Unauthorized;
            return;
        }

        args.Proceed();
    }
}

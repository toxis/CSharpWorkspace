using PostSharp.Aspects;
using PostSharp.Serialization;

namespace NewTests.AOP;

[PSerializable]
public class CachingAspect : MethodInterceptionAspect
{
    private Dictionary<int, int> _cache = new Dictionary<int, int>();

    public override void OnInvoke(MethodInterceptionArgs args)
    {
        var key = (int)args.Arguments[0];
        if (_cache.TryGetValue(key, out int value))
        {
            ((CachingEntity)args.Instance).Cached = true;
            args.ReturnValue = value;
            return;
        }

        args.Proceed();
        value = (int)args.ReturnValue;
        _cache[key] = value;
    }
}

namespace NewTests.AOP;

public class CachingEntity
{
    public bool Cached { get; set; } = false;

    [CachingAspect]
    public int Calculate(int value)
    {
        // Long operation
        Thread.Sleep(200);
        return value * value;
    }
}

namespace NewTests.AOP;

public class SecurityEntity
{
    public bool IsAuthorized { get; set; } = false;
    public bool AccessGranted { get; set; } = false;

    public SecurityEntity(bool isAuthorized)
    {
        IsAuthorized = isAuthorized;
    }

    [SecurityAspect]
    public SecurityResult Authenticate()
    {
        AccessGranted = true;
        return SecurityResult.Authorized;
    }
}

public enum SecurityResult
{
    Authorized = 1,
    Unauthorized = 2
}
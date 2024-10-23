namespace NewTests.AOP;

public class SecurityAopSpecs
{
    [Test]
    public void It_returns_unauthorized()
    {
        var entity = new SecurityEntity(isAuthorized: false);

        var result = entity.Authenticate();

        Assert.That(result, Is.EqualTo(SecurityResult.Unauthorized));
        Assert.That(entity.AccessGranted, Is.False);
    }

    [Test]
    public void It_returns_authorized()
    {
        var entity = new SecurityEntity(isAuthorized: true);

        var result = entity.Authenticate();

        Assert.That(result, Is.EqualTo(SecurityResult.Authorized));
        Assert.That(entity.AccessGranted, Is.True);
    }
}

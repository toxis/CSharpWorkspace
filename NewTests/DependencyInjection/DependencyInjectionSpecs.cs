using Autofac;

namespace NewTests.DependencyInjection;

public class DependencyInjectionSpecs
{
    [TestCase(typeof(LowerStringFormatter), "hello")]
    [TestCase(typeof(UpperStringFormatter), "HELLO")]
    public void It_resolves_lower_formatter(Type type, string result)
    {
        var container = new AppContainer();
        container.RegisterDependencies(builder =>
        {
            builder.RegisterType(type).As<IStringFormatter>();
        });

        var formatter = container.Resolve<IStringFormatter>();

        Assert.That(formatter.Format("Hello"), Is.EqualTo(result));
    }
}

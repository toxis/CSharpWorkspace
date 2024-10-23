using Autofac;
using NewTests.DependencyInjection;

namespace NewTests.CQRS;

public class GetUpperValueQuerySpecs
{
    [Test]
    public void It_get_upper_value()
    {
        var container = new AppContainer();
        container.RegisterDependencies(builder => builder.RegisterType<UpperStringFormatter>().As<IStringFormatter>());
        
        var query = new GetUpperValueQuery("Hello");

        var result = Messages.Dispatch(query);

        Assert.That(result, Is.EqualTo("HELLO"));
    }
}

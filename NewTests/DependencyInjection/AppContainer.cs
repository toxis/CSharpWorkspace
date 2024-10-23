using Autofac;

namespace NewTests.DependencyInjection;

public class AppContainer
{
    private static IContainer _container;

    public void RegisterDependencies(Action<ContainerBuilder> action)
    {
        var builder = new ContainerBuilder();
        action.Invoke(builder);
        _container = builder.Build();
    }

    public static object Resolve(Type type) => _container.Resolve(type);

    public static T Resolve<T>() => _container.Resolve<T>();
}

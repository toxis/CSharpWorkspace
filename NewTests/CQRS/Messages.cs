using NewTests.DependencyInjection;
using System.Reflection;

namespace NewTests.CQRS;

public static class Messages
{
    public static T Dispatch<T>(IQueryHandler<T> query)
    {
        DependencyInjection(query);
        return query.Handle();
    }

    public static void Dispatch(ICommandHandler command)
    {
        DependencyInjection(command);
        command.Handle();
    }

    private static void DependencyInjection(object obj)
    {
        foreach (var property in obj.GetType().GetProperties().Where(p => p.GetCustomAttribute(typeof(InjectAttribute)) != null))
        {
            property.SetValue(obj, AppContainer.Resolve(property.PropertyType));
        }
    }
}

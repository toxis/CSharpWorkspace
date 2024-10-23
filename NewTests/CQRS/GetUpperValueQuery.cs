using NewTests.DependencyInjection;

namespace NewTests.CQRS;

public class GetUpperValueQuery : IQueryHandler<string>
{
    private readonly string _value;

    [Inject] public IStringFormatter Formatter { get; set; }

    public GetUpperValueQuery(string value)
    {
        _value = value;
    }

    public string Handle()
    {
        return Formatter.Format(_value);
    }
}

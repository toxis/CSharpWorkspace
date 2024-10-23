namespace NewTests.CQRS;

public interface IQueryHandler<T>
{
    T Handle();
}

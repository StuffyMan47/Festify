namespace Infrastructure.DAL.BaseEntities;

public abstract class BaseEntity<T>
{
    public T Id { get; init; } = default!;
}
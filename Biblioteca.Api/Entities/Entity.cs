namespace Biblioteca.Api.Entities;

public abstract class Entity
{
    protected Entity()
    {
        Id = 0;
    }

    public int Id { get; }
}
namespace Biblioteca.Api.Entities;

public class Obra : Entity
{
    public Obra(string titulo, string fotoUrl)
    {
        Titulo = titulo;
        FotoUrl = fotoUrl;
    }

    public string FotoUrl { get; private set; }

    public string Titulo { get; private set; }
}
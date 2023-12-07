using System;

public abstract class ItemBiblioteca
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    protected internal string DescricaoInterna { get; set; }
    // protected internal:  propriedade será acessível a partir de classes derivadas e de qualquer classe no mesmo projeto que a classe base

    // Construtor
    public ItemBiblioteca(int id, string titulo)
    {
        Id = id;
        Titulo = titulo;
        DescricaoInterna = "Descrição Padrão";
    }
}
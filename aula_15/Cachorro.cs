public class Cachorro : Animal
{
    public Cachorro(string nome, int idade) : base(nome, idade)
    {
    }

    public override void EmitirSom()
    {
        Console.WriteLine($"Latido do cachorro {Nome}");
    }
}

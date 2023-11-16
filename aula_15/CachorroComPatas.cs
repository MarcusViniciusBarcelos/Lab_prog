public class CachorroComPatas : AnimalComPatas
{
    public CachorroComPatas(string nome, int idade, int numeroDePatas) : base(nome, idade, numeroDePatas)
    {
    }

    public override void EmitirSom()
    {
        ExibirNumeroDePatas();
        Console.WriteLine($"Latido do cachorro {Nome}");
    }
}

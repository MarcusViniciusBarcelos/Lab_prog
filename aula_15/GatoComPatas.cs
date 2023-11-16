public class GatoComPatas : AnimalComPatas
{
    public GatoComPatas(string nome, int idade, int numeroDePatas) : base(nome, idade, numeroDePatas)
    {
    }

    public override void EmitirSom()
    {
        ExibirNumeroDePatas();
        Console.WriteLine($"Miado do gato {Nome}");
    }
}

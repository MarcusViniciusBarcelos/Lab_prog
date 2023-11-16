public class AnimalComPatas : Animal
{
    protected int NumeroDePatas { get; set; }

    public AnimalComPatas(string nome, int idade, int numeroDePatas) : base(nome, idade)
    {
        NumeroDePatas = numeroDePatas;
    }

    protected void ExibirNumeroDePatas()
    {
        Console.WriteLine($"Número de patas: {NumeroDePatas}");
    }
}

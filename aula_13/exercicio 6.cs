class Data
{
    public int dia, mes, ano;

    public void ImprimirDataFormatada()
    {
        Console.WriteLine($"{dia:D2}/{mes:D2}/{ano:D4}");
    }
}
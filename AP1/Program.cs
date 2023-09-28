using System;

class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public double Peso { get; set; }
    public double Altura { get; set; }
    public double IMC { get; set; }
    public string FaixaEtaria { get; set; }
    public string IMCStatus {get; set; }
    public Pessoa(string nome, int idade, double altura, double peso)
    {
        Nome = nome;
        Idade = idade;
        Altura = altura;
        Peso = peso;
        IMC = Math.Round(peso / Math.Pow(altura, 2), 2);
        DeterminarFaixaEtaria();
        StatusIMC();
    }

    private void DeterminarFaixaEtaria()
    {
        if (Idade < 12)
            FaixaEtaria = "criança";
        else if (Idade < 18)
            FaixaEtaria = "adolescente";
        else if (Idade < 60)
            FaixaEtaria = "adulto";
        else
            FaixaEtaria = "idoso";
    }

    public string StatusIMC()
    {
        if (IMC < 18.5)
            return IMCStatus = "abaixo do peso";
        else if (IMC < 25)
            return IMCStatus = "com o peso normal";
        else if (IMC < 30)
            return IMCStatus = "acima do peso";
        else if (IMC < 40)
            return IMCStatus = "obeso";
        else
            return IMCStatus = "com obesidade Grave";
    }

    public void ExibirRelatorio()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Idade: {Idade} anos");
        Console.WriteLine($"IMC: {IMC}");
        Console.WriteLine($"Faixa Etária: {FaixaEtaria}");
        Console.WriteLine($"Categoria IMC: {IMCStatus}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        do
        {
            Console.Write("Digite o nome da pessoa: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a idade da pessoa: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Digite a altura da pessoa (em metros, separado por virgula): ");
            double altura = double.Parse(Console.ReadLine());

            Console.Write("Digite o peso da pessoa (em kg, separado por virgula): ");
            double peso = double.Parse(Console.ReadLine());

            Pessoa pessoa = new Pessoa(nome, idade, altura, peso);
            pessoa.StatusIMC();

            Console.WriteLine("\nRelatório da Pessoa:");
            pessoa.ExibirRelatorio();

            Console.Write("\nDeseja gerar um novo relatório para outra pessoa? (S/N): ");
            string resposta = Console.ReadLine().ToUpper();

            if (resposta != "S")
                break;

        } while (true);
    }
}

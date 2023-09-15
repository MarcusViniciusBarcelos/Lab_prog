class Program
{
    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            
            Console.Write("Digite o nome do estudante: ");
            string nome = Console.ReadLine();

            
            Console.Write("Digite a primeira nota: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            double media = (nota1 + nota2 + nota3) / 3.0;
            string resultado = (media >= 7.0) ? "Aprovado" : "Reprovado";

            Console.WriteLine(new string('-', 100));
            Console.WriteLine("Relatório de Desempenho:");
            Console.WriteLine(new string('-', 100));
            Console.WriteLine("{0,-20} | {1,-8} | {2,-8} | {3,-8} | {4,-8}", "Nome do Estudante", "Nota 1", "Nota 2", "Nota 3", "Média");
            Console.WriteLine(new string('-', 100));
            Console.WriteLine("{0,-20} | {1,-8:F2} | {2,-8:F2} | {3,-8:F2} | {4,-8:F2} | {5,-8}", nome, nota1, nota2, nota3, media, resultado);
            Console.WriteLine(new string('-', 100));
            Console.Write("\nDeseja gerar um novo relatório para outro estudante? (S/N): ");
            string resposta = Console.ReadLine().ToLower();

            if (resposta != "s")
            {
                continuar = false;
            }
        }

        Console.WriteLine(new string('-', 100));
    }
}

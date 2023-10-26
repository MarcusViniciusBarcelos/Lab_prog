using System;

class Program
{
    static void Main()
    {
        int opcao;

        do
        {
            MostrarMenu();
            opcao = LerOpcao();

            switch (opcao)
            {
                case 1:
                    ExecutarExercicio1();
                    break;

                case 2:
                    ExecutarExercicio2();
                    break;

                case 3:
                    ExecutarExercicio3();
                    break;

                case 4:
                    ExecutarExercicio4();
                    break;

                case 5:
                    ExecutarExercicio5();
                    break;

                case 6:
                    ExecutarExercicio6();
                    break;

                case 7:
                    ExecutarExercicio7();
                    break;

                case 8:
                    ExecutarExercicio8();
                    break;

                case 0:
                    Console.WriteLine("Programa encerrado.");
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            Console.WriteLine();
        } while (opcao != 0);
    }

    static void MostrarMenu()
    {
        Console.WriteLine("Escolha um exercício para executar:");
        Console.WriteLine("1. Exercício 1: Classe Mensagem");
        Console.WriteLine("2. Exercício 2: Classe Quadrado");
        Console.WriteLine("3. Exercício 3: Classe CalculadoraSimples");
        Console.WriteLine("4. Exercício 4: Classe Concatenador");
        Console.WriteLine("5. Exercício 5: Classe ConversorTemperatura");
        Console.WriteLine("6. Exercício 6: Classe Data");
        Console.WriteLine("7. Exercício 7: Classe CalculadoraArea");
        Console.WriteLine("8. Exercício 8: Classe Tabuada");
        Console.WriteLine("0. Sair");
    }

    static int LerOpcao()
    {
        Console.Write("Digite o número da opção desejada: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    static void ExecutarExercicio1()
    {
        var mensagem = new Mensagem();
        mensagem.Exibir();
    }

    static void ExecutarExercicio2()
    {
        var quadrado = new Quadrado { numero = 5 };
        quadrado.CalcularEImprimirQuadrado();
    }

    static void ExecutarExercicio3()
    {
        var calculadora = new CalculadoraSimples();
        Console.WriteLine("Soma (2 + 3): " + calculadora.Somar(2, 3));
        Console.WriteLine("Soma (2 + 3 + 4): " + calculadora.Somar(2, 3, 4));
    }

    static void ExecutarExercicio4()
    {
        var concatenador = new Concatenador();
        Console.WriteLine("Concatenação (Hello, World!): " + concatenador.Concatenar("Hello, ", "World!"));
        Console.WriteLine("Concatenação (C#, is, awesome!): " + concatenador.Concatenar("C#, ", "is, ", "awesome!"));
    }

    static void ExecutarExercicio5()
    {
        var conversor = new ConversorTemperatura { temperaturaCelsius = 25 };
        Console.WriteLine("Temperatura em Fahrenheit: " + conversor.ConverterParaFahrenheit());
    }

    static void ExecutarExercicio6()
    {
        var data = new Data { dia = 26, mes = 10, ano = 2023 };
        data.ImprimirDataFormatada();
    }

    static void ExecutarExercicio7()
    {
        var calculadoraArea = new CalculadoraArea();
        Console.WriteLine("Área do círculo (raio = 5): " + calculadoraArea.CalcularArea(5));
        Console.WriteLine("Área do retângulo (base = 4, altura = 6): " + calculadoraArea.CalcularArea(4, 6));
    }

    static void ExecutarExercicio8()
    {
        var tabuada = new Tabuada { numeroBase = 7 };
        tabuada.ImprimirTabuada();
    }
}

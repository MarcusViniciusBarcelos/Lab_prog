namespace Exercicios
{
    class MenuExercicios
    {
        public static void MostrarMenu()
        {
            Console.WriteLine("Escolha um exercício:");
            Console.WriteLine("1. Exercício 1");
            Console.WriteLine("2. Exercício 2");
            Console.WriteLine("3. Exercício 3");
            Console.WriteLine("4. Exercício 4");
            Console.WriteLine("5. Exercício 5");
            Console.WriteLine("6. Exercício 6");
            Console.WriteLine("7. Exercício 7");
            Console.WriteLine("0. Sair");
        }

        public static void ExecutarExercicio(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    Exercicios.Exercicio1();
                    break;
                case 2:
                    Exercicios.Exercicio2();
                    break;
                case 3:
                    Exercicios.Exercicio3();
                    break;
                case 4:
                    Exercicios.Exercicio4();
                    break;
                case 5:
                    Exercicios.Exercicio5();
                    break;
                case 6:
                    Exercicios.Exercicio6();
                    break;
                case 7:
                    Exercicios.Exercicio7();
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }
    }
}

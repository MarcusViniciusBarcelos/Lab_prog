
namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                MenuExercicios.MostrarMenu();
                Console.Write("Escolha uma opção: ");
                int opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 0)
                {
                    continuar = false;
                    Console.WriteLine("Saindo...");
                }
                else
                {
                    MenuExercicios.ExecutarExercicio(opcao);
                }
            }
        }
    }
}
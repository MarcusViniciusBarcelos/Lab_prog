using System;

class Program
{
    static Biblioteca biblioteca = new Biblioteca();

    static void Main()
    {
        bool sair = false;

        while (!sair)
        {
            Console.WriteLine("==== Menu ====");
            Console.WriteLine("1. Adicionar Livro");
            Console.WriteLine("2. Buscar Livro por Título");
            Console.WriteLine("3. Buscar Livro por ID");
            Console.WriteLine("4. Exibir Descrição Interna do Livro");
            Console.WriteLine("5. Remover Livro");
            Console.WriteLine("6. Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    AdicionarLivro();
                    break;
                case "2":
                    BuscarLivroPorTitulo();
                    break;
                case "3":
                    BuscarLivroPorId();
                    break;
                case "4":
                    ExibirDescricaoInterna();
                    break;
                case "5":
                    RemoverLivro();
                    break;
                case "6":
                    sair = true;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void AdicionarLivro()
    {
        Console.Write("Digite o ID do livro: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Digite o título do livro: ");
        string titulo = Console.ReadLine();

        Console.Write("Digite o autor do livro: ");
        string autor = Console.ReadLine();

        Console.Write("Digite a Descrição Interna do livro (pressione Enter para usar a descrição padrão): ");
        string descricaoInterna = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(descricaoInterna))
        {
            descricaoInterna = "Descrição padrão";
        }

        Livro novoLivro = new Livro(id, titulo, autor)
        {
            DescricaoInterna = descricaoInterna
        };

        biblioteca.AdicionarItem(novoLivro);

        Console.WriteLine($"Livro '{titulo}' adicionado à biblioteca.");
    }

    static void BuscarLivroPorTitulo()
    {
        Console.Write("Digite o título do livro a ser buscado: ");
        string titulo = Console.ReadLine();

        ItemBiblioteca itemEncontrado = biblioteca.BuscarItemPorTitulo(titulo);

        if (itemEncontrado != null)
        {
            Console.WriteLine($"Livro encontrado: {itemEncontrado.Titulo}");
            if (itemEncontrado is Livro)
            {
                ((Livro)itemEncontrado).ExibirDescricaoInterna();
            }
        }
        else
        {
            Console.WriteLine("Livro não encontrado.");
        }
    }

    static void BuscarLivroPorId()
    {
        Console.Write("Digite o ID do livro a ser buscado: ");
        int id = int.Parse(Console.ReadLine());

        ItemBiblioteca itemEncontrado = biblioteca.BuscarItemPorId(id);

        if (itemEncontrado != null)
        {
            Console.WriteLine($"Livro encontrado: {itemEncontrado.Titulo}");
            if (itemEncontrado is Livro)
            {
                ((Livro)itemEncontrado).ExibirDescricaoInterna();
            }
        }
        else
        {
            Console.WriteLine("Livro não encontrado.");
        }
    }

    static void ExibirDescricaoInterna()
    {
        Console.Write("Digite o ID do livro para exibir a Descrição Interna: ");
        int id = int.Parse(Console.ReadLine());

        ItemBiblioteca itemEncontrado = biblioteca.BuscarItemPorId(id);

        if (itemEncontrado != null && itemEncontrado is Livro)
        {
            Console.WriteLine($"Descrição Interna do Livro: {((Livro)itemEncontrado).DescricaoInterna}");
        }
        else
        {
            Console.WriteLine("Livro não encontrado ou não é um livro.");
        }
    }

    static void RemoverLivro()
    {
        Console.Write("Digite o ID do livro a ser removido: ");
        int id = int.Parse(Console.ReadLine());

        ItemBiblioteca livroRemovido = biblioteca.BuscarItemPorId(id);

        if (livroRemovido != null)
        {
            biblioteca.RemoverItem(livroRemovido);
            Console.WriteLine($"Livro '{livroRemovido.Titulo}' removido da biblioteca.");
        }
        else
        {
            Console.WriteLine("Livro não encontrado.");
        }
    }
}
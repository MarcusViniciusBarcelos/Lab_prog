using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Campeonato> campeonatos = new List<Campeonato>();

        // Criação de algumas equipes e jogadores para teste
        Equipe equipeA = new Equipe("EquipeA");
        equipeA.AdicionarJogador(new Jogador("Jogador1A", "Nick1A"));
        equipeA.AdicionarJogador(new Jogador("Jogador2A", "Nick2A"));
        equipeA.AdicionarJogador(new Jogador("Jogador3A", "Nick3A"));
        equipeA.AdicionarJogador(new Jogador("Jogador4A", "Nick4A"));
        equipeA.AdicionarJogador(new Jogador("Jogador5A", "Nick5A"));

        Equipe equipeB = new Equipe("EquipeB");
        equipeB.AdicionarJogador(new Jogador("Jogador1B", "Nick1B"));
        equipeB.AdicionarJogador(new Jogador("Jogador2B", "Nick2B"));
        equipeB.AdicionarJogador(new Jogador("Jogador3B", "Nick3B"));
        equipeB.AdicionarJogador(new Jogador("Jogador4B", "Nick4B"));
        equipeB.AdicionarJogador(new Jogador("Jogador5B", "Nick5B"));

        campeonatos.Add(new Campeonato("CampeonatoTeste"));
        campeonatos[0].EquipesParticipantes.Add(equipeA);
        campeonatos[0].EquipesParticipantes.Add(equipeB);

        while (true)
        {
            Console.WriteLine("1. Criar Campeonato");
            Console.WriteLine("2. Adicionar Equipe a Campeonato");
            Console.WriteLine("3. Adicionar Jogador a Equipe");
            Console.WriteLine("4. Iniciar Partida");
            Console.WriteLine("5. Ver Classificação");
            Console.WriteLine("6. Sair");

            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Digite o nome do campeonato:");
                    string nomeCampeonato = Console.ReadLine();
                    campeonatos.Add(new Campeonato(nomeCampeonato));
                    break;

                case 2:
                    Console.WriteLine("Digite o nome da equipe:");
                    string nomeEquipe = Console.ReadLine();
                    Console.WriteLine("Digite o nome do campeonato:");
                    string nomeCampeonatoEquipe = Console.ReadLine();
                    Campeonato campeonatoEquipe = campeonatos.Find(c => c.NomeCampeonato == nomeCampeonatoEquipe);
                    if (campeonatoEquipe != null)
                    {
                        campeonatoEquipe.EquipesParticipantes.Add(new Equipe(nomeEquipe));
                    }
                    else
                    {
                        Console.WriteLine("Campeonato não encontrado.");
                    }
                    break;

                case 3:
                    Console.WriteLine("Digite o nome do jogador:");
                    string nomeJogador = Console.ReadLine();
                    Console.WriteLine("Digite o nickname do jogador:");
                    string nicknameJogador = Console.ReadLine();
                    Console.WriteLine("Digite o nome da equipe:");
                    string nomeEquipeJogador = Console.ReadLine();
                    Equipe equipeJogador = campeonatos.SelectMany(c => c.EquipesParticipantes).FirstOrDefault(e => e.NomeEquipe == nomeEquipeJogador);
                    if (equipeJogador != null)
                    {
                        equipeJogador.AdicionarJogador(new Jogador(nomeJogador, nicknameJogador));
                    }
                    else
                    {
                        Console.WriteLine("Equipe não encontrada.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Digite o nome da primeira equipe:");
                    string nomeEquipe1 = Console.ReadLine();
                    Console.WriteLine("Digite o nome da segunda equipe:");
                    string nomeEquipe2 = Console.ReadLine();
                    Equipe equipe1 = campeonatos.SelectMany(c => c.EquipesParticipantes).FirstOrDefault(e => e.NomeEquipe == nomeEquipe1);
                    Equipe equipe2 = campeonatos.SelectMany(c => c.EquipesParticipantes).FirstOrDefault(e => e.NomeEquipe == nomeEquipe2);
                    if (equipe1 != null && equipe2 != null)
                    {
                        campeonatos[0].IniciarPartida(equipe1, equipe2);
                    }
                    else
                    {
                        Console.WriteLine("Equipe não encontrada.");
                    }
                    break;

                case 5:
                    Console.WriteLine("Digite o nome do campeonato:");
                    string nomeCampeonatoClassificacao = Console.ReadLine();
                    Campeonato campeonatoClassificacao = campeonatos.Find(c => c.NomeCampeonato == nomeCampeonatoClassificacao);
                    if (campeonatoClassificacao != null)
                    {
                        campeonatoClassificacao.Classificacao();
                    }
                    else
                    {
                        Console.WriteLine("Campeonato não encontrado.");
                    }
                    break;

                case 6:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Escolha inválida. Tente novamente.");
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

public class Campeonato
{
    public string NomeCampeonato { get; set; }
    public List<Equipe> EquipesParticipantes { get; private set; }

    public Campeonato(string nomeCampeonato)
    {
        NomeCampeonato = nomeCampeonato;
        EquipesParticipantes = new List<Equipe>();
    }

    // Método para iniciar uma partida entre duas equipes
    public void IniciarPartida(Equipe e1, Equipe e2)
    {
        // Verifica se ambas as equipes têm exatamente 5 jogadores
        if (e1.Jogadores.Count == 5 && e2.Jogadores.Count == 5)
        {
            Console.WriteLine($"Iniciando partida entre {e1.NomeEquipe} e {e2.NomeEquipe}...");
             // Chama o método Jogar() para cada jogador de ambas as equipes
            foreach (var jogador in e1.Jogadores.Concat(e2.Jogadores))
            {
                jogador.Jogar();
            }
        }
        else
        {
            Console.WriteLine("Uma equipe deve ter exatamente 5 jogadores para participar de uma partida.");
        }
    }

    // Método para exibir a classificação do campeonato
    public void Classificacao()
    {
        Console.WriteLine($"Classificação do campeonato {NomeCampeonato}:");
        // Ordena as equipes de acordo com a soma dos pontos de seus jogadores
        var classificacaoOrdenada = EquipesParticipantes.OrderByDescending(equipe => equipe.PontosTotal());
        // Exibe a classificação ordenada
        foreach (var equipe in classificacaoOrdenada)
        {
            Console.WriteLine($"{equipe.NomeEquipe}: {equipe.PontosTotal()} pontos");
        }
    }
}

using System;
using System.Collections.Generic;

public class Equipe
{
    public string NomeEquipe { get; set; }
    public List<Jogador> Jogadores { get; private set; }

    public Equipe(string nomeEquipe)
    {
        NomeEquipe = nomeEquipe;
        Jogadores = new List<Jogador>();
    }
    // Método para calcular a pontuação total da equipe somando os pontos de seus jogadores
    public int PontosTotal()
    {
        int total = 0;
        foreach (var jogador in Jogadores)
        {
            total += jogador.Pontos;
        }
        return total;
        
    }
    // Método para adicionar um jogador à equipe, verificando se a equipe já tem 5 jogadores
    public void AdicionarJogador(Jogador jogador)
    {
        if (Jogadores.Count < 5)
        {
            Jogadores.Add(jogador);
            Console.WriteLine($"{jogador.Nickname} foi adicionado à equipe {NomeEquipe}.");
        }
        else
        {
            Console.WriteLine($"Não é possível adicionar mais jogadores à equipe {NomeEquipe}.");
        }
    }
}

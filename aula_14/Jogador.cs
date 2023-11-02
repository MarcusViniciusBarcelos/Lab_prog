using System;

public class Jogador
{
    public string Nome { get; set; }
    public string Nickname { get; set; }
    public int Pontos { get; private set; }

    public Jogador(string nome, string nickname)
    {
        Nome = nome;
        Nickname = nickname;
        Pontos = 0;
    }
    
    // Método para simular a atuação do jogador em uma partida
    public void Jogar()
    {
        Random random = new Random();
        int pontosNaPartida = random.Next(1, 101);
        Pontos += pontosNaPartida;
        Console.WriteLine($"{Nickname} ganhou {pontosNaPartida} pontos na partida!");
    }
}

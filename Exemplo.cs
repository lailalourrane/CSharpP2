using System;
using System.Diagnostics;

public enum TipoCarta
{
    Pokemon, Treinador, Energia
}

public class AtividadeCartas
{
    public void Executar()
    {
        TipoCarta cartaAtual = TipoCarta.Treinador;
    

        switch (cartaAtual)
        {
            case TipoCarta.Pokemon:
                Console.WriteLine("Carta de Pokémon");
            break;
            case TipoCarta.Treinador:
                Console.WriteLine("Carta de Treinador");
            break;
            case TipoCarta.Energia:
                Console.WriteLine("Carta de Energia");
            break;
            default:
                Console.WriteLine("Tipo de carta desconhecido");
            break;
        }
    }
}
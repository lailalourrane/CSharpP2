using System;

public enum RegiaoDex
{
    Kanto, Johto, Hoenn, Kalos
}

public class FiltroRestrito
{
    public void Executar()
    {
        RegiaoDex regiaoAtual = RegiaoDex.Kalos;

        switch (regiaoAtual)
        {
            case RegiaoDex.Kanto:
                Console.WriteLine("Aplicando filtro restrito: exibindo apenas os pokemons originais de Kanto");
            break;
            case RegiaoDex.Johto:
                Console.WriteLine("Aplicando filtro restrito: exibindo apenas os pokemons originais de Johto");
            break;
            case RegiaoDex.Hoenn:
                Console.WriteLine("Aplicando filtro restrito: exibindo apenas os pokemons originais de Hoenn");
            break;
            case RegiaoDex.Kalos:
                Console.WriteLine("Aplicando filtro restrito: exibindo apenas os pokemons originais de Kalos");
            break;
            default:
                Console.WriteLine("Região não encontrada!");
            break;
        }
    }
}
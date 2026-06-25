using System;

public enum MetodoFichario
{
    NumeracaoNacional, OrdemAlfabetica, MetodoMichi
}

public class Organizacao
{
    public void Executar()
    {
        MetodoFichario novoMetodo = MetodoFichario.MetodoMichi;

        switch (novoMetodo)
        {
            case MetodoFichario.NumeracaoNacional:
                Console.WriteLine("Organização Iniciada: Estrutura de organização seguindo a númeração da Dex Nacional");
            break;
            case MetodoFichario.OrdemAlfabetica:
                Console.WriteLine("Organização Iniciada: Estrutura de organização seguindo a ordem alfabética");
            break;
            case MetodoFichario.MetodoMichi:
                Console.WriteLine("Organização Iniciada: Estrutura de organização rigidamente limitado a 40 páginas para tudo");
            break;
            default:
                Console.WriteLine("Método de organização inválido/indispónivel");
            break;
        }
    }
}
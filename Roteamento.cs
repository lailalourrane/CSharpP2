using System;

public enum AbaNavegacao {
    Dashboard, MeusDecks, WishList, Progresso
}

public class Roteamento
{
    public void Executar()
    {
        AbaNavegacao novaNavegacao = AbaNavegacao.Dashboard;

        switch (novaNavegacao)
        {
            case AbaNavegacao.Dashboard:
                Console.WriteLine("Carregando o seu Dashboard de Cartas Pokémons...");
            break;
            case AbaNavegacao.MeusDecks:
                Console.WriteLine("Carregando o seus Decks Competitivos de Pokémon...");
            break;
            case AbaNavegacao.WishList:
                Console.WriteLine("Carregando sua Wishlist de cartas avulsas...");
            break;
            case AbaNavegacao.Progresso:
                Console.WriteLine("Carregando o seu Progresso nas Regiões...");
            break;
            default:
                Console.WriteLine("Operação inválida, escolha uma opção válida!");
            break;
        }
    }
}
using System;

public enum IdiomaSistema
{
    Ingles, Espanhol, Frances, Alemao
}

public class LocTraducao
{
    public void Executar()
    {
        IdiomaSistema novoIdioma = IdiomaSistema.Alemao;

        switch (novoIdioma)
        {
            case IdiomaSistema.Ingles:
                Console.WriteLine("The game is loading....");
            break;
            case IdiomaSistema.Espanhol:
                Console.WriteLine("El juego se está cargando....");
            break;
            case IdiomaSistema.Alemao:
                Console.WriteLine("Spiel wird geladen....");
            break;
            case IdiomaSistema.Frances:
                Console.WriteLine("Chargement de jue....");
            break;
            default:
                Console.WriteLine("Idioma Inválido!");
            break;
        }
    }
}
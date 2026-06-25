using System;

public enum SeveridadeBug
{
    Baixa, Media, Alta, Critica
}

public class BugReport
{
    public void Executar()
    {
        SeveridadeBug novoBug = SeveridadeBug.Critica;

        switch (novoBug)
        {
            case SeveridadeBug.Baixa:
                Console.WriteLine("O bug tem nivel de severidade baixa");
            break;
            case SeveridadeBug.Media:
                Console.WriteLine("O bug tem nivel de severidade média");
            break;
            case SeveridadeBug.Alta:
                Console.WriteLine("O bug tem nivel de severidade alta");
            break;
            case SeveridadeBug.Critica:
                Console.WriteLine("O bug tem nivel de severidade Critica!");
            break;
            default:
                Console.WriteLine("Severidade não documentada");
            break;
        }
    }
}
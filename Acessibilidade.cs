using System;

public enum TemaTransparencia
{
    Claro, Escuro, AltoConstraste, Minimalista
}

public class Acessibilidade
{
    public void Executar()
    {
        TemaTransparencia novaTransparencia = TemaTransparencia.Minimalista;

        switch (novaTransparencia)
        {
            case TemaTransparencia.Claro:
                Console.WriteLine("Aplicando paleta de cores para o tema claro...");
            break;
            case TemaTransparencia.Escuro:
                Console.WriteLine("Aplicando paleta de cores para o tema escuro...");
            break;
            case TemaTransparencia.AltoConstraste:
                Console.WriteLine("Aplicando paleta de cores para o recurso de acessibilidade Alto Constrate...");
            break;
            case TemaTransparencia.Minimalista:
                Console.WriteLine("Aplicando paleta de cores limpa, tipografia fluida e removendo poluição visual da tela...");
            break;
            default:
                Console.WriteLine("Tema não encontrado/disponivel");
            break;
        }
    }
}
using System;

public enum StatusInscricao
{
    Rascunho, EmAnalise, Aprovada, Cancelada
}

public class TrackerVolun
{
    public void Executar()
    {
        StatusInscricao novaInscricao = StatusInscricao.Aprovada;

        switch (novaInscricao)
        {
            case StatusInscricao.Rascunho:
                Console.WriteLine("Sua inscrição está em rascunho, volte e finalize antes da data de encerramento");
            break;
            case StatusInscricao.EmAnalise:
                Console.WriteLine("Sua inscrição está em Ánalise, ate o dia XX de XX retornaremos o resultado pelo email informado na inscrição");
            break;
            case StatusInscricao.Aprovada:
                Console.WriteLine("Sua inscrição foi APROVADA, por favor siga as instruções enviadas por email e boa sorte!");
            break;
            case StatusInscricao.Cancelada:
                Console.WriteLine("Sua inscrição foi CANCELADA, sentimos muito mas sinta-se convidado(a) a tentar novamente no nosso próximo voluntáriado!");
            break;
            default:
                Console.WriteLine("Inscrição não encontrada, verifique se o número de inscrição está correto");
            break;    
        }
    }
}
using System;

public enum CodigoErro
{
    Erro43, Erro51, Erro74, Timeout
}

public class SuporteTecnico
{
    public void Executar()
    {
        CodigoErro novoErro = CodigoErro.Erro74;

        switch (novoErro)
        {
            case CodigoErro.Erro43:
                Console.WriteLine("Erro 43, por favor acesse nosso site para se informar sobre o erro");
            break;
            case CodigoErro.Erro51:
                Console.WriteLine("Erro 51, por favor acesse nosso site para se informar sobre o erro");
            break;
            case CodigoErro.Erro74:
                Console.WriteLine("Erro 74, por favor acesse nosso site para se informar sobre o erro");
            break;
            case CodigoErro.Timeout:
                Console.WriteLine("Timeout, o tempo de execução foi encerrado");
            break;
            default:
                Console.WriteLine("Erro não identificado, entre em contato com o suporte");
            break;
        }
    }
}
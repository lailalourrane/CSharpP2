using System;

public class Program
{
    public static void Main()
    {
        BugReport novoBug= new BugReport();
        novoBug.Executar();

        FiltroRestrito regiaoDex = new FiltroRestrito();
        regiaoDex.Executar();

        SuporteTecnico novoErro = new SuporteTecnico();
        novoErro.Executar();

        LivroReceita novoCrafting = new LivroReceita();
        novoCrafting.Executar();

        LocTraducao novoIdioma = new LocTraducao();
        novoIdioma.Executar();

        EstrategiaTurnos novaEstrategia = new EstrategiaTurnos();
        novaEstrategia.Executar();

        Acessibilidade novoTema = new Acessibilidade();
        novoTema.Executar();

        Organizacao novaOrganizacao = new Organizacao();
        novaOrganizacao.Executar();

        TrackerVolun novaInscricao = new TrackerVolun();
        novaInscricao.Executar();

        Roteamento novaNavegacao = new Roteamento();
        novaNavegacao.Executar();
    }
}
using System;

public enum CategoriaCrafting
{
    Pocao, Equipamento, Runa, Grimorio
}

public class LivroReceita
{
    public void Executar()
    {
        CategoriaCrafting novoCrafting = CategoriaCrafting.Runa;

        switch (novoCrafting)
        {
            case CategoriaCrafting.Pocao:
                Console.WriteLine("A combinação para fazer a Poção de Invisibilidade é: 1 Lascas de Aunphor e 1 Sal de Pris");
            break;
            case CategoriaCrafting.Equipamento:
                Console.WriteLine("A combinação para fazer o Equipamento Nivel 3 é: 2 Carapaça de Thernos");
            break;
            case CategoriaCrafting.Runa:
                Console.WriteLine("A combinação para fazer a Runa do Atormentado é: 1 Pedaço de Alma Atormentada e 1 Pedra do Mirtes");
            break;
            case CategoriaCrafting.Grimorio:
                Console.WriteLine("A combinação para fazer o Grimorio 'Perdão de Azelia' : 1 Livro encantado e 1 Fio de Cabelo de Azelia");
            break;
            default:
                Console.WriteLine("Crafting Inválido!");
            break;
        }
    }
}
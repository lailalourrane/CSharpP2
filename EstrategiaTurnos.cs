using System;

public enum TaticaBatalha
{
    AtaqueTotal, FocoCura, EstrategiaAndar70
}

public class EstrategiaTurnos
{
    public void Executar()
    {
        TaticaBatalha novaTatica = TaticaBatalha.EstrategiaAndar70;

        switch (novaTatica)
        {
            case TaticaBatalha.AtaqueTotal:
                Console.WriteLine("Para cima! Ataque total no inimigo");
            break;
            case TaticaBatalha.FocoCura:
                Console.WriteLine("Personagem com HP baixo, cura necessária");
            break;
            case TaticaBatalha.EstrategiaAndar70:
                Console.WriteLine("Atenção, andar perigoso com alto risco de aparição do Amaldiçoado, encontre rápidamente a saída antes da sua aparição!");
            break;
            default:
                Console.WriteLine("Tática Inválida!");
            break;
        }
    }
}
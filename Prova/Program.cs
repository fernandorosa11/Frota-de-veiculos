// Instituto Federal do Espírito Santo
// Prova 1 | Programação Orientada a Objeto
// Professor Danilo Azeredo
// Arthur Matos e Fernando Rosa

using Prova;

internal class Program
{
    private static void Main(string[] args)
    {

        //Variáveis para calcular o consumo médio
        FrotaAtual.CriaFrota();
        double soma = 0;
        int quantidade = 0;

        Console.WriteLine("Frota: ");
        // Método para percorrer cada Modelo de veículo na frota e printar no Console
        foreach(Modelo veiculo in FrotaAtual.veiculos)
        {
            Console.WriteLine(veiculo);
            Console.WriteLine("------------------------------------------------------------------------");
        }
        // Método para percorrer cada consumo de cada veículo da frota
        foreach (IConsome veiculo in FrotaAtual.veiculos)
        {
            soma += veiculo.ConsumoMedio();
            quantidade += 1;
        }


        Console.WriteLine("O Consumo médio é de " + soma/quantidade + "Km/l!");
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    abstract class Modelo
    {

        // Declaração das propriedades públicas com os setters privados
        public Fabricante Fab { private set; get; }
        public string Descricao { private set; get; }
        public int Combustivel { private set; get; }
        public double ConsumoCidade { private set; get; }
        public double ConsumoEstrada { private set; get; }

        // Construtor público para inicializar as propriedades
        public Modelo(Fabricante fab, string descricao, int combustivel, double consumoCidade, double consumoEstrada)
        {
            Fab = fab;
            Descricao = descricao;
            Combustivel = combustivel;
            ConsumoCidade = consumoCidade;
            ConsumoEstrada = consumoEstrada;
        }

        // Método ToString() que retorna as informações de acordo com os exemplos.
        public override string ToString()
        {
            string frase = "";
            if(this is ModeloCarro carro)
            {
                frase = ("Automóvel: " + carro.Fab.Nome + " " + carro.Descricao + ", " + carro.NumeroDePortas + " portas," + " estilo " + TextosdeReferencia.getEstiloCarro(carro.Estilo) + ", combustível "+ TextosdeReferencia.getCombustivel(carro.Combustivel) + ", consumo urbano: " + carro.ConsumoCidade + "Km/l," + " consumo rodoviário: " + carro.ConsumoEstrada + "Km/l.");

            }else if(this is ModeloMoto moto)
            {
                frase = ("Motocicleta: " + moto.Fab.Nome + " " + moto.Descricao + ", " + moto.NumeroDePassageiros + " passageiros," +  " estilo " + TextosdeReferencia.getEstiloMoto(moto.Estilo) + ", combustível "+ TextosdeReferencia.getCombustivel(moto.Combustivel) + ", consumo urbano: " + moto.ConsumoCidade + "Km/l, " + "consumo rodoviário: " + moto.ConsumoEstrada + "Km/l.");

            }
            return frase;
        }

    }
}

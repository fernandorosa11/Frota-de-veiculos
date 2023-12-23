using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    class ModeloCarro:Modelo, IConsome
    {
        // Declaração das propriedades únicas de carro com setter privado
        public int NumeroDePortas { private set; get; }
        public int Estilo { private set; get; }

        // Construtor público que agrupa as propriedades únicas do carro com os padrões de Modelo
        public ModeloCarro(int numeroDePortas, int estilo, Fabricante fab, string descricao, int combustivel, double consumoCidade, double consumoEstrada) : base(fab, descricao, combustivel, consumoCidade,consumoEstrada)
        {
            NumeroDePortas = numeroDePortas;
            Estilo = estilo;
        }

        // Cálculo do consumo médio, o qual é Herança de IConsome.
        public double ConsumoMedio()
        {
            double consm = (ConsumoCidade + ConsumoEstrada) / 2;
            return consm;

        }
    }
}

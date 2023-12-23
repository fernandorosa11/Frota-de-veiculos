using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    internal class ModeloMoto :Modelo, IConsome
    {
        // Declaração das propriedades únicas de moto com setter privado

        public int NumeroDePassageiros { private set; get; }
        public int Estilo { private set; get; }

        // Construtor público que agrupa as propriedades únicas da moto com os padrões de Modelo

        public ModeloMoto(int numeroDePassageiros, int estilo, Fabricante fab, string descricao, int combustivel, double consumoCidade, double consumoEstrada) : base(fab, descricao, combustivel, consumoCidade, consumoEstrada)
        {
            NumeroDePassageiros = numeroDePassageiros;
            Estilo = estilo;
        }
        // Cálculo do consumo médio, o qual é Herança de IConsome.

        public double ConsumoMedio()
        {
            double consm = ((ConsumoCidade + ConsumoEstrada) / 2)*1.2; // Para moto, acrescido por 20%
            return consm;

        }
    }
}

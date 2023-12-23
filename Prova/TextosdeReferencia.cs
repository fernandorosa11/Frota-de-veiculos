using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Prova
{
    public static class TextosdeReferencia
    {

        // Declaração dos vetores publicos e estáticos com os nomes requeridos.
        static string[] EstiloCarro = new string[4] {"Sedan", "Hatch", "Coupe", "SUV"};
        static string[] EstiloMoto = new string[2] { "Street", "Trail" };
        static string[] Combustivel = new string[3] { "Álcool", "Gasolina", "Flex" };

        // Métodos que retornam os valores destes vetores, que são utilizados em Modelo.cs
        static public string getEstiloCarro(int i)
        {
            return EstiloCarro[i];
        }
        static public string getEstiloMoto(int i)
        {
            return EstiloMoto[i];
        }
        static public string getCombustivel(int i)
        {
            return Combustivel[i];
        }

    }
    
}

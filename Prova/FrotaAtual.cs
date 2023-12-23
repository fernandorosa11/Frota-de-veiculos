using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    static class FrotaAtual
    {
        //Definição das propriedades dos vetores solicitados com base nas classes Fabricante e Modelo
        static public Fabricante[] fabricante { private set; get;}
        static public Modelo[] veiculos { private set; get; }

        //Método estático para criar a frota
        public static void CriaFrota()
        {
            fabricante = new Fabricante[3];
            veiculos = new Modelo[6];

            fabricante[0] = new Fabricante("Honda");
            fabricante[1] = new Fabricante("GM");
            fabricante[2] = new Fabricante("VW");


            veiculos[0] = new ModeloCarro(5, 1, fabricante[1],"Onyx",2,10,15);
            veiculos[1] = new ModeloCarro(5, 1, fabricante[2], "Gol", 2, 9, 13);
            veiculos[2] = new ModeloCarro(4, 0, fabricante[1], "Cruze", 1, 5, 10);
            veiculos[3] = new ModeloCarro(4, 0, fabricante[2], "Virtus", 1, 9.5, 13.5);
            veiculos[4] = new ModeloMoto(2, 0, fabricante[0], "CG", 1, 20, 30);
            veiculos[5] = new ModeloMoto(2, 1, fabricante[0], "Bros", 2, 18, 35);
        }
           
    }
}

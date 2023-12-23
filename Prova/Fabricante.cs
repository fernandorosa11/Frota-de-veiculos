using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{

    //Classe contendo a propriedade nome com setter privado (Q2)
    class Fabricante
    {        
        public string Nome { private set; get;}
        public Fabricante(string nome)
        {
            Nome = nome;
        }
        
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sintaxe_e_Tipos_de_Dados_em_C_.Models
{
    public class Pessoa
    {
        public string Nome  { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos");
        }
    }
}
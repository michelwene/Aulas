using System;
using System.Collections.Generic;
using System.Text;

namespace Meu_primeiro_prj
{
    class Produto
    {
        public string produtos;
        public int codigo;
        public string nome;
        public int estoque;
        

        public void imprimirDados()
        {
            Console.WriteLine("Imprimindo dados do produto");
            Console.WriteLine("produto: " + produtos);
            Console.WriteLine("codigo: " + codigo);
            Console.WriteLine("nome: " + nome);
            Console.WriteLine("estoque: " + estoque);
            
        }
    }
}

using System;

namespace Meu_primeiro_prj
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto var = new Produto();
            var.produtos = "Alimento";
            var.codigo = 357;
            var.nome = "Arroz";
            var.estoque = 598;
         

            var.imprimirDados();


        }
    }
}

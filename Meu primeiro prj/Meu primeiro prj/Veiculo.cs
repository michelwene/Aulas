using System;
using System.Collections.Generic;
using System.Text;

namespace Meu_primeiro_prj
{
    class Veiculo
    {
        public string placa;
        public string modelo;
        public string marca;
        public int ano;
        public int anoModelo;
        public int qtdPorta;

        public void imprimirDados()
        {
            Console.WriteLine("Imprimindo dados do fusca");
            Console.WriteLine("Placa: " + placa);
            Console.WriteLine("Modelo: " + modelo);
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Ano: " + ano);
            Console.WriteLine("anoModelo: " + anoModelo);
            Console.WriteLine("Qtd Porta: " + qtdPorta);
        }
        }
}

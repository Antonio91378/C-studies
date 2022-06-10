using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
    public class ContaCorrente
    {
        public string titularNome;
        public string titularCpf;
        public string titularProfissao;
        public string conta;
        public int numeroAgencia;
        public string nomeAgencia;
        public double saldo = 10000.99;

        public bool Sacar(double valor)
        {
            if (0 > valor && valor > saldo)
            {
                return false;
                Console.WriteLine("Error: Valor inválido");
            }
            else if (0 < valor && valor < saldo)
            {
                saldo = saldo - valor;
                return true;
            }
            else
            {
                return false;
                Console.WriteLine("Error: Valor inválido");
            }
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (saldo > valor && valor > 0)
            {
                saldo -= valor;
                contaDestino.saldo += valor;
            }
            else
            {
                Console.WriteLine("Error: Valor inválido");
            }
        }

        public static void Depositar(double valor, ContaCorrente contaDestino)
        {

            if (valor > 0)
            {
                contaDestino.saldo += valor;
            }
            else
            {
                Console.WriteLine("Error: Valor inválido");
            }
        }
    }
}

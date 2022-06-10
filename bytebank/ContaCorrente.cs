using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank.Titular;

namespace bytebank
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroAgencia, string conta)
        {
            NumeroAgencia = numeroAgencia;
            Conta = conta;
            TotalAccounts += 1;
        }
        public Cliente Titular { get; set; }
        public string _conta;
        public string Conta
        {
            get
            {
                return _conta;
            }
            set
            {
                if (_conta == "")
                {
                    return;
                }
                else
                {
                    _conta = value;
                }
            }
        }
        private int _numeroAgencia;
        public int NumeroAgencia
        {
            get
            {
                return _numeroAgencia;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                else
                {
                    _numeroAgencia = value;
                }
            }
        }
        public string NomeAgencia { get; set; }
        private double saldo = 10000.99;

        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    saldo = value;
                }
            }
        }

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

        public static int TotalAccounts { get; set; }

    }

}

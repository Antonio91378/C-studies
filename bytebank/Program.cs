using bytebank;
using bytebank.Titular;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Boas vindas ao seu banco, ByteBank");
        // Cliente sarah = new Cliente();
        // sarah.Nome = "Sarah Silva";
        // ContaCorrente conta4 = new ContaCorrente(235, "1023-B");
        // conta4.Saldo = 10;
        // conta4.Titular = sarah;

        // System.Console.WriteLine(conta4.Titular.Nome);
        // System.Console.WriteLine(conta4.Saldo);
        // System.Console.WriteLine(conta4.Conta);
        // System.Console.WriteLine(conta4.NumeroAgencia);
        ContaCorrente conta5 = new ContaCorrente(235, "1023-B");
        ContaCorrente conta6 = new ContaCorrente(235, "1023-B");
        ContaCorrente conta7 = new ContaCorrente(235, "1023-B");
        ContaCorrente conta8 = new ContaCorrente(235, "1023-B");
        ContaCorrente conta9 = new ContaCorrente(235, "1023-B");

        Console.WriteLine(ContaCorrente.TotalAccounts);
    }
}
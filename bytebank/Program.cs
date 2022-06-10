using bytebank;
using bytebank.Titular;

Console.WriteLine("Boas vindas ao seu banco, ByteBank");

//ContaCorrente conta1 = new ContaCorrente();
//conta1.titularNome = "Antônio Víctor";
//conta1.conta = "115200-B";
//conta1.numeroAgencia = 1023;
//conta1.nomeAgencia = "Agência central";


//ContaCorrente conta2 = new ContaCorrente();
//conta2.titularNome = "Clarice";
//conta2.conta = "9600-B";
//conta2.numeroAgencia = 255;
//conta2.nomeAgencia = "Agência central";
//conta2.saldo = 100.99;

//ContaCorrente.Depositar(500, conta2);
//conta2.Transferir(500, conta1);

//Console.WriteLine(conta2.saldo);
//Console.WriteLine(conta1.saldo);

// Cliente cliente = new Cliente();
// cliente.nome = "Antônio Víctor Gonçalves Dias";
// cliente.cpf = "14354546699";
// cliente.profissao = "Programador";

// ContaCorrente conta3 = new ContaCorrente();
// conta3.titular = new Cliente();
// conta3.titular.nome = "Antônio Víctor Gonçalves Dias";
// conta3.titular.cpf = "14354546699";
// conta3.titular.profissao = "Programador";
// conta3.conta = "300-B";
// conta3.numeroAgencia = 32;
// conta3.nomeAgencia = "Agência central";

ContaCorrente conta4 = new ContaCorrente();
conta4.Saldo = 10;
System.Console.WriteLine(conta4.Saldo);
using byteBank;
using byteBank.Titular;

Console.WriteLine("Boas Vindas ao seu banco, ByteBank!");

/*

// Criando nova instancia do objeto do tipo ContaCorrente
ContaCorrente conta1 = new ContaCorrente();

// Acessando propriedades/atributos da class ContaCorrente
conta1.titular_nome = "André Silva";
conta1.conta = "10123-x";
conta1.numero_agencia = 23;
conta1.nome_agencia = "Angência Central";
conta1.saldo = 100;

ContaCorrente conta2 = new ContaCorrente();
conta2.titular_nome = "Amanda Xavier";
conta2.conta = "111999-x";
conta2.numero_agencia = 58;
conta2.nome_agencia = "Agência Central";
conta2.saldo = 100;

Console.WriteLine($"Saldo Amanda pré-saque: {conta2.saldo}");

// Chamando o método Sacar
bool saque = conta2.Sacar(50);
Console.WriteLine($"Saque executado com sucesso {saque}");
Console.WriteLine($"Saldo Amanda pós-saque: {conta2.saldo}");

// Chamando o método Depositar
conta2.Depositar(60);
Console.WriteLine($"Saldo Amanda pós-depósito: {conta2.saldo}");

// Chamando o método Transferir
bool transferencia = conta1.Transferir(50, conta2);
Console.WriteLine($"Transferência executada com sucesso {transferencia}");
Console.WriteLine($"Saldo Andre pós-transferência: {conta1.saldo}");
Console.WriteLine($"Saldo Amanda pós-transferência: {conta2.saldo}");

 */

//Cliente cliente = new Cliente();
//cliente.nome = "Andre Silva";
//cliente.cpf = "111.111.111-11";
//cliente.profissao = "Desenvolvedor de Software";

ContaCorrente conta3 = new ContaCorrente();
conta3.titular = new Cliente();
conta3.titular.nome = "Andre Silva";
conta3.titular.cpf = "111.111.111-11";
conta3.titular.profissao = "Desenvolvedor de Software";
conta3.conta = "2513252-X";
conta3.numero_agencia = 35;
conta3.nome_agencia = "Agência Central";

Console.WriteLine(conta3.titular.nome);

// O console fica aguardando teclar uma tecla para sair do programa
Console.ReadKey();
using byteBank;

Console.WriteLine("Boas Vindas ao seu banco, ByteBank!");

// Criando nova instancia do objeto do tipo ContaCorrente
ContaCorrente conta1 = new ContaCorrente();

// Acessando propriedades/atributos da class ContaCorrente
conta1.titular = "André Silva";
conta1.conta = "10123-x";
conta1.numero_agencia = 23;
conta1.nome_agencia = "Angência Central";
conta1.saldo = 100;

ContaCorrente conta2 = new ContaCorrente();
conta2.titular = "Amanda Xavier";
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

// O console fica aguardando teclar uma tecla para sair do programa
Console.ReadKey();
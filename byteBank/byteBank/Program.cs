using byteBank;

Console.WriteLine("Boas Vindas ao seu banco, ByteBank!");

// Criando objeto
ContaCorrente conta1 = new ContaCorrente();

// Acessando propriedades/atributos da class ContaCorrente
conta1.titular = "André Silva";
conta1.conta = "10123-x";
conta1.numero_agencia = 23;
conta1.nome_agencia = "Angência Central";
conta1.saldo = 100;

Console.WriteLine($"Titular: {conta1.titular}");
Console.WriteLine($"Conta: {conta1.conta}");
Console.WriteLine($"Numero Agencia: {conta1.numero_agencia}");
Console.WriteLine($"Nome Agencia: {conta1.nome_agencia}");
Console.WriteLine($"Saldo: R$ {conta1.saldo}");

// O console fica aguardando teclar uma tecla para sair do programa
Console.ReadKey();
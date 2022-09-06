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

ContaCorrente conta3 = new ContaCorrente();

//Console.WriteLine($"Titular: {conta1.titular}");
//Console.WriteLine($"Conta: {conta1.conta}");
//Console.WriteLine($"Numero Agencia: {conta1.numero_agencia}");
//Console.WriteLine($"Nome Agencia: {conta1.nome_agencia}");
//Console.WriteLine($"Saldo: R$ {conta1.saldo}");

Console.WriteLine($"Titular: {conta3.titular}");
Console.WriteLine($"Conta: {conta3.conta}");
Console.WriteLine($"Numero Agencia: {conta3.numero_agencia}");
Console.WriteLine($"Nome Agencia: {conta3.nome_agencia}");
Console.WriteLine($"Saldo: R$ {conta3.saldo}");
Console.WriteLine($"Verificador: {conta3.verificador}");

// O console fica aguardando teclar uma tecla para sair do programa
Console.ReadKey();
Console.WriteLine("Boas Vindas ao seu banco, ByteBank!");

string titular = "Andre Bessa";
string conta = "10123-x";
int numero_agencia = 23;
string nome_agencia = "Agencia Central";
double saldo = 93.50;

Console.WriteLine($"Titular: {titular}");
Console.WriteLine($"Conta: {conta}");
Console.WriteLine($"Numero Agencia: {numero_agencia}");
Console.WriteLine($"Nome Agencia: {nome_agencia}");
Console.WriteLine($"Saldo: R$ {saldo}");

// O console fica aguardando teclar uma tecla para sair do programa
Console.ReadKey();
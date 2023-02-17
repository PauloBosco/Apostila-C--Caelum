Cliente victor = new Cliente();

victor.Nome = "Victor de Padua Arlindo";
victor.CPF = "12345678-9";
victor.RG = "12.345.678";
victor.Endereco = "Rua A";

Conta contacorrenteVictor = new ContaCorrente(123);
Conta contaPoupancaVictor = new ContaPoupanca(456);

contacorrenteVictor.Titular = victor;
contaPoupancaVictor.Titular = victor;

contacorrenteVictor.Deposita(100.0);
contaPoupancaVictor.Deposita(100.0);


//Utilizando as Funcionalidades

// contacorrenteVictor.Saca(50);
// contaPoupancaVictor.Saca(50);

contacorrenteVictor.Transfere(20, contaPoupancaVictor);



Console.WriteLine("------------------------------------ ");
Console.WriteLine("---------Correntista Victor--------- ");
Console.WriteLine("------------------------------------ ");
Console.WriteLine($"Nome Completo: {contacorrenteVictor.Titular.Nome}");
Console.WriteLine($"CPF: {contacorrenteVictor.Titular.CPF}");
Console.WriteLine($"RG: {contacorrenteVictor.Titular.RG}");
Console.WriteLine($"Endereço: {contacorrenteVictor.Titular.Endereco}");
Console.WriteLine();
Console.WriteLine($"---------Detalhes da Conta Corrente---------");
Console.WriteLine($"Número C/C: {contacorrenteVictor.Numero}");
Console.WriteLine($"Saldo: {contacorrenteVictor.Saldo}");
Console.WriteLine();
Console.WriteLine($"---------Detalhes da Conta Poupança---------");
Console.WriteLine($"Número C/P: {contaPoupancaVictor.Numero}");
Console.WriteLine($"Saldo: {contaPoupancaVictor.Saldo}");




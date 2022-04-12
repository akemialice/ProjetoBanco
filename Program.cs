Conta c1 = new Conta(1);
Conta c2 = new Conta(2);

c1.Depositar(1000.0);
Console.WriteLine(c1.Saldo);

c2.Depositar(200.0);
Console.WriteLine(c2.Saldo);

c1.Transferir(2000.0, c2);
Console.WriteLine("O saldo atual da sua conta é de: {0}", c1.Saldo);
Console.WriteLine("O saldo atual da conta destino é de: {0} ", c2.Saldo);


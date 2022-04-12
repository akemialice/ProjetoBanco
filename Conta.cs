public class Conta
{
       public int Codigo { get;} 
       public double Saldo { get; private set;}
       public double destino{ get; private set;}

       public Conta (int codigo)
       {
               Codigo = codigo;
               Saldo = 0.0;
       }

       public void Sacar(double valor)
       {
               ValidarValor(valor);
               VerificarSaldo(valor);

               Saldo -= valor;
               
       }

              public void Depositar(double valor)
       {
               ValidarValor(valor);
               Saldo += valor;
       }


       /* 
       public void transfere(double valor, Conta destino) {
		if (this.Saldo < valor) {
        throw new ArgumentException("Não foi possivel tranferir. O valor é maior que o seu saldo dísponivel.");
                } 
			this.Saldo -= valor;
			destino.Depositar(valor);

                        Console.WriteLine(destino.Saldo);
                        Console.WriteLine("Transferencia concluída.");
		} 
        */

        public void Transferir(double valor, Conta conta){
               ValidarValor(valor);
               VerificarSaldo(valor);

               Sacar(valor);
               conta.Depositar(valor);

                Console.WriteLine(conta.Saldo);
                Console.WriteLine("Transferencia concluída.");
        }

                public void ValidarValor(double valor)
                {
                        if(valor <= 0.0) throw new ArgumentException("Valor deve ser maior que zero");
                }

                public void VerificarSaldo(double valor)
                {
                        if(valor > Saldo) throw new ArgumentException("Saldo insuficiente");
                }
	}


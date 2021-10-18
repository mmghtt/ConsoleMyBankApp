using System;

namespace ConsoleMyBankApp
{
    class Program
    {
        static void Main(string[] args)
        {

          
            Cliente cliente = new Cliente("Dani Marighetti", "999.999.999-88", "analista");

           
            ContaCorrente conta = new ContaCorrente(cliente, 01, 0001);

            Console.WriteLine("Conta corrente crida com sucesso");
            Console.WriteLine("Titular: {0}.", conta.getTitular().getNome());
            Console.WriteLine("Agência: {0}.", conta.getAgencia());
            Console.WriteLine("Conta: {0}", conta.getConta());

            Console.WriteLine("Parabéns, seu saldo é de R${0}. Obrigado por criar sua conta!", conta.getSaldo());

            
            double valorDeposito = 200;
            conta.Depositar(valorDeposito);
            Console.WriteLine("saldo R${0}", conta.getSaldo());

         
            double valorSaque = 100;
            conta.Sacar(valorSaque);
            Console.WriteLine("saldo R${0}", conta.getSaldo());

            
            Cliente clienteSilvia = new Cliente("Michelle Marighetti", "000000000-00", "Dev");
            ContaCorrente contaSilvia = new ContaCorrente(clienteSilvia, 01, 0002);

           
            double valorPix = 100;
            conta.Pix(valorPix, contaSilvia);

            Console.WriteLine("Seu saldo é de R${0}", conta.getSaldo());
            Console.WriteLine("Seu saldo é de R${0}", contaSilvia.getSaldo());

            ContaPoupanca contaPoupanca = new ContaPoupanca(cliente, 01, 0003);

            Console.WriteLine("Titular: {0}", contaPoupanca.getTitular().getNome());
            Console.WriteLine("Agência: {0}", contaPoupanca.getAgencia());
            Console.WriteLine("Conta: {0}", contaPoupanca.getConta());
        }
    }
}
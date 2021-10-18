using System;

namespace ConsoleMyBankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Michelle Marighetti", 
                "000.000.000-00", 
                "Programador");

            ContaCorrente conta = new ContaCorrente(cliente, 01, 0001);

            Console.WriteLine("Conta corrente criada");
            Console.WriteLine("Titular: {0}", conta.getTitular().getNome());
            Console.WriteLine("Agência: {0}", conta.getAgencia()); 
            Console.WriteLine("Conta: {0}", conta.getConta());

            Console.WriteLine("Parabéns! Seu saldo é de R${0}, obrigado por criar sua conta.", conta.getSaldo());

            double ValorDeposito = 200;
            conta.Depositar(ValorDeposito);

            Console.WriteLine("Seu saldo é {0}",
                conta.getSaldo());

            double valorSaque = 200;
            conta.Sacar(valorSaque);

            Console.WriteLine("Seu saldo é de R${0}", conta.getSaldo());

            Cliente clienteDani = new Cliente("Dani Marighetti", "000.000.000-00", "Analista");

            ContaCorrente contaDani = new ContaCorrente(clienteDani, 01, 0002);

            double valorPix = 100;
            conta.Pix(valorPix, contaDani);

            Console.WriteLine("Seu saldo é de R${0}", conta.getSaldo());
            Console.WriteLine("Seu saldo é de R$ {0}", contaDani.getSaldo());
        }
    }
} 

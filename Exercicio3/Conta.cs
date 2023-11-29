namespace Exercicio3
{
    public class Conta
    {
        public double Saldo { set; get; }

        public void Sacar(double valor)
        {
            if (Saldo > 0 && Saldo >= valor)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine(" Saldo insuficiente ");
            } 

        }
   
        public void Depositar(double valor)
        {
            Saldo += valor;
        }
        public double ObterSaldo()
        {
            return Saldo;
        }
    }
}
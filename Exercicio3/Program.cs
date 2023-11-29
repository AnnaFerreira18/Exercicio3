namespace Exercicio3
{
    class Program
    {
        public static void Main(string[] args)
        {
            ContaPoupança poupanca = new ContaPoupança();
            poupanca.Saldo = 10;
            poupanca.Depositar(300);
            poupanca.Sacar(420);
            Console.WriteLine(" conta poupança = " + poupanca.ObterSaldo());

            ContaCorrente corrente = new ContaCorrente();
            corrente.Saldo = -100;
            corrente.Depositar(600);
            corrente.Sacar(390);
            Console.WriteLine(" conta corrente = " + corrente.ObterSaldo() + "  " + "tributos = " + corrente.calcularTributos());

            SeguroDeVida seguro = new SeguroDeVida();
            Console.WriteLine(" seguro de vida = " + seguro.calcularTributos());
        }
    }
}
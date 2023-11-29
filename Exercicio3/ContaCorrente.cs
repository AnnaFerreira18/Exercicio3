namespace Exercicio3
{
    public class ContaCorrente : Conta, Tributavel 
    {
        public double calcularTributos()
        {
            return base.Saldo * 1 / 100;
        }
    }

}
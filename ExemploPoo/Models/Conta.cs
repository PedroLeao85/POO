namespace ExemploPoo.Models
{
    public abstract class Conta
    {
        protected double saldo;

        public abstract void Creditar(double valor); //não tem implementação , não faz nada.

        public void ExibirSaldo()
        {
            System.Console.WriteLine("Seu saldo é: " + saldo);
        }
    }
}
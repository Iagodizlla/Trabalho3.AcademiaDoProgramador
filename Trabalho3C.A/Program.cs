namespace Trabalho3C.A
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente(12, 1000, 0);
            conta1.Sacar(200);
            conta1.Depositar(300);
            conta1.Depositar(500);
            conta1.Sacar(200);

            ContaCorrente conta2 = new ContaCorrente(13, 300, 0);

            conta1.TransferirPara(conta2, 400);
            conta1.ExibirExtrato();
            conta2.ExibirExtrato();
        }
    }
}
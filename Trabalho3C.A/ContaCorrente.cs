namespace Trabalho3C.A
{
    public class ContaCorrente
    {
        #region Atributos
        public int Numero { get; set; }
        public double Saldo { get; set; }
        public double Limite { get; set; }
        public Movimentacao[] movimentacoes;
        public int IndiceMovimentacao = 0;
        public ContaCorrente(int numero, double saldoInicial, double limite)
        {
            Numero = numero;
            Saldo = saldoInicial;
            Limite = limite;
            movimentacoes = new Movimentacao[10];
        }
        #endregion
        #region Metodos
        public void Sacar(double valor)
        {
            Saldo -= valor;
            AdicionarMovimentacao("Saque", valor);
        }
        public void Depositar(double valor)
        {
            Saldo += valor;
            AdicionarMovimentacao("Depósito", valor);
        }
        public void TransferirPara(ContaCorrente destino, double valor)
        {
            Sacar(valor);
            destino.Depositar(valor);
        }
        public void AdicionarMovimentacao(string tipo, double valor)
        {
                movimentacoes[IndiceMovimentacao] = new Movimentacao(tipo, valor);
                IndiceMovimentacao++;
        }
        public void ExibirExtrato()
        {
            Console.WriteLine($"\n--- EXTRATO DA CONTA #{Numero} ---");
            Console.WriteLine("------ Movimentações: ------");
            for (int i = 0; i < IndiceMovimentacao; i++)
            {
                Console.WriteLine(movimentacoes[i]);
            }
            Console.WriteLine($"Saldo Atual: {Saldo:F2}\n");
            Console.ReadLine();
        }
        #endregion
    }
}
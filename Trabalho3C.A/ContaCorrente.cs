using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho3C.A
{
    internal class ContaCorrente
    {
        public int numero { get; set; }
        public double saldo { get; set; }
        public double limite { get; set; }
        public Movimentacao[] movimentacoes { get; set; }

        public void Sacar(double n)
        {
            saldo -= n;
        }
        public void Depositar(double n)
        {
            saldo += n;
        }
        public void TransferirPara(ContaCorrente c, double n)
        {
            saldo -= n;
            c.saldo += n;
        }
        public void ExibirExtrato()
        {
            Console.WriteLine($"\n-- CONTA #{numero} --");
            Console.WriteLine($"Saldo: {saldo}");
            Console.ReadLine();
        }
    }
}
namespace Trabalho3C.A
{
    public class Movimentacao
    {
        #region Atributos
        public string Tipo { get; set; }
        public double Valor { get; set; }
        public Movimentacao(string tipo, double valor)
        {
            Tipo = tipo;
            Valor = valor;
        }
        #endregion
        public override string ToString()
        {
            return $"{Tipo}: {Valor:F2}";
        }
    }
}
public class ServicoPaypal : IPagamentoOnline
{
    public double Restante(double valor,int meses)
    {
        return valor * 0.01 * meses;
    }
    public double TaxaDePagamento(double valor)
    {
        return valor * 0.02;
    }
}
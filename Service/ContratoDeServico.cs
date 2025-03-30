public class ContratoDeServico
{
    private IPagamentoOnline _pagamentoOnline;

    public ContratoDeServico(IPagamentoOnline pagamento)
    {
        _pagamentoOnline = pagamento;
    }

    public void ProcessarContrato(Contrato contrato,int mes)
    {
        double quotaBasica = contrato.ValorTotal / mes;
        for(int i = 1; i <= mes; i++)
        {
            DateTime data = contrato.Data.AddMonths(i);
            double quotaMes = quotaBasica + _pagamentoOnline.Restante(quotaBasica,i);
            double quotaFinal = quotaMes + _pagamentoOnline.TaxaDePagamento(quotaMes);
            contrato.AddParcela(new Parcelas(data,quotaFinal));
        }
    }
}
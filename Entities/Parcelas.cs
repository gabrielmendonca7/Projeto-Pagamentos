using System.Globalization;

public class Parcelas
{
    public DateTime Vencimento{get;set;}
    public double Valor{get;set;}

    public Parcelas(DateTime vencimento,double valor)
    {
        Vencimento = vencimento;
        Valor = valor;
    }

    public override string ToString() => $"{Vencimento.ToString("dd/MM/yyyy")} - {Valor.ToString("F2",CultureInfo.InvariantCulture)}";
}
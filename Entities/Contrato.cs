public class Contrato
{
    public int Numero{get;set;}
    public DateTime Data{get;set;}
    public double ValorTotal { get; set; }

    public List<Parcelas> parcelas{get;set;}

    public Contrato(int numero, DateTime data, double valorTotal)
    {
        Numero = numero;
        Data = data;
        ValorTotal = valorTotal;
        parcelas = new List<Parcelas>();
    }

    public void AddParcela(Parcelas parcela)
    {
        parcelas.Add(parcela);
    }
}
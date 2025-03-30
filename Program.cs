using System;
using System.Globalization;

namespace Pagamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Entre com os dados do contrato:");

            System.Console.Write("Número: ");
            int num = int.Parse(Console.ReadLine());
            System.Console.Write("Data (dd/MM/yyyy): ");
            DateTime data = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",CultureInfo.InvariantCulture);
            System.Console.Write("Valor do contrato: ");
            double valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            System.Console.Write("Entre com o número de parcelas: ");
            int parcelas = int.Parse(Console.ReadLine());
            System.Console.WriteLine();

            Contrato contrato = new Contrato(num,data,valor);
            ContratoDeServico contratoDeServico = new ContratoDeServico(new ServicoPaypal());
            contratoDeServico.ProcessarContrato(contrato,parcelas);
            
            foreach(var item in contrato.parcelas)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
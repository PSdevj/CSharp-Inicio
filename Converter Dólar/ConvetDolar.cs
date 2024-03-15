using System;
namespace ConverterDolar
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double valor_Dolar, cota_Dolar, valor_Real;
        

            Console.WriteLine("Cotação em Dólar: ");
            cota_Dolar = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Dinheiro em Dólar: ");
            valor_Dolar = Convert.ToDouble(Console.ReadLine());

            valor_Real = cota_Dolar * valor_Dolar;

            Console.WriteLine($"Valor convertido em Dólar para Real é R$ {valor_Real}");


        }
    }
}
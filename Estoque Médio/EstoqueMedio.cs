using System;
namespace EstoqueMedio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int quantidade_Maxima, quantidade_Minima, estoque_Medio;

            Console.WriteLine("Quantidade Mínima: ");
            quantidade_Minima = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quantidade Máxima: ");
            quantidade_Maxima = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Quantidade Mínimua: {quantidade_Minima}\nQuantidade Máxima: {quantidade_Maxima}");

            estoque_Medio = (quantidade_Minima + quantidade_Maxima) / 2;

            Console.WriteLine($"O estoque médio é {estoque_Medio} peças");
        }
    }
}
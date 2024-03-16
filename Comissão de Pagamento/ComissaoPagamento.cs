using System;
namespace Comissão
{
    public class Program
    {
        public static void Main(string [] args)
        {
           int identificador_Vendedor, quantidade_Peca_Vendida1 = 75, 
           quantidade_Peca_Vendida2 = 50, quantidade_Peca_Vendida3 = 35;
           double code_Peca1 = 051555, code_Peca2 = 987441, code_Peca3 = 547789, 
           preco_Peca1 = 25.90d, preco_Peca2 = 50.99d, preco_Peca3 = 85.00d, comissao = 0.05;
           
           Console.WriteLine("Identifcador do Vendedor: ");
           identificador_Vendedor = Convert.ToInt32(Console.ReadLine());

           
           code_Peca1 = preco_Peca1;
           code_Peca2 = preco_Peca3;
           code_Peca3 = preco_Peca2;

          double valor_vendido_Peca1 = code_Peca1 * quantidade_Peca_Vendida1;
          double valor_vendido_Peca2 = code_Peca2 * quantidade_Peca_Vendida2;
          double valor_vendido_Peca3 = code_Peca3 * quantidade_Peca_Vendida3;

          double valor_Total_Vendido = valor_vendido_Peca1 + valor_vendido_Peca2 + valor_vendido_Peca3;
          double comissao_Pagamento = valor_Total_Vendido * comissao;

         Console.WriteLine($"Valor total vendido R$ {valor_Total_Vendido}");
         Console.WriteLine($"O vendedor {identificador_Vendedor} vai receber de comissão R${comissao_Pagamento}");
          

        }
    }
}

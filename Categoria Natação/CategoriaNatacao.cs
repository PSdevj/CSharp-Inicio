/*
*Utilizando a estrutura condicionais if - else
/

/
*Escreva um algoritmo que, dada a idade de um nadador, classifique-o uma das seguintes categorias:
*infantil B = 8 - 10 anos
*juvenil A = 11 - 13 anos
*juvenil B = 14 - 17 anos
* sênior = maiores de 18 anos
*/

using System;
namespace CategoriaNadador 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Declaração de variáveis 
            
            int idadeDoUsuario;
            string nomeDoUsuario;


            //Entrada e saída de dados - WriteLine e ReadLine

           Console.WriteLine("Digite seu nome: ");
           nomeDoUsuario = Console.ReadLine(); //lendo o nome do usuário

           Console.WriteLine("\n --------- AS CATEGORIAS --------- \n");
           Console.WriteLine(" INFATIL B = 8 - 10 ANOS ");
           Console.WriteLine(" JUVENIL A = 11 - 13 ANOS ");
           Console.WriteLine(" IUVENIL B = 14 - 17 ANOS ");
           Console.WriteLine(" SÊNIOR = MAIORES QUE 18 ANOS \n");
           
           Console.WriteLine("Agora digite sua idade:");
           idadeDoUsuario = Convert.ToInt32(Console.ReadLine()); //lendo a idade do usuário

           if (idadeDoUsuario >= 8 && idadeDoUsuario <= 10){ //Se a idade do usuário for entre 8 e 10 anos, irá ler esta linha
            Console.WriteLine($"{nomeDoUsuario}, sua categoria é infantil B");
           }
           if (idadeDoUsuario >= 11 && idadeDoUsuario <= 13){ //Se a idade do usuário for entre 11 e 13 anos, irá ler esta linha
            Console.WriteLine($"{nomeDoUsuario}, sua categoria é juvenil A.");
           }
           if (idadeDoUsuario >= 14 && idadeDoUsuario <= 17){ //Se a idade do usuário for entre 14 e 17 anos, irá ler esta linha
            Console.WriteLine($"{nomeDoUsuario}, sua categoria é juvenil B");
           }
           if (idadeDoUsuario >= 18){ //Se a idade do usuário for maior que 18 anos, irá ler esta linha
            Console.WriteLine($"{nomeDoUsuario}, sua categoria é sênior.");
           }

        }
    }
}
using System;

namespace ProgramaSRDA
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("O que você gostaria de fazer?");
            Console.WriteLine("1-   Adicionar nova entrada");
            Console.WriteLine("2-   Consultar entradas");
            int opcao = Int32.Parse(Console.ReadLine());
            if (opcao == 1){
            new Adicionar().Adiciona();
            } else if (opcao == 2){
                new Consultar().Consulta();
            } else {
                Console.WriteLine("Comando inválido");
            }
        }
    }
}

using System;
using System.IO;

namespace ProgramaSRDA
{
    class Adicionar
    {
        public void Adiciona()
        {
            Parametros par = new Parametros();
            StreamWriter writer;
            string caminho = "D:\\_Programação\\ProgramaSRDA\\BancoDeDados\\entradas.txt";

            Console.WriteLine("Digite a data: Ex: 20/05/2020");
            par.data = Console.ReadLine();
            Console.WriteLine("Digite a hora: Ex: 20:54");
            par.hora = Console.ReadLine();
            Console.WriteLine("Digite um comentário: ");
            par.comentario = Console.ReadLine();
            
            writer = File.AppendText(caminho);
            writer.WriteLine(par.data + ";" + par.hora + ";" + par.comentario);
            writer.Close();
            Console.WriteLine("O que você gostaria de fazer?");
            Console.WriteLine("1-   Adicionar nova entrada");
            Console.WriteLine("2-   Sair");
            int opcao = Int32.Parse(Console.ReadLine());
            if(opcao == 1){
                Adiciona();
            } else if (opcao ==2){
                Environment.Exit(0);
            } else {
                Console.WriteLine("Comando inválido");
            }
        }
    }
}

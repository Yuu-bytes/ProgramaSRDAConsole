using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System;
using System.IO;

namespace ProgramaSRDA
{
    class Consultar
    {
        public void Consulta()
        {
            StreamReader reader;
            string caminho = "D:\\_Programação\\ProgramaSRDA\\BancoDeDados\\entradas.txt";
            reader = File.OpenText(caminho);
            Console.WriteLine("--------------------------------");
            while (reader.EndOfStream != true){
            string linha = reader.ReadLine();
            String[] separados = linha.Split(";");
            string data = separados[0];
            string hora = separados[1];
            string comentario = separados[2];
            Console.WriteLine("Data:        " + data);
            Console.WriteLine("Hora:        " + hora);
            Console.WriteLine("Comentário:  " + comentario);
            Console.WriteLine("--------------------------------");
            }
            reader.Close();
        }
    }
}
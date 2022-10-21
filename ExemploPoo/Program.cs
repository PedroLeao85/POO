using System;
using System.Collections.Generic;
using ExemploPoo.Helper;
using ExemploPoo.Interfaces;
using ExemploPoo.Models;
using System.IO;

namespace ExemploPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();
            a1.Nome = "Peter";
            a1.Idade = 30;
            a1.Nota = 10;
            a1.Documento = "123456";

            a1.Apresentar();

            Professor p1 = new Professor();
            p1.Nome = "Jota";
            p1.Idade = 20;
            p1.Documento = "1112223";
            p1.Salario = 2555.00;

            p1.Apresentar();

            Calculadora c1 = new Calculadora();
            System.Console.WriteLine("Resultado da primeira soma: " + c1.Somar(1, 4));
            System.Console.WriteLine("Resultado da segunda soma: " + c1.Somar(3, 1, 2));

            Corrente corrente = new Corrente();
            corrente.Creditar(100);
            corrente.ExibirSaldo();

            Computador computador = new Computador();
            System.Console.WriteLine(computador.ToString());

            ICalculadora calc = new Calculadora();
            System.Console.WriteLine(calc.Dividir(4, 2));

            System.Console.WriteLine(" ");

            var caminho = "C:\\DIO\\POO\\TrabalhandoComArquivos";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta Teste 1");
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
            var caminhoArquivoTeste = Path.Combine(caminho, "arquivo-teste.txt");
            var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-teste-backup.txt");
            
            
            var listaString = new List<string> {"Linha 1" , "Linha 2" , "Linha 3"};
            var listaStringContinuacao = new List<string> {"Linha 4" , "Linha 5" , "Linha 6"};

            var novoCaminhoArquivo = Path.Combine(caminho, "Pasta Teste 2", "arquivo-teste-stream.txt");
            

            FileHelper helper = new FileHelper();
           // helper.ListarDiretorios(caminho);

            //System.Console.WriteLine(" ");
            //helper.ListarArquivosDiretorios(caminho);

            //System.Console.WriteLine(" ");

            //System.Console.WriteLine("Criar diretorio: " + caminhoPathCombine);    
            //helper.CriarDiretorio(caminhoPathCombine);

            System.Console.WriteLine(" ");

            //helper.ApagarDiretorio(caminhoPathCombine, true);

            //helper.CriarArquivoTexto(caminhoArquivo, "Olá! Teste de escrita de Arquivo");

           // helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            //helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);

            //helper.LerArquivoStream(caminhoArquivo);

            //helper.MoverAquivo(caminhoArquivo, novoCaminhoArquivo, false);

            //helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);

            //helper.DeletarArquivo(caminhoArquivoTesteCopia);



            




        //    //valores validos
        //    Retangulo r1 = new Retangulo();
        //    r1.DefinirMedidas(2 , 3);
           
        //    System.Console.WriteLine ($"Area: {r1.ObterArea()}");

        //    System.Console.WriteLine (" ");

           
        //    //valores invalidos
        //    Retangulo r2 = new Retangulo();
        //    r1.DefinirMedidas(-2 , -3);
           
        //    System.Console.WriteLine ($"Area: {r2.ObterArea()}");
           
           
           
            // Pessoa p1 = new Pessoa();

            // p1.Nome = "Pedro";
            // p1.Idade = 37;

            // p1.Apresentar();
        }
    }

}
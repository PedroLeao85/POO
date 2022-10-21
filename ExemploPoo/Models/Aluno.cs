using System;
namespace ExemploPoo.Models
{
    //herança: aluno herda atributos de Pessoa
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }

        public override void Apresentar()
        {
            System.Console.WriteLine($"Olá, meu nome é {Nome} e a minha nota é {Nota}");
        }
    }
}
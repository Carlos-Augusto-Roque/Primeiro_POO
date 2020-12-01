using System;

namespace Primeiro_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem objetoPersonagem1 = new Personagem();//instânciando uma classe num objeto

            objetoPersonagem1.nome = "Carlos";//preenchimento do atributo para o objeto
            objetoPersonagem1.idade = 33;//preenchimento do atributo para o objeto
            objetoPersonagem1.armadura = "Iron man";//preenchimento do atributo para o objeto

            Personagem objetoPersonagem2 = new Personagem();//instânciando uma classe num objeto

            objetoPersonagem2.nome = "Zé";//preenchimento do atributo para o objeto
            objetoPersonagem2.idade = 25;//preenchimento do atributo para o objeto
            objetoPersonagem2.armadura = "Subzero";//preenchimento do atributo para o objeto

            Console.WriteLine($"Personagem 1 = {objetoPersonagem1.nome} - {objetoPersonagem1.Atacar()}");
            //exibição da mensagem (interpolação)usando o atributo e o método
            Console.WriteLine($"Personagem 2 = {objetoPersonagem2.nome} - {objetoPersonagem2.Defender()}");
            //exibição da mensagem (interpolação)usando o atributo e o método

        }
    }
}

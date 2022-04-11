using System;

namespace calculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Qual o seu nome?");
            string Nome = Console.ReadLine();

            Console.WriteLine("Qual a sua altura em metros? Ex: 1,63");
            float Altura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Qual o seu peso em Kg? Ex: 59,3");
            float Peso = Convert.ToSingle(Console.ReadLine());

            double imc = Peso / (Altura * Altura);
            
            Pessoa p1 = new Pessoa (Nome, Altura, Peso);

            Console.WriteLine("{0}, sua altura é {1} e seu peso é {2} Kg", p1.Nome, p1.Altura, p1.Peso);
            Console.WriteLine("Seu IMC é {0}", p1.imc);


            Console.WriteLine(p1.situacaoPessoa());
        }
    }
}
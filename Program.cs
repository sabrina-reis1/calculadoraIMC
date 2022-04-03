using System;

namespace calculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual a sua altura em metros? Ex: 1,63");
            float altura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Qual o seu peso em Kg? Ex: 59,3");
            float peso = Convert.ToSingle(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine("{0}, sua altura é {1} e seu peso é {2} Kg", nome, altura, peso);
            Console.WriteLine("Seu IMC é {0}", imc);

            if(imc < 17.00) 
            {
                Console.WriteLine("Você está muito abaixo do peso.");
            } 
            else if (imc >=17.00 && imc < 18.50)
            {
                 Console.WriteLine("Você está abaixo do peso.");
            }
            else if (imc >= 18.50 && imc < 25.00)
            {
                Console.WriteLine("Você está no peso ideal.");
            }
            else if(imc >= 25.00 && imc < 30.00)
            { 
                Console.WriteLine("Você está acima do peso.");
            }
            else if(imc >=30.00 && imc < 35.00) 
            {
                Console.WriteLine("Situação: Obesidade I");
            }
            else if(imc >=35.00 && imc < 40.00) 
            {
                Console.WriteLine("Situação: Obesidade II (severa)");
            }
            else
            {
                Console.WriteLine("Situação: Obesidade III (mórbida)");
            }

            double abaixoPesoIdeal = 18.50 * (altura * altura);
            double acimaPesoIdeal = 24.99 * (altura * altura);

            if(peso <= abaixoPesoIdeal)
            {
                Console.WriteLine("Você precisa ganhar {0} Kg para alcançar o peso 'ideal'", abaixoPesoIdeal - peso);
            }
            else if(peso >= acimaPesoIdeal) {
                Console.WriteLine("Você precisa perder {0} Kg para alcançar o peso 'ideal'", peso - acimaPesoIdeal);
            }
        }
    }
}
public class Pessoa 
{
    public string Nome { get; set; }
    public float Altura { get; set; }
    public float Peso { get; set; }
    public double imc;
    public double CalcularIMC {
        get 
        {
            imc = Peso / (Altura * Altura);
            return imc;
        }
    }
    
    public Pessoa(string nome, float altura, float peso)
    {
        Nome = nome;
        Altura = altura;
        Peso = peso;
    }

    public void situacaoPessoa() 
    {
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

        double abaixoPesoIdeal = 18.50 * (Altura * Altura);
        double acimaPesoIdeal = 24.99 * (Altura * Altura);

        if(Peso <= abaixoPesoIdeal)
        {
        Console.WriteLine("Você precisa ganhar {0} Kg para alcançar o peso 'ideal'", abaixoPesoIdeal - Peso);
        }
        else if(Peso >= acimaPesoIdeal) {
        Console.WriteLine("Você precisa perder {0} Kg para alcançar o peso 'ideal'", Peso - acimaPesoIdeal);
        }
    }
}
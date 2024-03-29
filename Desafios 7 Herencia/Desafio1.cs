using System;

class Calculadora
{
    public string Marca { get; set; }
    public string Serie { get; set; }

    public double Sumar(double a, double b)
    {
        return a + b;
    }

    public double Restar(double a, double b)
    {
        return a - b;
    }

    public double Multiplicar(double a, double b)
    {
        return a * b;
    }

    public double Dividir(double a, double b)
    {
        if (b != 0)
            return a / b;
        else
            throw new DivideByZeroException("No se puede dividir por cero");
    }
}

class CalculadoraCientifica : Calculadora
{
    public double Potencia(double a, double b)
    {
        return Math.Pow(a, b);
    }

    public double Raiz(double a)
    {
        return Math.Sqrt(a);
    }

    public double Modulo(double a)
    {
        return Math.Abs(a);
    }

    public double Logaritmo(double a)
    {
        return Math.Log(a);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculadora calculadora = new Calculadora
        {
            Marca = "Casio",
            Serie = "FX-82MS"
        };

        CalculadoraCientifica calculadoraCientifica = new CalculadoraCientifica
        {
            Marca = "Texas Instruments",
            Serie = "TI-84 Plus CE"
        };

        Console.WriteLine("Calculadora:");
        Console.WriteLine("2 + 3 = " + calculadora.Sumar(2, 3));
        Console.WriteLine("5 - 2 = " + calculadora.Restar(5, 2));
        Console.WriteLine("4 * 6 = " + calculadora.Multiplicar(4, 6));
        Console.WriteLine("10 / 2 = " + calculadora.Dividir(10, 2));

        Console.WriteLine("\nCalculadora Científica:");
        Console.WriteLine("2^3 = " + calculadoraCientifica.Potencia(2, 3));
        Console.WriteLine("√25 = " + calculadoraCientifica.Raiz(25));
        Console.WriteLine("|(-5)| = " + calculadoraCientifica.Modulo(-5));
        Console.WriteLine("log(10) = " + calculadoraCientifica.Logaritmo(10));

        Console.ReadLine();
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número para calcular sus divisores: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Los divisores de " + numero + " son: ");
        CalcularDivisores(numero);

        Console.ReadLine();
    }

    static void CalcularDivisores(int numero)
    {
        for (int i = 1; i <= numero; i++)
        {
            if (numero % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}

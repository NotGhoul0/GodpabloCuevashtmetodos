using System;

class Electrodomestico
{
    public double PrecioBase { get; set; }
    public char ConsumoEnergetico { get; set; }
    public string Color { get; set; }
    public double Peso { get; set; }

    public Electrodomestico(double precioBase, char consumoEnergetico, string color, double peso)
    {
        PrecioBase = precioBase;
        ConsumoEnergetico = consumoEnergetico;
        Color = color;
        Peso = peso;
    }

    public double CalcularPrecioFinal()
    {
        double precioFinal = PrecioBase;

        // Aumentar precio según consumo energético
        switch (ConsumoEnergetico)
        {
            case 'A':
                precioFinal += 100;
                break;
            case 'B':
                precioFinal += 80;
                break;
            case 'C':
                precioFinal += 60;
                break;
            case 'D':
                precioFinal += 50;
                break;
            default:
                Console.WriteLine("Consumo energético inválido. No se aplicará aumento.");
                break;
        }

        // Aplicar recargo según peso
        if (Peso > 20 && Peso < 40)
        {
            precioFinal *= 1.05; // 5% de recargo
        }
        else if (Peso >= 40)
        {
            precioFinal *= 1.1; // 10% de recargo
        }

        return precioFinal;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el precio base del electrodoméstico: ");
        double precioBase = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el consumo energético (letras A - D): ");
        char consumoEnergetico = Convert.ToChar(Console.ReadLine().ToUpper());

        Console.WriteLine("Ingrese el color del electrodoméstico: ");
        string color = Console.ReadLine();

        Console.WriteLine("Ingrese el peso del electrodoméstico: ");
        double peso = Convert.ToDouble(Console.ReadLine());

        Electrodomestico electrodomestico = new Electrodomestico(precioBase, consumoEnergetico, color, peso);

        double precioFinal = electrodomestico.CalcularPrecioFinal();

        Console.WriteLine("El precio final del electrodoméstico es: " + precioFinal);
        Console.ReadLine();
    }
}


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Seleccione la figura para la cual desea calcular el área (1: Círculo, 2: Cuadrado, 3: Triángulo): ");
        int opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                // Calcular el área de un círculo
                Console.WriteLine("Ingrese el radio del círculo: ");
                double radioCirculo = Convert.ToDouble(Console.ReadLine());
                double areaCirculo = CalcularAreaCirculo(radioCirculo);
                Console.WriteLine("El área del círculo es: " + areaCirculo);
                break;
            case 2:
                // Calcular el área de un cuadrado
                Console.WriteLine("Ingrese el lado del cuadrado: ");
                double ladoCuadrado = Convert.ToDouble(Console.ReadLine());
                double areaCuadrado = CalcularAreaCuadrado(ladoCuadrado);
                Console.WriteLine("El área del cuadrado es: " + areaCuadrado);
                break;
            case 3:
                // Calcular el área de un triángulo
                Console.WriteLine("Ingrese la base del triángulo: ");
                double baseTriangulo = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese la altura del triángulo: ");
                double alturaTriangulo = Convert.ToDouble(Console.ReadLine());
                double areaTriangulo = CalcularAreaTriangulo(baseTriangulo, alturaTriangulo);
                Console.WriteLine("El área del triángulo es: " + areaTriangulo);
                break;
            default:
                Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                break;
        }

        Console.ReadLine();
    }

    static double CalcularAreaCirculo(double radio)
    {
        double area = Math.PI * radio * radio;
        return area;
    }

    static double CalcularAreaCuadrado(double lado)
    {
        double area = lado * lado;
        return area;
    }

    static double CalcularAreaTriangulo(double baseTriangulo, double alturaTriangulo)
    {
        double area = (baseTriangulo * alturaTriangulo) / 2;
        return area;
    }
}

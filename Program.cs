using System;

// Definición de la clase Circulo
public class Circulo
{
    // Radio del círculo. Es un tipo de dato primitivo (double) que encapsula la propiedad del círculo.
    private double radio;

    // Constructor de la clase Circulo.
    // Permite inicializar el radio del círculo al crear una instancia de la clase.
    public Circulo(double radioInicial)
    {
        radio = radioInicial;
    }

    // Propiedad para obtener el radio.
    // Permite acceder al valor del radio desde fuera de la clase.
    public double Radio
    {
        get { return radio; }
        // Se puede añadir un 'set' si se permite modificar el radio después de la creación.
        // set { radio = value; }
    }

    // CalcularArea es una función que devuelve un valor double.
    // Se utiliza para calcular el área de un círculo.
    // No requiere argumentos adicionales ya que utiliza el radio encapsulado en la clase.
    public double CalcularArea()
    {
        return Math.PI * radio * radio;
    }

    // CalcularPerimetro es una función que devuelve un valor double.
    // Se utiliza para calcular el perímetro (circunferencia) de un círculo.
    // No requiere argumentos adicionales ya que utiliza el radio encapsulado en la clase.
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}

// Definición de la clase Cuadrado
public class Cuadrado
{
    // Lado del cuadrado. Es un tipo de dato primitivo (double) que encapsula la propiedad del cuadrado.
    private double lado;

    // Constructor de la clase Cuadrado.
    // Permite inicializar el lado del cuadrado al crear una instancia de la clase.
    public Cuadrado(double ladoInicial)
    {
        lado = ladoInicial;
    }

    // Propiedad para obtener el lado.
    // Permite acceder al valor del lado desde fuera de la clase.
    public double Lado
    {
        get { return lado; }
        // Se puede añadir un 'set' si se permite modificar el lado después de la creación.
        // set { lado = value; }
    }

    // CalcularArea es una función que devuelve un valor double.
    // Se utiliza para calcular el área de un cuadrado.
    // No requiere argumentos adicionales ya que utiliza el lado encapsulado en la clase.
    public double CalcularArea()
    {
        return lado * lado;
    }

    // CalcularPerimetro es una función que devuelve un valor double.
    // Se utiliza para calcular el perímetro de un cuadrado.
    // No requiere argumentos adicionales ya que utiliza el lado encapsulado en la clase.
    public double CalcularPerimetro()
    {
        return 4 * lado;
    }
}

// Clase principal para probar las figuras geométricas
public class Programa
{
    public static void Main(string[] args)
    {
        // Crear una instancia de la clase Circulo con un radio de 5.0
        Circulo miCirculo = new Circulo(5.0);
        Console.WriteLine("--- Círculo ---");
        Console.WriteLine($"Radio: {miCirculo.Radio}");
        // Calcular y mostrar el área del círculo
        Console.WriteLine($"Área del Círculo: {miCirculo.CalcularArea():F2}"); // :F2 formatea a 2 decimales
        // Calcular y mostrar el perímetro del círculo
        Console.WriteLine($"Perímetro del Círculo: {miCirculo.CalcularPerimetro():F2}");

        Console.WriteLine("\n"); // Salto de línea para separar las salidas

        // Crear una instancia de la clase Cuadrado con un lado de 4.0
        Cuadrado miCuadrado = new Cuadrado(4.0);
        Console.WriteLine("--- Cuadrado ---");
        Console.WriteLine($"Lado: {miCuadrado.Lado}");
        // Calcular y mostrar el área del cuadrado
        Console.WriteLine($"Área del Cuadrado: {miCuadrado.CalcularArea():F2}");
        // Calcular y mostrar el perímetro del cuadrado
        Console.WriteLine($"Perímetro del Cuadrado: {miCuadrado.CalcularPerimetro():F2}");

        Console.ReadKey(); // Espera una tecla para cerrar la consola
    }
}

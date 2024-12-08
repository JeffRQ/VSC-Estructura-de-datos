// See https://aka.ms/new-console-template for more information
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;
using System;

namespace FigurasGeometricas
{
    // Clase Rectángulo
    public class Rectangulo
    {
        // Atributos encapsulados
        private double largo; // Largo del rectángulo
        private double ancho; // Ancho del rectángulo

        // Constructor
        public Rectangulo(double largoParam, double anchoParam)
        {
            largo = largoParam;
            ancho = anchoParam;
        }

        // Método para calcular el área
        public double Area()
        {
            return largo * ancho;
        }

        // Método para calcular el perímetro
        public double Perimetro()
        {
            return 2 * (largo + ancho);
        }
    }

    // Clase Triángulo
    public class Triangulo
    {
        // Atributos encapsulados
        private double baseTriangulo; // Base del triángulo
        private double altura; // Altura del triángulo
        private double lado1; // Lado 1 del triángulo
        private double lado2; // Lado 2 del triángulo
        private double lado3; // Lado 3 del triángulo

        // Constructor
        public Triangulo(double baseTrianguloParam, double alturaParam, double lado1Param, double lado2Param, double lado3Param)
        {
            baseTriangulo = baseTrianguloParam;
            altura = alturaParam;
            lado1 = lado1Param;
            lado2 = lado2Param;
            lado3 = lado3Param;
        }

        // Método para calcular el área
        public double Area()
        {
            return (baseTriangulo * altura) / 2;
        }

        // Método para calcular el perímetro
        public double Perimetro()
        {
            return lado1 + lado2 + lado3;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======== UNIVERSIDAD ESTATAL AMAZÓNICA ========");
            Console.WriteLine("*Nombre: Jorge Ramírez");
            Console.WriteLine("*Fecha: 05/12/2025");
            Console.WriteLine("*Curso: A");
            Console.WriteLine("===== Cálculo de Área y Perímetro de Figuras Geométricas =====");

            // Opción de elegir figura
            Console.WriteLine("Seleccione la figura a calcular:");
            Console.WriteLine("1. Rectángulo");
            Console.WriteLine("2. Triángulo");
            Console.Write("Ingrese el número de la opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            try
            {
                if (opcion == 1)
                {
                    // Cálculo para el Rectángulo
                    Console.Write("Ingrese el largo del rectángulo: ");
                    double largo = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese el ancho del rectángulo: ");
                    double ancho = Convert.ToDouble(Console.ReadLine());

                    Rectangulo rectangulo = new Rectangulo(largo, ancho);

                    Console.WriteLine("\n=== Resultados del Rectángulo ===");
                    Console.WriteLine($"Área: {rectangulo.Area()}");
                    Console.WriteLine($"Perímetro: {rectangulo.Perimetro()}");
                }
                else if (opcion == 2)
                {
                    // Cálculo para el Triángulo
                    Console.Write("Ingrese la base del triángulo: ");
                    double baseTriangulo = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese la altura del triángulo: ");
                    double altura = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese el lado 1 del triángulo: ");
                    double lado1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese el lado 2 del triángulo: ");
                    double lado2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese el lado 3 del triángulo: ");
                    double lado3 = Convert.ToDouble(Console.ReadLine());

                    Triangulo triangulo = new Triangulo(baseTriangulo, altura, lado1, lado2, lado3);

                    Console.WriteLine("\n=== Resultados del Triángulo ===");
                    Console.WriteLine($"Área: {triangulo.Area()}");
                    Console.WriteLine($"Perímetro: {triangulo.Perimetro()}");
                }
                else
                {
                    Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\nError: Por favor, ingrese solo números válidos.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nOcurrió un error: {ex.Message}");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            
        }
    }
}

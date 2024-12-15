// See https://aka.ms/new-console-template for more information
using System;

public class Producto
{
    // Aqui se ingresan los atributos privados
    private int Id;
    private string Nombre;
    private string Unidad;
    private double[] Precios;

    // Se crea el constructor público
    public Producto(int id, string nombre, string unidad, double precio1, double precio2, double precio3)
    {
        Id = id;
        Nombre = nombre;
        Unidad = unidad;
        Precios = new double[] { precio1, precio2, precio3 };
    }

    // Método público para mostrar los detalles del producto
    public void MostrarProducto()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Unidad: {Unidad}");
        Console.WriteLine("Precios:");
        Console.WriteLine($"Precio al por mayor: {Precios[0]:C}");
        Console.WriteLine($"Precio por unidad: {Precios[1]:C}");
        Console.WriteLine($"Precio a crédito: {Precios[2]:C}");
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        // Muestra los datos y titulo de la tarea
        Console.WriteLine("======== UNIVERSIDAD ESTATAL AMAZÓNICA ========");
        Console.WriteLine("Nombre: Jorge Ramírez");
        Console.WriteLine("*Fecha: 11/12/2025");
        Console.WriteLine("*Curso: A");
        Console.WriteLine("======== Arrays y Matrices ========");
        Console.WriteLine();

        // Arreglo para almacenar productos
        Producto[] productos = new Producto[3];

        // Aqui se crean los productos con sus precios
        productos[0] = new Producto(1, "Soldadora", "Unidad", 165.50, 180.75, 235.00);
        productos[1] = new Producto(2, "Moladora", "Unidad", 112.80, 145.20, 192.99);
        productos[2] = new Producto(3, "Taladro", "Unidad", 120.00, 137.00, 158.00);

        // Muestra productos usando un bucle for
        for (int i = 0; i < productos.Length; i++)
        {
            productos[i].MostrarProducto();
        }
    }
}


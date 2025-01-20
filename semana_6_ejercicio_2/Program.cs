// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Solicitar la cantidad de datos a ingresar
        Console.Write("Ingrese la cantidad de datos para las listas: ");
        int cantidad = int.Parse(Console.ReadLine());

        // Inicializar las listas
        List<int> lista1 = new List<int>();
        List<int> lista2 = new List<int>();

        // Ciclo de carga para la primera lista
        Console.WriteLine("Ingrese los datos para la primera lista:");
        for (int i = 0; i < cantidad; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            lista1.Add(int.Parse(Console.ReadLine()));
        }

        // Ciclo de carga para la segunda lista
        Console.WriteLine("Ingrese los datos para la segunda lista:");
        for (int i = 0; i < cantidad; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            lista2.Add(int.Parse(Console.ReadLine()));
        }

        // Comparar las listas
        CompararListas(lista1, lista2);
    }

    static void CompararListas(List<int> lista1, List<int> lista2)
    {
        if (lista1.Count == lista2.Count)
        {
            if (ListEquals(lista1, lista2))
            {
                Console.WriteLine("Las listas son iguales en tamaño y en contenido.");
            }
            else
            {
                Console.WriteLine("Las listas son iguales en tamaño pero no en contenido.");
            }
        }
        else
        {
            Console.WriteLine("No tienen el mismo tamaño ni contenido.");
        }
    }

    static bool ListEquals(List<int> lista1, List<int> lista2)
    {
        for (int i = 0; i < lista1.Count; i++)
        {
            if (lista1[i] != lista2[i])
            {
                return false;
            }
        }
        return true;
    }
}

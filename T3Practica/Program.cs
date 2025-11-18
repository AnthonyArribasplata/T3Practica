using System;

namespace T3Practica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Grafo G = new Grafo();
            // vertices de A a F
            G.insertarVerticeLista("A");
            G.insertarVerticeLista("B");
            G.insertarVerticeLista("C");
            G.insertarVerticeLista("D");
            G.insertarVerticeLista("E");
            G.insertarVerticeLista("F");

            Console.WriteLine("Vertices:");
            G.MostrarVerticesLista();

            Console.WriteLine("\nMatriz de adyacencia:");
            G.crearMatrizAdyacencia();
            G.MostrarMatrizAdyacencia();
        }
    }
}
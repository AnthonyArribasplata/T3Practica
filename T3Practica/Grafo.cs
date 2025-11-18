using System;

namespace T3Practica
{
    public class Grafo
    {
        public Vertice primerVerticeLista = null;
        public int[,] matriz = new int[6, 6];
        Random random = new Random();

        public void insertarVerticeLista(string valor)
        {
            Vertice nuevo = new Vertice();
            nuevo.dato = valor;

            if (primerVerticeLista == null)
            {
                primerVerticeLista = nuevo;
            }
            else
            {
                Vertice temp = primerVerticeLista;
                while (temp.sigVertice != null)
                {
                    temp = temp.sigVertice;
                }
                temp.sigVertice = nuevo;
            }
        }

        public void MostrarVerticesLista()
        {
            Vertice temp = primerVerticeLista;

            while (temp != null)
            {
                Console.Write(temp.dato.PadRight(4));
                temp = temp.sigVertice;
            }

            Console.WriteLine();
        }

        public void crearMatrizAdyacencia()
        {
            Vertice origen = primerVerticeLista;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
               Vertice destino = primerVerticeLista;

                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = random.Next(0, 2); 
                    destino = destino.sigVertice;
                }

                origen = origen.sigVertice;
            }
        }

        public void MostrarMatrizAdyacencia()
        {
            Console.Write("    ");
            //MostrarVerticesLista();

            Vertice fila = primerVerticeLista;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.Write(fila.dato.PadRight(4));

                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j].ToString().PadRight(4)); 
                }

                Console.WriteLine();
                fila = fila.sigVertice;
            }
        }
    }
}
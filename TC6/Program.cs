using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos el grafo 1
            Console.WriteLine("Caminos más cortos desde San Miguel a los demás puntos de llegada \n ");
            int[,] graph =  {
                          { 0, 8, 6, 0, 0 },
                          { 0, 0, 0, 0, 9 },
                          { 0, 0, 0, 16, 0 },
                          { 0, 10, 0, 0, 0 },
                          { 0, 0, 1, 0, 0 },


            };

            //El camino más corto de Dijkstra
            Dijkstra.DijkstraAlgo(graph, 0, 5);

            Console.WriteLine("");

            const int INF = 99999;

            //Creamos el grafo 2
            Console.WriteLine("Caminos más cortos para cada par de puntos.\n");

            int[,] graph2 = {
                            { 0,   8,  6, INF, INF},
                            { INF, 0,  INF, INF, 9 },
                            { INF, INF, 0, 16, INF },
                            { INF, 10, INF, 0, INF },
                            { INF, INF, 1, INF, 0 },
                        };

            //Algoritmo de Warshall
            FloydWarshall.FloydWarshallAlgo(graph2, 5);

            Console.Read();
        }
    }
}

using ClassLibrary;
using System;
using System.Diagnostics;
using System.IO;

namespace esercizio12
{
    class ConsoleApp
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            const string file = ("stat.csv");
            StreamWriter w = new StreamWriter(file);
            int[] dimensioni = { 10,50,100,150,200,250,500,750,1000,1500,2500,3000,5000,7500,10000,};
            w.WriteLine("Algoritmo; Dimensioni; Tempo");
            foreach (int dim in dimensioni)
            {
                int[] array20 = new int[dim];
                for (int i = 0; i < dim; i++)
                {
                    array20[i] = random.Next(1, 1000);
                }
                Stopwatch s = new Stopwatch();
                s.Start();
                int[] array = BubbleSort.Bubblesort(array20);
                s.Stop();
                long elapsed = s.ElapsedMilliseconds;
                w.WriteLine($"BubbleSort ; {array20.Length} ; {elapsed}");
                Console.WriteLine($"BubbleSort ; {array20.Length} ; {elapsed}");
                s.Reset();
                s.Start();
                array = ScambioSentinella.Sentinellascambio.Sentinella(array20);
                s.Stop();
                elapsed = s.ElapsedMilliseconds;
                w.WriteLine($"Sentinella ; {array20.Length} ; {elapsed}");
                Console.WriteLine($"Sentinella ; {array20.Length} ; {elapsed}");
                s.Reset();
                s.Start();
                array = MergeSort.Mergesort.mergeSort(array20);
                s.Stop();
                elapsed = s.ElapsedMilliseconds;
                w.WriteLine($"MergeSort ; {array20.Length} ; {elapsed}");
                Console.WriteLine($"MergeSort ; {array20.Length} ; {elapsed}");
                s.Reset();
                s.Start();
                array = InsertionSort.insertionsort.InsertionSortByShift(array20);
                s.Stop();
                elapsed = s.ElapsedMilliseconds;
                w.WriteLine($"InsertionSort ; {array20.Length} ; {elapsed}");
                Console.WriteLine($"InsertionSort ; {array20.Length} ; {elapsed}");
                s.Reset();
                s.Start();
                array = SelectionSort.selectionsort.seleSort(array20);
                s.Stop();
                elapsed = s.ElapsedMilliseconds;
                w.WriteLine($"SelectionSort ; {array20.Length} ; {elapsed}");
                Console.WriteLine($"SelectionSort ; {array20.Length} ; {elapsed}");


            }
            w.Flush();
            w.Close();
            

        }
    }
}

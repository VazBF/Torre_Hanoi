using System.Diagnostics;
using System.Collections;

namespace Torre_Recursiva
{
    public class Program 
    { 
        static void Main(string[] args)
        {
            Stack[] pilhas = new Stack[3];
            var stopwatch = new Stopwatch();
            Console.WriteLine("Digite o tamanho da torre: ");
            int size = Convert.ToInt32(Console.ReadLine());
            stopwatch.Start();
            Console.WriteLine("Quantidade de movimentos: " + solve(size, 0, 2));
            stopwatch.Stop();
            Console.WriteLine("Tempo decorrido: " + stopwatch.Elapsed);
        }

        public static long solve(int size, int fromTower, int toTower)
        {
            long qtd = 0;
            int other;
            if (size == 1)
            {
                //move of fromTower for toTower;
                qtd++;
            }
            else
            {
                other = 3 - fromTower - toTower;
                qtd = qtd + solve(size - 1, fromTower, other);
                //move of fromTower for toTower
                qtd++;
                qtd = qtd + solve(size - 1, other, toTower);
            }
            return qtd;
        }
    }
}
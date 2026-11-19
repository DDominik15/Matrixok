using System.Runtime.ExceptionServices;

namespace Ijaszverseny
{
    internal class Program
    {
        static int[,] jatekosok;
        static Random r = new Random();
        static string[] JatekosokNevei(int jatekosokSzama)
        {
            string[] nevek = { "Anna", "Bence", "Csaba", "Dóra", "Eszter", "Ferenc", "Gábor", "Hanna", "István", "Judit", "Katalin", "László", "Márk", "Nóra", "Orsolya", "Péter", "Réka", "Sándor", "Tamás", "Viktória", "Zoltán", "Ádám", "Balázs", "Cecília", "Dávid", "Emese", "Flóra", "György", "Levente", "Mihály" };
            string[] jatekosok = new string[jatekosokSzama];
            for (int i = 0; i < jatekosokSzama; i++)
            {
                int index = r.Next(0, nevek.Length);
                jatekosok[i] = nevek[index];
            }
            return jatekosok;
        }
        static int[,] Feltolt(int jatekosokSzama)
        {
            int[,] matrix = new int[jatekosokSzama, 5];
            for (int i = 0; i < jatekosokSzama; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = r.Next(0, 26);
                }
            }
            return matrix;
        }
        static void Main(string[] args)
        {
            Console.Write("Játékosok száma: ");
            int jatekosokSzama = Convert.ToInt32(Console.ReadLine());
            int[,] jatekosok = Feltolt(jatekosokSzama);
            string[] nevek = JatekosokNevei(jatekosokSzama);
            foreach (var item in nevek)
            {
                Console.WriteLine(item);
            }
            int winningIndex = -1;
            int winningSum = -1;
            for (int i = 0; i < jatekosok.GetLength(0); i++)
            {
                int sum = 0;
                Console.WriteLine();
                for (int j = 0; j < jatekosok.GetLength(1); j++)
                {
                    Console.Write($"A(z) {i+1}. játékos: {nevek[i]} pontjai: ");
                    Console.Write($"{jatekosok[i, j],5}");
                    Console.WriteLine();

                    sum += jatekosok[i, j];
                    
                }

                if (sum > winningSum)
                {
                    winningSum = sum;
                    winningIndex = i;
                }

            }
            
            if (winningIndex == -1 || winningSum == -1)
            {
                Console.WriteLine("Hiba tortént!");
                return;
            }

            Console.WriteLine($"Nyertes jatekos: {nevek[winningIndex]} ponszáma: {winningSum}");
        }
    }
}

using System.Numerics;

namespace Matrixok
{
    internal class Program
    {
        static int sorokszama = 10;
        static int oszlopokSzama = 6;
        static int[,] szamokMatrix = new int[sorokszama, oszlopokSzama];
        static int[,] negyzetesMatrix = new int[5, 5];
        static Random r = new Random();
        static void F01(int[,] matrix, int min, int max)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = r.Next(min, max+1);
                }
            }
            
        }

        static void F02(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j], 5}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        
        static void F03()
        {
            int sum = 0;
            for (int i = 0; i < sorokszama; i++)
            {
                for (int j = 0; j < oszlopokSzama; j++)
                {
                    sum += szamokMatrix[i, j];
                }
            }
            Console.WriteLine("Matrixban levo elemek osszege: " + sum);
        }

        static void F04()
        {
            for (int i = 0; i < sorokszama; i++)
            {
                int sum = 0;
                for (int j = 0; j < oszlopokSzama; j++)
                {
                    sum += szamokMatrix[i, j];
                }
                Console.WriteLine($"A {i+1}. sornak az elemeinek az osszege: {sum}");
            }
            Console.WriteLine();
        }

        static void F05()
        {
            for (int j = 0; j < oszlopokSzama; j++)
            {
                int sum = 0;
                for (int i = 0; i < sorokszama; i++)
                {
                    sum += szamokMatrix[i, j];
                }
                Console.WriteLine($"A {j + 1}. oszlop az elemeinek az osszege: {sum}");
            }
            Console.WriteLine();
        }
        static void BalAtloSum(int[,] matrix)
        {
            int sum = 0;
            Console.Write("Az átlo: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, i];
                Console.Write($"{matrix[i, i], 5}");
            }
            Console.WriteLine();
            Console.WriteLine("A mátrix bal átlojának összege: " + sum);
        }
        static void JobbAtloSum(int[,] matrix)
        {
            int sum = 0;
            Console.Write("Az átlo: ");
            int j = matrix.GetLength(1) - 1;
            for (int i = 0; i < matrix.GetLength(0) ; i++)
            {
                sum += matrix[i, j];
                Console.Write($"{matrix[i, j],5}");
                j--;

            }
            Console.WriteLine();
            Console.WriteLine("A mátrix bal átlojának összege: " + sum);
        }
        static void Main(string[] args)
        {
            //F01(szamokMatrix, 10, 99);
            //F02(szamokMatrix);
            //F03();
            //F04();
            //F05();
            //Console.WriteLine("----------------------------------------------");
            F01(negyzetesMatrix, 1, 9);
            F02(negyzetesMatrix);
            BalAtloSum(negyzetesMatrix);
            JobbAtloSum(negyzetesMatrix);

            int[,] masolat = negyzetesMatrix;
            masolat[0, 0] = 100;
            Console.WriteLine("A masolat elemei: ");
            F02(masolat);
            Console.WriteLine("A negzyetes martix: ");
            F02(negyzetesMatrix);
        }
    }
}

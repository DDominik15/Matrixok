namespace Matrixok
{
    internal class Program
    {
        static int sorokszama = 10;
        static int oszlopokSzama = 6;
        static int[,] szamokMatrix = new int[sorokszama, oszlopokSzama];
        static Random r = new Random();
        static void F01()
        {
            for (int i = 0; i < sorokszama; i++)
            {
                for (int j = 0; j < oszlopokSzama; j++)
                {
                    szamokMatrix[i, j] = r.Next(10, 100);
                }
            }

        }

        static void F02()
        {
            for (int i = 0; i < sorokszama; i++)
            {
                for (int j = 0; j < oszlopokSzama; j++)
                {
                    Console.Write(szamokMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
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

        static void Main(string[] args)
        {
            F01();
            F02();
            F03();
            F04();
            F05();
        }
    }
}

namespace Cicaszepsegversenyen
{
    internal class Program
    {
        static Random r = new Random();
        static int[,] Feltoltes(int count)
        {
            int[,] matrix = new int[count, 3];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = r.Next(1, 11);
                }
            }

            return matrix;
        }
        static void GetWinners(int[,] matrix)
        {
            string[] options = {"Legéhesebb", "Lustaság","Legjátékosabb"};
            
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int max = -1;
                int index = -1;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                        index = i;
                    }
                }
                

                if (index == -1 || max == -1)
                {
                    Console.WriteLine($"Hiba tortént a {options[j]} cica számításakor!");
                    return;
                }

                Console.WriteLine($"A {options[j]} macska azonosítója: {index+1}");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Hány cica versenyzik: ");
            int count = Convert.ToInt32(Console.ReadLine());
            int[,] cicak = Feltoltes(count);
            GetWinners(cicak);
        }
    }
}

namespace Ступенчатые__Зубчатые__массивы
{
    /*  
     * Ступенчатые (зубчатые) массивы 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Random RandomNumberArray = new Random();
            int[][] NewArray = new int [3][];
            NewArray[0] = new int[4];
            NewArray[1] = new int[6];
            NewArray[2] = new int[2];
            for (int i = 0; i < NewArray.Length; i++)
            {
                for (int j = 0; j < NewArray[i].Length; j++)
                {
                    NewArray[i][j] = RandomNumberArray.Next(100);
                }
            }
            for (int y = 0; y < NewArray.Length; y++)
            {
                for (int x = 0; x < NewArray[y].Length; x++)
                {
                    Console.Write(NewArray[y][x] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
// Показать двумерный массив размером m×n заполненный целыми числами

int n = 5;
int m = 6;
int[,] array = new int [n, m];
for(int i=0; i<array.GetLength(0); i++)
{
    for(int j=0; j<array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(1,100);
        Console.Write("${array[i,j]} ");

    }
    Console.WriteLine();
}

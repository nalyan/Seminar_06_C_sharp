// 1. Показать двумерный массив размером m×n заполненный вещественными числами

void FillMatrix(double[,] matrix, double min, double max)
{
    var random = new Random();
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(random.NextDouble() * ((max - min) + min), 3);
        }
    }
}
int InputNumber(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
void PrintArray(double[,] matrix)
{
    for(int i = 0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++) 
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}
Console.Clear();
int m = InputNumber("Введите количество строк: ");
int n = InputNumber("Введите количество столбцов: ");
double[,] matrix = new double[m,n];
FillMatrix(matrix, -100, 100);
PrintArray(matrix);
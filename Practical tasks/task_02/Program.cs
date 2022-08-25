// Задать двумерный массив следующим правилом: Aₘₙ = m+n

int InputNumber(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
void PrintMatrix(int[,] matrix)
{
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++) Console.Write($"{matrix[i, j]} ");
        Console.WriteLine();
    }
}

Console.Clear();
int m = InputNumber("Введите количество строк: ");
int n = InputNumber("Введите количество столбцов: ");
int[,] matrix = new int[m, n];
for(int i = 0; i<matrix.GetLength(0); i++)
{
    for(int j=0; j<matrix.GetLength(1); j++)
    {
        matrix[i,j] = i+j;
    }
}
PrintMatrix(matrix);

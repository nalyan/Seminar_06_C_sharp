// 3. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

int InputNumber(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
void FillMatrix(int[,] matrix, int min, int max)
{
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        var rnd = new Random();
        for(int j=0; j<matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(min, max);
        }
    }
}
void PrintMatrix(int[,] matrix)
{
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine(); 
}

Console.Clear();
int m = InputNumber("Введите количество строк: ");
int n = InputNumber("Введите количество столбцов: ");
int[,] matrix = new int[m, n];
FillMatrix(matrix, -10, 10);
PrintMatrix(matrix);

for(int i=0; i<matrix.GetLength(0); i++)
{
    for(int j=0; j<matrix.GetLength(1); j++)
    {
        if(matrix[i,j]%2 == 0) matrix[i, j] = matrix[i, j] * matrix[i, j];
    }
}

PrintMatrix(matrix);

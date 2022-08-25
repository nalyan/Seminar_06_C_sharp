// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

void PrintArray(int[,] matrix){
  for (int i = 0; i < matrix.GetLength(0); i++ )
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i,j]}\t");
        Console.WriteLine(" ");
    }
    
}
void FillArrayRandom(int[,] matrix, int min, int max){
    var rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++ )
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            matrix[i,j] = rand.Next(min, max+1);
    }
}

void FindArray(int[,] matrix, int number){
    bool q = false;
    for (int i = 0; i < matrix.GetLength(0); i++ )
    {
    for(int j = 0; j < matrix.GetLength(1); j++)
        if (matrix[i,j] == number)
        {
            Console.WriteLine($"Позиция числа {number}: ({i}, {j})");
            q = true;
        }
    }
    if(q == false) Console.WriteLine("Такого числа нет в массиве");
}

Console.Clear();
int m,n;
m = int.Parse(Console.ReadLine());
n = int.Parse(Console.ReadLine());
int[,] array = new int[m,n];
FillArrayRandom(array, -10, 10);
PrintArray(array);
Console.WriteLine();

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
FindArray(array, number);


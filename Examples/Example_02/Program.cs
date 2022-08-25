// В двумерном массиве n×k заменить четные элементы на противоположные

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
void NegativeArrayRandom(int[,] matrix){
    
    for (int i = 0; i < matrix.GetLength(0); i++ )
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        if (matrix[i,j]%2 == 0)
        {
            matrix[i,j] = matrix[i,j] *-1;
        }   
    }
}
Console.Clear();

int m,n;
m = int.Parse(Console.ReadLine());
n = int.Parse(Console.ReadLine());
int[,] array = new int[m,n];
FillArrayRandom(array, -10, 10);
PrintArray(array);
NegativeArrayRandom(array);
Console.WriteLine();
PrintArray(array);


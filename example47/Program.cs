// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите колличество строк и столбцов --> ");
Console.Write("Колличество строк --> ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Колличество столбцов --> ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[rows, columns];

double[,] CreateMatrix(double[,] matr)
{
var random = new Random();
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        matr[i, j] = random.Next(-10, 10);
    }
}
return matr;
}

double[,] twoDimensionalArray = CreateMatrix(matrix);
PrintMatrix(twoDimensionalArray);

  void PrintMatrix(double[,] matr)
  {
     for (int i = 0; i < matr.GetLength(0); i++)                     
    {                                                                 
        for (int j = 0; j < matr.GetLength(1); j++)                 
        {
            Console.Write($"{matr[i, j]}    ");
        }
    Console.WriteLine();
    }
  }
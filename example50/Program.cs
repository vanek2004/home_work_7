// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.WriteLine("Введите колличество строк и столбцов --> ");
Console.Write("Колличество строк --> ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Колличество столбцов --> ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер строки и столбца, что бы увидеть значение --> ");
Console.Write("Номер строки --> ");
int numRows = (Convert.ToInt32(Console.ReadLine()))-1;
Console.Write("Номер столбца --> ");
int numColumns = (Convert.ToInt32(Console.ReadLine()))-1;
 

    
double[,] matrix = new double[rows, columns];

double[,] CreateMatrix(double[,] matr)
{
var random = new Random();
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        matr[i, j] = random.Next(0, 10);
    }
}
return matr;
}




double[,] twoDimensionalArray = CreateMatrix(matrix);
PrintMatrix(twoDimensionalArray);
if (numRows>rows && numColumns>columns)
    {
        Console.WriteLine("no");
    }
    else
    {
        Console.WriteLine($"{twoDimensionalArray[numRows, numColumns]}");
    }

   


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



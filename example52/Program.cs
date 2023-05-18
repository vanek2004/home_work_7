// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



Console.WriteLine("Введите колличество строк и столбцов --> ");
Console.Write("Колличество строк --> ");
int rows = (Convert.ToInt32(Console.ReadLine()));
Console.Write("Колличество столбцов --> ");
int columns = (Convert.ToInt32(Console.ReadLine()));

int[,] matrix = new int[rows, columns];

int[,] CreateMatrix(int[,] matr)
{
var random = new Random();
for (int i = 0; i < matr.GetLength(0); i++)               //заполняем массив случайными числами
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        matr[i, j] = random.Next(0, 10);
    }
}
return matr;
}



int[,] twoDimensionalArray = CreateMatrix(matrix);
PrintMatrix(twoDimensionalArray);
double arithmeticMean = ArithmeticMean(twoDimensionalArray);
Console.Write(arithmeticMean);



  void PrintMatrix(int[,] matr)
  {
     for (int i = 0; i < matr.GetLength(0); i++)                     
    {                                                                 
        for (int j = 0; j < matr.GetLength(1); j++)                 //выводим его
        {
            Console.Write($"{matr[i, j]}    ");
        }
    Console.WriteLine();
    }
  }



  double ArithmeticMean(int[,] matr)
  {
    int num =0;
    double result = 0;
    for (int j = 0; j < (matr.GetLength(1))-1; j++)                     
    {                                                                 
        for (int i = 0; i < (matr.GetLength(0))-1; i++)                 
        {                                                            //ищем среднее арифметическое столбцов
            num = num + matr[i, j];
        }
        Console.Write($"{result = num / matr.GetLength(0)}   ");
    }
    return result;
  }
  Console.WriteLine();
// // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] num=new int[n,m];
double []column= new double [n];
for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1); j++)
    {

        num[i, j] = new Random().Next(1, 10);
        Console.Write($"   {num[i, j]}");
    }
    Console.WriteLine();
}
for (var i = 0; i < num.GetLength(0); i++)
{
    for (var j = 0; j < num.GetLength(1); j++)
    {
column[i]+=num[j,i];
    }
    Console.Write($"  {Math.Round (column[i]/num.GetLength(0),1)}");
 }
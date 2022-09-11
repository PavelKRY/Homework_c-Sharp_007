// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] array = new int [3,4];
Random rnd = new Random();


for(int i = 0; i < 3; i++)
{
    for(int j = 0; j< 4; j++)
    {
        array[i,j]= rnd.Next(1,10);
        Console.Write(" " + array[i,j]);
    }
    Console.WriteLine(string.Empty);
}
Console.WriteLine(string.Empty);
for(int j = 0; j < 4; j++)
{
    double midSum = 0;
    for(int i = 0; i< 3; i++)
    {
        midSum = (midSum + array[i,j]);
    }
    Console.WriteLine(Math.Round(midSum/3,1));
}

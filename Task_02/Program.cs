// Напишите программу, которая на вход принимает позиции (две) элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.WriteLine("Введите первую позицию");
int inputI = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите вторую позицию");
int inputJ = Convert.ToInt32(Console.ReadLine());

int[,] array = new int [3,3];
Random rnd = new Random();

if(inputI < 3 && inputI >= 0 && inputJ >= 0 && inputJ < 3)
{
for(int i = 0;i<3;i++)
{
    for(int j = 0; j<3; j++)
    {
        array[i,j] = rnd.Next(1,10);
        if(inputI==i&&inputJ==j)
        {
            Console.WriteLine("Число с этими индексами: " + array[inputI,inputJ]);
        }
    }
}
}
else
{
    Console.WriteLine("Такого числа нет");
}

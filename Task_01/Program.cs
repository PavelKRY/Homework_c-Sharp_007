//  Задайте двумерный массив размером m×n, заполненный случайными вещественными (тип double) числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

int firstStr = Convert.ToInt32(Console.ReadLine());
int secondStolb = Convert.ToInt32(Console.ReadLine());
double[,] array = new double [firstStr,secondStolb];
Random rnd = new Random();
for(int i = 0; i< firstStr; i++)
{
    for(int j =0; j<secondStolb;j++)
    {
        array[i,j] = rnd.NextDouble()*(5-10)+10;
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine(String.Empty);
} 
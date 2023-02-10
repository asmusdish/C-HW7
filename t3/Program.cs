//Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double[,] GenerateArray(int m, int n, int min, int max)
{double[,] array = new double[m, n];
Random random = new Random();
for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = random.Next(min, max + 1);
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}

void PrintArray2(double[] array)
{
    for (int i = 0; i < array.Length; i++) 
        Console.Write(array[i].ToString("##.#") + " ");
}

double[] ArithmeticMean(double[,] array)
{
    double[] ArithmeticMeanArray = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {   
        double result = 0;
        for (int i = 0; i < array.GetLength(0); i++)
            result = result + array[i, j];
        ArithmeticMeanArray[j] = result/array.GetLength(0);
    }
    return ArithmeticMeanArray;
}

var array = GenerateArray(3, 4, 0, 9);
PrintArray(array);
double[] array2 = ArithmeticMean(array);
Console.WriteLine();
PrintArray2(array2);
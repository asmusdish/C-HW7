//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int[,] GenerateArray(int m, int n, int min, int max)
{int[,] array = new int[m, n];
Random random = new Random();
for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = random.Next(min, max + 1);
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}

int FindPosition(int[,] array, int x, int y)
{
    if(x < 0 || y < 0 || x > array.GetLength(0) || y > array.GetLength(1))
        return -1;
        int result = array[x, y];
        return result;
}

var array = GenerateArray(3, 4, 0, 9);
PrintArray(array);
Console.WriteLine("Введите номер строки: ");
int.TryParse(Console.ReadLine(), out int x);
Console.WriteLine("Введите номер столбца: ");
int.TryParse(Console.ReadLine(), out int y);

int result = FindPosition(array, x, y);
Console.WriteLine(result == -1? "Такого элемента нет" : $"Значение выбранной позиции = {result}");

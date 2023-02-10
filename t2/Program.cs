//Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет (формат ввода произвольный, не обязательно через запятую)

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

// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int DataEntry(string message)
{
	Console.Write(message);
	return Convert.ToInt32(Console.ReadLine());
}

void FillTwoDimensionalArray(double[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			array[i, j] = new Random().Next(1, 100);
		}
	}
}


void PrintTwoDimensionalArray(double[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			System.Console.Write(array[i, j] + " ");
		}
		System.Console.WriteLine();
	}
}
System.Console.WriteLine("Задайте размер двухмерного массива");
int rows = DataEntry("Введите количество строк ");
int columns = DataEntry("Введите количество столбцов ");
double[,] numbers = new double[rows, columns];
FillTwoDimensionalArray(numbers);
PrintTwoDimensionalArray(numbers);

// Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17->такого числа в массиве нет

int DataEntry(string message)											//Метод ввода данных
{
	Console.Write(message);
	return Convert.ToInt32(Console.ReadLine());
}

void FillTwoDimensionalArray(int[,] array)								//Метод заполнения массива
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			array[i, j] = new Random().Next(10, 100);
		}
	}
}

void PrintTwoDimensionalArray(int[,] array)								//Метод печати массива
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
System.Console.WriteLine("Задайте размер двумерного массива");
int rows = DataEntry("Введите количество строк ");
int columns = DataEntry("Введите количество столбцов ");
int[,] numbers = new int[rows, columns];
System.Console.WriteLine("Введите позицию элемента в массиве");
int numberRows = DataEntry("Введите номер строки ");
int numberColumns = DataEntry("Введите номер столбца ");
FillTwoDimensionalArray(numbers);
PrintTwoDimensionalArray(numbers);
if (numberRows <= rows & numberColumns <= columns)
{
	System.Console.WriteLine(numbers[numberRows - 1, numberColumns - 1]);
}
else System.Console.WriteLine("Указанной позиции нет в массиве");
// Задача 52.Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



int DataEntry(string message)                                           //Метод ввода данных
{
	Console.Write(message);
	return Convert.ToInt32(Console.ReadLine());
}

void FillTwoDimensionalArray(int[,] array)                              //Метод заполнения массива
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			array[i, j] = new Random().Next(10, 100);
		}
	}
}

void PrintTwoDimensionalArray(int[,] array)                             //Метод печати массива
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
double[] AverageFromColumns(int[,] array, double[] arr)					//Метод определения средего арифметического по столбцам массива
{
	for (int i = 0; i < array.GetLength(1); i++)
	{
		for (int j = 0; j < array.GetLength(0); j++)
		{
			arr[i] = arr[i] + (double) array[j,i];
		}
		arr[i] = arr[i] / array.GetLength(0);
	}
	return arr;

}

System.Console.WriteLine("Задайте размер двумерного массива");
int rows = DataEntry("Введите количество строк ");
int columns = DataEntry("Введите количество столбцов ");
int[,] numbers = new int[rows, columns];
double[] average = new double[columns];
FillTwoDimensionalArray(numbers);
PrintTwoDimensionalArray(numbers);
AverageFromColumns(numbers, average);
System.Console.WriteLine(string.Join(", ", average));
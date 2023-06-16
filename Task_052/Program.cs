//Created two-dimemsional array.
//Calculating the average in each column of the array.

using System;
using static System.Console;

Clear();

WriteLine("Please, enter number of rows");
int rows = int.Parse(ReadLine());
WriteLine("Please, enter number of columns");
int columns = int.Parse(ReadLine());
WriteLine();
WriteLine();
int[,] myArray = GetPrintArray(rows,columns);
WriteLine();
int[] averageEachColumns = AverageInEachColumn(myArray, rows);


int[,] GetPrintArray(int rows, int columns)
{
    int[,] array = new int [rows,columns];
    int count = 0;
    for (int i = 0; i < rows; i++, count++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(100);
            Write(array[i,j] + "\t");

        } WriteLine(count + ".");
    }
    return array;
}

int[] AverageInEachColumn(int[,] array, int rows)
{
    int[] averageInColumn = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            averageInColumn[j] += myArray[i,j];
        }
    }
    WriteLine("Average all cocumns: ");

    for (int i = 0; i < averageInColumn.Length; i++)
    {
        averageInColumn[i] /= rows;
        Write(averageInColumn[i] + "\t");
    }
    return averageInColumn;
}




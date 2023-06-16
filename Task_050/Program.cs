//Created two-dimensional array.
//Find in given array value with indicis m && n then user enter to consol.

/*using System;
using static System.Console;
Clear();
WriteLine("Please, enter number of rows");
int rows = int.Parse(ReadLine());
WriteLine("Please, enter number of columns");
int columns = int.Parse(ReadLine());
WriteLine("Please, enter index 'n' of rows");
int n = int.Parse(ReadLine());
WriteLine("Please, enter index 'm' of columns");
int m = int.Parse(ReadLine());

int[,] arr = GetArray(rows,columns);
WriteLine();
int IndexSearchIntArray(arr, n, m);

int[,] GetArray(int rows, int columns)
{
    int[,] array = new int [rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(1,78);
        }
    }
    return array;
}

int IndexSearchIntArray(int[,] array, int indexRow, int IndexColumn)
{
    if(indexRow < 0 || IndexColumn <0){throw new ArgumentException("Please, enter positive decimal numbers for search");}//throw - бросать/ ArgumentException - аргумент исключения.
    if(indexRow < array.GetLength(0) && IndexColumn < array.GetLength(1))
    {
        int FindValue = array[indexRow,IndexColumn];
        WriteLine("The value you are looking for: " + FindValue);
        return FindValue;
    }
    else{WriteLine("This value not find");}// return -1; - если значение не найдено, метод вернет -1
}*/





/*
using System;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Please enter number of rows:");
        int rows = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter number of columns:");
        int columns = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter index 'n' of s to search:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter index 'm' of column to search:");
        int m = int.Parse(Console.ReadLine());

        int[,] arr = GetArray(rows, columns);

        int value = IndexSearchIntArray(arr, n, m);

        if (value != -1)
        {
            Console.WriteLine("The value you are looking for: " + value);
        }
        else
        {
            Console.WriteLine("This value not found");
        }

    }

    static int[,] GetArray(int rows, int columns)
    {
        int[,] array = new int[rows, columns];
        Random rand = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = rand.Next(1, 78);
            }
        }
        return array;
    }

    static int IndexSearchIntArray(int[,] array, int indexRow, int indexColumn)
    {
        if (indexRow < 0 || indexColumn < 0)
        {
            throw new ArgumentException("Please enter positive decimal numbers for search");
        }
        if (indexRow < array.GetLength(0) && indexColumn < array.GetLength(1))
        {
            int findValue = array[indexRow, indexColumn];
            return findValue;
        }
        else
        {
            return -1;
        }
    }
}
*/

using System;
using static System.Console;

Clear();

WriteLine("Please, enter number of rows");
int rows = int.Parse(ReadLine());
WriteLine("Please, enter number of columns");
int columns = int.Parse(ReadLine());
WriteLine("Please, enter index of rows for searcing in array");
int n = int.Parse(ReadLine());
WriteLine("Please, enter index of columns for searcing in array");
int m = int.Parse(ReadLine());

int[,] myArray = GetArray(rows,columns);
WriteLine();
int FindNumber = SearchNumberInArray(myArray,n,m);

int[,] GetArray(int rows, int columns)
{
    int[,] array = new int [rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(100);
        }
    }
    return array;
}

int SearchNumberInArray(int[,] array, int row, int colum)
{
    if(row > 0 && row < array.GetLength(0))
    {
        if(colum > 0 && colum < array.GetLength(1))
        {
            WriteLine("Desired sign: " + array[row,colum]);
            return array[row,colum];
        }
        else WriteLine("This value not found");
        return -1;
    }
    else WriteLine("This value not found");
    return -1;
}
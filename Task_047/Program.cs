//Created two-dimensional array and fill him the random double value/
using System;
using static System.Console;
Clear();
int rows = int.Parse(ReadLine());
int columns = int.Parse(ReadLine());

double[,] myArray = GetPrintArray(rows,columns);

double[,] GetPrintArray(int a, int b)
{
    double[,] array = new double[a,b];
    for (int i = 0, count = 1; i < a; i++, count++)
    {
        for (int j = 0; j < b; j++)
        {
            Random random = new Random();
            array[i,j] = Math.Round(random.NextDouble() * (788.0 - 1.0) + 1.0, 2);
            Write(array[i,j] + "\t");
        }
        WriteLine(count + ".");

    }
    return array;
}
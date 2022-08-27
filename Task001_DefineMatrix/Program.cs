/*
Задача 1: Задайте двумерный массив размера m на n, каждый 
элемент в массиве находится по формуле: Amn = m+n. 
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/


int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}



int[,] FillMatrix(int rows, int columns)
{
    int[,] matrix=new int[rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j]=i+j;

        }
        
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        Console.Write($"{matrix[i, j]} [{i},{j}] ");

        }
        Console.WriteLine();
    }

}
int r=Prompt("enter matrix rows number: ");
int c=Prompt("enter matrix columns number: ");
int[,] matr=FillMatrix(r,c);
System.Console.WriteLine("Generated matrix is: ");
PrintMatrix(matr);

/*
Задача 3: Задайте двумерный массив. Найдите сумму элементов 
главной диагонали.
Например, задан массив:
1 4 7
5 9 2
8 4 2
Сумма элементов главной диагонали: 1+9+2 = 12
*/


int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}



int[,] FillMatrix(int rows, int columns, int range)
{
    int[,] matrix=new int[rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j]=new Random().Next(1,range+1);

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

int DiagonalSum(int[,] matrix)
{
    int sum=0;
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i==j) sum+=matrix[i, j];
            
        }
    }

    return sum;
}



int r=Prompt("enter matrix rows number: ");
int c=Prompt("enter matrix columns number: ");
int range=Prompt("enter random range: ");
int[,] matr=FillMatrix(r,c,range);
System.Console.WriteLine("Generated matrix: ");
PrintMatrix(matr);
System.Console.WriteLine($"Sum of matrix elements under main diagonal is: {DiagonalSum(matr)}");


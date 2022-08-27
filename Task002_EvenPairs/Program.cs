/*
Задача 2: Задайте двумерный массив. Найдите элементы, у которых 
обе позиции чётные, и замените эти элементы на их квадраты.
Например, изначально массив
 выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4

Новый массив будет выглядеть 
вот так:
1 4 7 2
5 81 2 9
8 4 2 4

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

void ReplaceEvens(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if((i+1)%2==0&&(j+1)%2==0) matrix[i, j]=matrix[i, j]*matrix[i, j];
            
        }
    }

    
}



int r=Prompt("enter matrix rows number: ");
int c=Prompt("enter matrix columns number: ");
int range=Prompt("enter random range: ");
int[,] matr=FillMatrix(r,c,range);
ReplaceEvens(matr);
System.Console.WriteLine("Generated matrix with replacements: ");
PrintMatrix(matr);

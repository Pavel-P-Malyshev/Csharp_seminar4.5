/*
Задача 4: Задайте двумерный массив. Введите элемент, и найдите 
первое его вхождение, выведите позиции по горизонтали и 
вертикали, или напишите, что такого элемента нет.
Например, такой массив:
1 4 7 2
5 9 2 3
8 4 2 4
Введенный элемент 2, результат: [1, 4]
Введенный элемент 6, результат: такого элемента нет.
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

(int,int) FindEntry(int[,] matrix, int entry)
{
    int rowPos=0;
    int colPos=0;
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i, j]==entry) 
            {
                rowPos=i;
                colPos=j;
                return (rowPos,colPos);
            }
            
        }
    }

    return (rowPos,colPos);
}



int r=Prompt("enter matrix rows number: ");
int c=Prompt("enter matrix columns number: ");
int range=Prompt("enter random range: ");
int val=Prompt("enter value to find: ");
int[,] matr=FillMatrix(r,c,range);
System.Console.WriteLine("Generated matrix: ");
PrintMatrix(matr);
(int i,int j)=FindEntry(matr,val);
if(i==0&&j==0)
{
   System.Console.WriteLine("Your value not found in generated matrix :(");
}
else
{
     System.Console.WriteLine($"Your value first position in generated matrix is [{i}][{j}]");

}




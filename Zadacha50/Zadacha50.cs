/*Задача 50. Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет.*/
System.Console.WriteLine("Enter number of rows: "); 
int M = Int32.Parse(System.Console.ReadLine());
System.Console.WriteLine("Enter number of columns: "); 
int N = Int32.Parse(System.Console.ReadLine());
System.Console.WriteLine("Enter maximal number: "); 
int MaxValue = Int32.Parse(System.Console.ReadLine());
System.Console.WriteLine("Enter minimal number: "); 
int MinValue = Int32.Parse(System.Console.ReadLine());
int [,] Matrix= Get2DArray(M,N,MaxValue,MinValue);
Print2DArray (Matrix); //вывод массива - для проверки, нужный ли элемент выдан
System.Console.WriteLine("Enter row number of element: "); 
int I = Int32.Parse(System.Console.ReadLine());
System.Console.WriteLine("Enter column number of element: "); 
int J = Int32.Parse(System.Console.ReadLine());
GetChosenElementFrom2DArray(I,J);

void GetChosenElementFrom2DArray (int I, int J)
{
    if (I<0|J<0) 
    {
        System.Console.WriteLine("Index in the array can not be negative");
    }
    else 
    {
      if (I<Matrix.GetLength(0)&&J<Matrix.GetLength(1))
      {
        for (int i=0; i<Matrix.GetLength(0); i++)
        {
          for (int j=0; j<Matrix.GetLength(1); j++)
          {
            if (i==I&&j==J)
            {
             System.Console.WriteLine(Matrix[i,j]);
            }
          }
        }
      }
      else
      {
        System.Console.WriteLine("No such element in the array");
      }
    }
}

int [,] Get2DArray (int M, int N, int MaxValue, int MinValue)
{
int[,] Array2D = new int [M,N];
for (int i=0; i<Array2D.GetLength(0); i++)
 {
    for (int j=0; j<Array2D.GetLength(1); j++)
    {
      Array2D[i,j]= new Random().Next(MinValue, MaxValue+1);
    }
 }
 return Array2D;
}

void Print2DArray (int [,] Matrix)
{
for (int i=0; i<Matrix.GetLength(0); i++)
 {
    for (int j=0; j<Matrix.GetLength(1); j++)
    {
      System.Console.Write($"{Matrix[i,j]} ");
    }
    System.Console.WriteLine();
 }
}
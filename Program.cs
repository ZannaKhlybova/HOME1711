//Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
double [,] ArrayGeneration (int lines,int columns,int smallvalue ,int higvalue)
{
double[,] array = new double [lines,columns];
    for(int i=0; i<lines ;i++)
        for(int j=0; j<columns;j++)
        array[i,j]= Math.Round(new Random().Next(smallvalue,higvalue+1) + new Random().NextDouble (),2);
return array;
}
void ArrayDispley(double[,]array)
{
    for(int i=0;i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
            Console.Write("{0}\t",array[i,j] );//"{0}\t"- чтобы ровнее было
        Console.WriteLine();
    }
}
/*Console.WriteLine("Задайте,пожалуйста,размерность двумерного массива.");
Console.Write("Количество строк ? ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов ? ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте,пожалуйста,диапазон чисел массива.");
Console.Write("Нижняя граница ? ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Верхняя граница ? ");
int b = Convert.ToInt32(Console.ReadLine());
ArrayDispley(ArrayGeneration (m,n,a,b));
*/
//Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.
void ElementSearch(double [,]array,int i, int j)
{
    if (i>array.GetLength(0)||j>array.GetLength(1))
        Console.WriteLine("Такого элемента нет."); 
    else
        Console.Write($"элемент массива({i},{j}) = {array[i,j]}");
}
Console.WriteLine("Задайте,пожалуйста,размерность двумерного массива.");
Console.Write("Количество строк ? ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов ? ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте,пожалуйста,диапазон чисел массива.");
Console.Write("Нижняя граница ? ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Верхняя граница ? ");
int b = Convert.ToInt32(Console.ReadLine());
double [,] myarray = (ArrayGeneration (m,n,a,b));
ArrayDispley(myarray);
Console.WriteLine("Задайте,пожалуйста,позицию искомого элемента.");
Console.Write("номер строки ? ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Номер столбца ? ");
int colum = Convert.ToInt32(Console.ReadLine());
ElementSearch(myarray,line,colum);

//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
/*int [,] ArrayGen (int lines,int columns,int smallvalue ,int higvalue)
{
int[,] array = new int [lines,columns];
    for(int i=0; i<lines ;i++)
        for(int j=0; j<columns;j++)
            array[i,j]= new Random().Next(smallvalue,higvalue+1) ;
return array;
}
void ArrayDisp(int[,]array)
{
    for(int i=0;i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
            Console.Write("{0}\t",array[i,j] );//"{0}\t"- чтобы ровнее было
        Console.WriteLine();
    }
}
void ArithMeanOverColumns(int [,]array)
{
  double[] sumcol = new double [array.GetLength(1)];
  for(int j=0;j<array.GetLength(1);j++)
    {
        double sum =0;
        for(int i=0;i<array.GetLength(0);i++)
        sum= sum + array[i,j];
    
        sumcol[j]= Math.Round(sum/array.GetLength(0),1); 
        Console.Write("{0}\t",sumcol[j] );
    }
}
Console.WriteLine("Задайте,пожалуйста,размерность массива");
Console.Write("Количество строк ? ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов ? ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте,пожалуйста,диапазон чисел массива");
Console.Write("Нижняя граница ? ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Верхняя граница ? ");
int b = Convert.ToInt32(Console.ReadLine());
int[,] myarray = ArrayGen(m,n,a,b);
ArrayDisp(myarray);
Console.WriteLine("среднее арифметическое элементов столбцов");
ArithMeanOverColumns(myarray);
*/


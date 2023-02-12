//Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Console.Write("Enter a number of rows: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Enter a number of columns: ");
// int columns = int.Parse(Console.ReadLine()!);
// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// SortArray(array);
// Console.WriteLine();
// PrintArray(array);



// //----------------------Method-----------------------------------
// void SortArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int t = 0; t > array.GetLength(1); t++)
//             {
//                 if (array[i, t] > array[i, j])
//                 {
//                     int temp = array[i, j];
//                     array[i, j] = array[i, j];
//                     array[i, t] = temp;
//                 }
//             }
//         }
//     }
// }
// int[,] GetArray(int m, int n, int minValue, int maxValue){ 
//     int[,] result = new int[m,n]; 
//     for(int i = 0; i < m; i++) 
//     { 
//         for(int j = 0; j < n; j++) 
//         { 
//             result[i,j] = new Random().Next(minValue, maxValue + 1); 
//         } 
//     } 
//     return result; 
// } 
// void PrintArray(int[,] array) 
// { 
//     for(int i = 0; i < array.GetLength(0); i++) 
//     { 
//         for(int j = 0; j < array.GetLength(1); j++) 
//         { 
//             Console.Write($"{array[i,j]} "); 
//         } 
//         Console.WriteLine(); 

//     } 

// // }
// //Задача 56: Задача 56: Задайте прямоугольный двумерный массив. 
// //Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Console.Write("Enter a number of rows: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Enter a number of columns: ");
// int columns = int.Parse(Console.ReadLine()!);
// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);

// Console.WriteLine($"Строка с наименьшей суммой - {GetRowNumber(array)}");


// //---------Methods------------------------
// int GetRowNumber(int[,] array)
//  {
//     int row = 0;
//     int minsum = 0;
//      for (int i = 1; i < array.GetLength(0); i++)
//      {
//         minsum = minsum + array[0,i];
//      }
//          int sum = 0;
//          for (int j = 0; j < array.GetLength(1); j++)
//          {
//         int i = 0;
//         sum = sum + array[i,j];
//          }
//                  if (minsum > sum)
//                  {
//                      minsum = sum;
//                      row = 1;
//                  }
// return row;
//              }
         
         
//          void PrintArray(int[,] array) 
//  { 
//      for(int i = 0; i < array.GetLength(0); i++) 
//     { 
//          for(int j = 0; j < array.GetLength(1); j++) 
//         { 
//              Console.Write($"{array[i,j]} "); 
//         } 
//          Console.WriteLine(); 
//     }
//  }
//   int[,] GetArray(int m, int n, int minValue, int maxValue){ 
//     int[,] result = new int[m,n]; 
//      for(int i = 0; i < m; i++) 
//      { 
//          for(int j = 0; j < n; j++) 
//          { 
//              result[i,j] = new Random().Next(minValue, maxValue + 1); 
//          } 
//      } 
//      return result; 
//  }    
 
   

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Console.WriteLine("Введите количество строк массива 1:");
// int rowsA = int. Parse(Console.ReadLine()!);
// Console.WriteLine("Введите количество столбцов массива 1:");
// int columnsA = int. Parse(Console.ReadLine()!);
// Console.WriteLine("Введите количество строк массива 2:");
// int rowsB = int. Parse(Console.ReadLine()!);
// Console.WriteLine("Введите количество столбцов массива 2:");
// int columnsB = int. Parse(Console.ReadLine()!);
// if(columnsA != rowsB)
// {
//   Console.WriteLine("Такие матрицы нельзя умножать");
//   return;

// }

// int[,] A = GetArray(rowsA, columnsA,0,10);
// int[,] B = GetArray(rowsB, columnsB,0,10);
// PrintArray(A);
// Console.WriteLine();
// PrintArray(B);
// Console.WriteLine();
// PrintArray(GetMultiplicationMatrix(A,B));












// // --------------Method--------------------
// int[,] GetMultiplicationMatrix(int[,] arrayA, int[,] arrayB)
// {
//     int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
//     for(int i = 0; i < arrayA.GetLength(0); i++)
//     {
//         for(int j = 0; j< arrayB.GetLength(1); j++)
//         {
//             for(int K = 0; K < arrayA.GetLength(0); K++)
//             {
//                 int k = 0;
//                 arrayA[i,j] += arrayA[i,k] * arrayB[K,j];
//             }
//         }
       
//     }
// }
// void PrintArray(int[,] array) 
//   { 
//       for(int i = 0; i < array.GetLength(0); i++) 
//      { 
//           for(int j = 0; j < array.GetLength(1); j++) 
//         { 
//               Console.Write($"{array[i,j]} "); 
//          } 
//                 Console.WriteLine(); 
//      }
//   }
//   int[,] GetArray(int m, int n, int minValue, int maxValue){ 
//      int[,] result = new int[m,n]; 
//       for(int i = 0; i < m; i++) 
//       { 
//                   for(int j = 0; j < n; j++) 
//           { 
//              result[i,j] = new Random().Next(minValue, maxValue + 1); 
//          } 
//       } 
//       return result; 
//   }    










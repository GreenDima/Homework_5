// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// int [] ThreeDigitArray(int size)
// {
//     int [] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(100,1000);
//     }
//     return array;
// }

// void PrintArray(int [] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }

// int EvenNumbers (int [] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] % 2 == 0) count++;
//     }
//     Console.WriteLine();
//     return count;
// }
// int size = 15;
// int [] array = ThreeDigitArray(size);
// PrintArray(array);
// Console.Write($"В данном массиве {EvenNumbers(array)} четных чисел(а)");



// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// int [] SomeArray(int size)
// {
//     int [] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(0,50);
//     }
//     return array;
// }

// void PrintArray(int [] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }

// int SummNumbers (int [] array)
// {
//     int summ = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(i % 2 != 0) summ += array[i];
//     }
//     Console.WriteLine();
//     return summ;
// }
// int size = 10;
// int [] array = SomeArray(size);
// PrintArray(array);
// Console.Write($"Сумма чисел в массиве на нечетных позициях {SummNumbers(array)}");



// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

// int [] DefiniteArray(int size)
// {
//     int [] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(0,150);
//     }
//     return array;
// }

// void PrintArray(int [] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }

// int QuantityNumbers (int [] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > 9 && array[i] < 100) count ++;
//     }
//     Console.WriteLine();
//     return count;
// }
// int size = 123;
// int [] array = DefiniteArray(size);
// PrintArray(array);
// Console.Write($"Количество элементов в пределах 10 - 99 (включительно) составляет {QuantityNumbers(array)}");



// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// int [] Array(int size)
// {
//     int [] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(0,100);
//     }
//     return array;
// }

// void PrintArray(int [] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }

// int MaxNumber (int [] array)
// {
//     int max = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > max)
//         max = array[i];
//     }
//     Console.WriteLine();
//     Console.WriteLine($"Максимальный элемент массива {max}");
//     return max;
// }

// int MinNumber (int [] array)
// {
//     int min = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] < min)
//         min = array[i];
//     }
//     Console.WriteLine($"Минимальный элемент массива {min}");
//     return min;
// }
// int size = 15;
// int [] array = Array(size);
// PrintArray(array);
// Console.Write($"Разница {MaxNumber(array) - MinNumber(array)}");



// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.

// int [] Array(int size)
// {
//     int [] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(0,100);
//     }
//     return array;
// }

// void PrintArray(int [] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }

// int NewArray (int [] array)
// {
//     int x = array.Length;
//     int [] newArray = new int[x / 2];
// if(x % 2 == 0)
// {
//     for (int i = 0; i < x / 2; i++)
//     {
//         array[i] = array[i] * array[x - i];
//     }
// }
// else
// {
//     for (int i = 0; i < x / 2 + 1; i++)
//     {
//         array[i] = array[i] * array[x - i];
//     }
//     return newArray;
// }
// }

// int size = 15;
// int [] array = Array(size);
// PrintArray(array);
// int [] newArray = NewArray(array);
// PrintArray(NewArray);
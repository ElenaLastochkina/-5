void Zadacha34()
{
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int size = 4;
int[] array = new int[size];
FillArray(array, 100, 999);
PrintArray(array);
CountEvenNumbers(array);
}

void CountEvenNumbers(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0) count++;
}
Console.WriteLine("Количество четных чисел в массиве равно:" + count); 
}

void FillArray(int[] array, int startNumber = 0, int finishNumber = 1)
{
  finishNumber++;  
  Random random = new Random();
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = random.Next(startNumber, finishNumber);
  }
}

void PrintArray(int[] array)
{
    Console.WriteLine("Вывод массива");
    for (int i = 0; i < array.Length; i++)
  {
    Console.Write(array[i] + "\t");
  }
  Console.WriteLine();
}
Zadacha34();

void Zadacha36()
{
//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
int size = 8;
int[] array = new int[size];
FillArray(array, 0, 10);
PrintArray(array);

int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 == 1) sum += array[i];
}
Console.WriteLine("Сумма элементов, стоящих на нечетных позициях, равнв:" + sum);
}
Zadacha36();

void Zadacha38()
{
//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
int size = 5;
Random random = new Random();
double[] array = new double[size];

for (int i = 0; i < array.Length; i++)
{
    array[i] = Math.Round(random.NextDouble() * 10 - 5, 2);
}

 Console.WriteLine("Вывод массива");
for (int i = 0; i < array.Length; i++)
  {
    Console.Write(array[i] + "\t");
  }
  Console.WriteLine();

  double max = array[0];
  double min = array[0];
  for (int i = 1; i < array.Length; i++)
  {
    if (array[i] > max) max = array[i];
    else if (array[i] < min) min = array[i];
  }
  Console.WriteLine();
  Console.WriteLine("Максимальное значение равно: " + max);
  Console.WriteLine("Минимальное значение равно: " + min);
  Console.WriteLine("Их разность равна: " + (max - min));

}
Zadacha38();
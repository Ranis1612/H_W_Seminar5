// Задача 34: Задайте массив заполненныйслучайными положительными трёхзначными
//  числами.Напишите программу, которая покажет количество чётных чисел в массиве.    
//  [345, 897, 568, 234] -> 2

Console.Clear();
int[] array = GetArray(10, 100 , 1000);
Console.WriteLine(String.Join(", ",array));
int positiveSum = 0;

foreach(int el in array)
{
  positiveSum += el % 2 == 0 ? 1 : 0;
}
Console.Write($"количество чётных чисел = {positiveSum}");

int[] GetArray(int size, int minValue, int maxValue)
{
  int[] res = new int[size];
  for(int i = 0; i < size; i++){
  res[i] = new Random().Next(minValue,maxValue + 1);
  }
  return res;
}


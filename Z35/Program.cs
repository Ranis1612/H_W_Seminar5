// Задача 35:Задайте одномерный массив из 123 случайных чисел [0: 1000].
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]
// .*Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*        
//  [5, 18, 123, 6, 2] -> 1  
// [1, 2, 3, 6, 2]-> 0   
// [10, 11, 12, 13, 14]-> 5

Console.Clear();


int[] array = GetArray(123, 0, 1001);
int Sum = 0;
Console.WriteLine(String.Join(", ",array));
// foreach(int el in array)
// {
//   Sum += el < 99 && 10 < el ? 1 : 0;
// } 

for(int i = 0; i < array.Length; i++)
{
  int el = array[i];
  if(10 <el && el < 99 ){
    Sum= Sum + 1;
  }
}


int[] GetArray(int size, int minValue, int maxValue)
{
  int [] res = new int [size];
  for(int i = 0; i < size; i++)
  {
    res[i] = new Random().Next(minValue, maxValue + 1);
  }
  return res;
}

Console.WriteLine($"Количество элементов массива от 10 до 99 равно {Sum}");
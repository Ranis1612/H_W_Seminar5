// Задача 36:Задайте одномерный массив,заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.   
//     [3, 7, 23, 12] -> 19    
//     [-4, -6, 89, 6] -> 0
Console.Clear();


int[] array = GetArray(10, 0, 100);
Console.WriteLine(String.Join(", ",array));

int Sum = 0;
foreach(int el in array)
{
Sum += el % 2 == 1 ? el : 0;
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
Console.WriteLine($"Сумма нечётных элементов равна {Sum}");
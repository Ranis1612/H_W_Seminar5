// Задача 37:Найдите произведение пар чисел в одномерном массиве.Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.        
//  [1 2 3 4 5] -> 5 8 3       
//  [6 7 3 6]-> 36 21

Console.Clear();
Console.Write("Введите элементы массива через пробел: "); // предложение к вводу данных 
string elements = Console.ReadLine()!;      // считывание данных 
int[] baseArray = GetArrayFromString(elements);     // назначение переменной через функцию

Console.WriteLine(String.Join(" ", ResultArray(baseArray)));    // вывод  результата произведения пар массива

int[] GetArrayFromString(string stringArray)     // функция назначения данных в массив
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

int[] ResultArray(int[] array)    // функция произведения пар чисел в массиве
{
    int size = (array.Length + 1)/ 2;   // определение длины массива и деление на 2 
//    if (array.Length % 2 == 1) size++;
    int[] result = new int[size];     // назначение длины массива
    for (int i = 0; i < array.Length / 2; i++)    // перебор элементов массива
    {
        
        result[i] = array[i] * array[array.Length - 1 - i];    
    }
    if (array.Length % 2 == 1) result[size-1] = array[array.Length / 2];
    return result;
}
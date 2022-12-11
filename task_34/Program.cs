// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] GetRandomArray(int size, int leftRange, int rightRange) 
{
    int[] array = new int[size];
    Random rand = new Random();

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}
 int evenNumbers(int[] array)
 {
    int res = 0;  
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2==0)
        {
        res++;
        }
    }
    return res;   
 }
const int SIZE = 6;
const int LEFTRANGE = 100;
const int RIGHTRANGE = 999;

int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"[{string.Join(", ", arr)}]");
int result = evenNumbers(arr);

Console.WriteLine($"количество чётных чисел в массиве {result}");

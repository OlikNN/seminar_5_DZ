// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
int notEvenNumbers(int[] array)
  {
     int sum = 0;  
     for (int i = 0; i < array.Length; i = i + 2)
    {
         sum = sum + array[i];
    }
     return sum;   
  }

const int SIZE = 6;
const int LEFTRANGE = 1;
const int RIGHTRANGE = 10;

int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"[{string.Join(", ", arr)}]");
int result = notEvenNumbers(arr);

Console.WriteLine($"сумму элементов {result}");
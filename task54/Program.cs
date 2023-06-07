// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[] nums = { 1, 4, 7, 2 };
 
int temp;
for (int i = 0; i < nums.Length - 1; i++)
{
    for (int j = i + 1; j < nums.Length; j++)
    {
        if (nums[i] < nums[j])
        {
            temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
 
Console.WriteLine("Вывод отсортированного массива");
for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine(nums[i]);
}
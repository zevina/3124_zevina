// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

// You may assume that each input would have exactly one solution, and you may not use the same element twice.
// You can return the answer in any order.

// 2 <= nums.length <= 104
// -109 <= nums[i] <= 109
// -109 <= target <= 109
// Only one valid answer exists.

// public class Solution {

// }

    void TwoSum(int[] nums, int target) 
    {
        for (int i = 0; i < nums.Length; i++)
        {
          for (int j = 0; j < nums.Length; j++)
          {
            if (i != j && nums[i] + nums[j] == target)
            {
            Console.WriteLine($"{i}, {j}");
            return;
            }
          }
        }
    }

    int[] GetArray(int size, int leftRange, int rightRange)
    {
      int[] arr = new int[size];
      Random rand = new Random();
      for(int i = 0; i < size; i++)
        {
        arr[i] = rand.Next(leftRange, rightRange + 1);
        }
      return arr;
    }

Console.WriteLine("Введите количество элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = GetArray(number, 0, 9);
Console.WriteLine("Рандомный массив чисел: " + string.Join(", ", array));

Console.WriteLine("Введите целевое число: ");
int target = Convert.ToInt32(Console.ReadLine());
TwoSum(array, target);
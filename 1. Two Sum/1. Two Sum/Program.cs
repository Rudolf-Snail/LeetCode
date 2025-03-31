// See https://aka.ms/new-console-template for more information
using _1._Two_Sum;

Solution solution = new Solution();

int[] nums = [1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1];
var target = 11;

var result = solution.TwoSum(nums, target);

foreach(int number in result)
{
    Console.Write($"{number} ");
}    

// See https://aka.ms/new-console-template for more information
using _1._Two_Sum;

Solution solution = new Solution();

int[] nums = [2, 5, 5, 11];
var target = 10;

var result = solution.TwoSum(nums, target);

foreach(int number in result)
{
    Console.Write($"{number} ");
}    

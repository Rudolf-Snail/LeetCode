// See https://aka.ms/new-console-template for more information
using _1._Two_Sum;

Solution solution = new Solution();

int[] nums = [3, 2, 3];
var target = 6;

var result = solution.TwoSum(nums, target);

foreach(int number in result)
{
    Console.Write($"{number} ");
}    

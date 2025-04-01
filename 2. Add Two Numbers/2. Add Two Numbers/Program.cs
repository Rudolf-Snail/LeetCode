// See https://aka.ms/new-console-template for more information
using _2._Add_Two_Numbers;

ListNode l1 = new(9,
                new(9,
                new(1)));
ListNode l2 = new(1);
Solution solution = new();

Console.WriteLine(solution.AddTwoNumbers(l1, l2));

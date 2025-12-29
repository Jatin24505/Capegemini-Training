// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         int[] arr = { 1, 2, 3, 2, 1, 4, 2 };

//         Dictionary<int, int> frequency = new Dictionary<int, int>();

//         foreach (int num in arr)
//         {
//             if (frequency.ContainsKey(num))
//             {
//                 frequency[num]++;
//             }
//             else
//             {
//                 frequency[num] = 1;
//             }
//         }

//         // Display result
//         foreach (var item in frequency)
//         {
//             Console.WriteLine($"Element {item.Key} occurs {item.Value} times");
//         }
//     }
// }

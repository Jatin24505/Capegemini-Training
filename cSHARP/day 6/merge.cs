// class Merge
// {
//     static void Main()
//     {
//         int[] arr1 = {10,5,8};
//         int[] arr2 = {3,6,9};
//         int[] merged = new int[arr1.Length + arr2.Length];
//         Array.Copy(arr1, 0, merged, 0, arr1.Length);
//         Array.Copy(arr2, 0, merged, arr1.Length, arr2.Length);
//         Array.Sort(merged);
//         foreach(var item in merged)
//         {
//             System.Console.Write("\n" + item);
//         }
//     }
// }
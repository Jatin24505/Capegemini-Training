// using System;

// class Program
// {
//     public class MJ
//     {
//         public int X = 10;   // make it public so we can access it outside

//         public void Incbyten(ref int a)
//         {
//             a = a + 10;
//         }
//     }

//     static void Main(string[] args)
//     {
//         MJ obj = new MJ();  // create an object

//         obj.Incbyten(ref obj.X);  // pass X by reference

//         Console.WriteLine("Value of X after incrementing by 10: " + obj.X);
//     }
// }
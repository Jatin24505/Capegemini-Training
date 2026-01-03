// using System;
// using Microsoft.VisualBasic;
// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("creating object ");
//         for (int i = 0; i < 5; i++){
//         MyClass obj = new MyClass();
       

//     }

//     Console.WriteLine("forcing garbage collection");
//     GC.Collect();
//     GC.WaitForPendingFinalizers();
  
//     Console.WriteLine("garbag e collection complete");
//     }
    
// }
// class MyClass
// {
//     ~MyClass()
//     {
//         Console.WriteLine("finalizer called object created");
//     }
// // }
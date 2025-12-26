// using System;

// interface INotifier
// {
//     void Log();
// }

// class ResourceHandler : IDisposable, INotifier
// {
//     // Explicit implementation of IDisposable
//     void IDisposable.Dispose()
//     {
//         Console.WriteLine("Resource disposed");
//     }

//     // Explicit implementation of INotifier
//     void INotifier.Log()
//     {
//         Console.WriteLine("Notification sent");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         // Accessing via interface reference - WORKS
//         IDisposable resource = new ResourceHandler();
//         resource.Dispose();

//         INotifier notifier = new ResourceHandler();
//         notifier.Log();

//         // Accessing via class object - ERROR (commented intentionally)
//         ResourceHandler obj = new ResourceHandler();

//         // obj.Dispose();  // ❌ Compile-time error
//         // obj.Log();      // ❌ Compile-time error
//     }
// }

// using System;
// class Program
// {
//     static void Main()
//     {
//         using (Handler h = new Handler())
//         {
//             Console.WriteLine("Inside using block");
//         }

//         Console.WriteLine("Outside using block");
//     }
// }
class Handler : IDisposable
{
    public void Dispose()
    {
        Console.WriteLine("RESOURCEHANDLER DISPOSED");
    }
    public Handler()
    {
        Console.WriteLine("resourcehandled ACQUIRED");
    }
}
// using System.Text;

// class String{
//     static void Main(){
//         string str="hello world";
//         Console.WriteLine(str.ToUpper());
//         Console.WriteLine(str.ToLower());
//         StringBuilder sb = new StringBuilder();
//         sb.Append("hello");
//         sb.Append(" world");
//         Console.WriteLine(sb.ToString());
//         sb.AppendLine("!");
//         Console.WriteLine(sb.ToString());
//         sb.Insert(5, ",");
//         Console.WriteLine(sb.ToString());
//         sb.Remove(5,1);
//         Console.WriteLine(sb.ToString());
//         sb.Replace("world", "C#");
//         Console.WriteLine(sb.ToString());
//         long mem = GC.GetTotalMemory(false);
//         Console.WriteLine("Memory used: " + mem + " bytes");
//         StringBuilder sb1 = new StringBuilder();
//         for(int i=0;i<1000;i++){
//             sb1.Append("Line " + i + "\n");
//         }
//         String  RESULT = sb1.ToString();
//         Console.WriteLine(RESULT);
//         StringBuilder sb2 = new StringBuilder("hello");
//          StringBuilder sb3 = new StringBuilder("hello");
//          Console.WriteLine(sb2.Equals(sb3));
//          StringBuilder sb4 = sb3;
//          Console.WriteLine(sb3.Equals(sb4));





//     }
// }
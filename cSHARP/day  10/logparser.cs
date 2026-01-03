// using System;
// using System.Text.RegularExpressions;
// namespace LogProcessing{
// public class LogParser
// {
//     private readonly string validLineRegexPattern=@"^\[(TRC|DBG|INF|WRN|ERR|FTL)\]";
//     private readonly string splitLineRegexPattern=@"<\*\*\*>|<====>|<\^\*>";
//     private readonly string quotedPasswordRegexPattern="\"password\"";
//     private readonly string endofLineRegexPattern=@"end-of-line\d+";
//     private readonly string weakPasswordRegexPattern=@"password[a-zA-Z0-9]+";
//     public bool IsValid(string text)
//     {
//         return Regex.IsMatch(text,validLineRegexPattern);
//     }
//     public string[] SplitLogLine(String text)
//     {
//         return Regex.Split(text,splitLineRegexPattern);
//     }
//     public int countquotespass(string lines)
//     {
//         return Regex.Matches(lines,quotedPasswordRegexPattern,RegexOptions.IgnoreCase).Count;
//     }
//     public string removelinetext(string line)
//     {
//         return Regex.Replace(line,endofLineRegexPattern,"").Trim();
//     }
// public string[] listlineswithapss(string[] lines)
//     {
//         string[] output=new string[lines.Length];
//         for (int i=0;i<lines.Length;i++)
//         {
//             Match match=Regex.Match(lines[i],weakPasswordRegexPattern,RegexOptions.IgnoreCase
//             );
//             if(match.Success)
//             output[i]=match.Value+": "+lines[i];
//             else
//             output[i]="----:"+lines[i];
//         }
//         return output;
//     }
// }
// }
// ﻿using System;
// using LogProcessing;
// class Program
// {
//     static void Main(String[] args)
//     {
//         LogParser parser=new LogParser();
//         Console.WriteLine(parser.IsValid("[INF] Application started"));
//         Console.WriteLine(parser.IsValid("INVALID LOG"));
//         string log="Part1<***>Part2<====>Part3<^*>Part4";
//         string[] parts=parser.SplitLogLine(log);
//         foreach(string p in parts)
//         Console.WriteLine(p);
//         string logs="\"password\" failed \"Password\" retry \"passWORD\"";
//         Console.WriteLine(parser.countquotespass(logs));
//         Console.WriteLine(parser.removelinetext("Processs done"));
//         string[] lines=
//         {
//             "User password123 failed login",
//             "System started successfully"
//         };
//         string[] result=parser.listlineswithapss(lines);
//         foreach(string r in result)
//         {
//             Console.WriteLine(r);
//         }
//     }
// }
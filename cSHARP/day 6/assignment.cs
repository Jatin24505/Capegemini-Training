using System;
using System.Text;

public class PasswordUtility
{
   public string CleanseAndInvert(string input)
    {
        if (string.IsNullOrEmpty(input) || input.Length < 6)
        {
            return string.Empty;
        } 
        foreach(char ch in input)
        {
            if (!char.IsLetter(ch))
            {
                return string.Empty;
            }
        }
        string lowerInput = input.ToLower();
        StringBuilder inverted = new StringBuilder();
        foreach(char ch in lowerInput)
        {
            if (ch %2 != 0)
            {
                inverted.Append(ch);
            }
            
        }
       char[] chars = inverted.ToString().ToCharArray();
         Array.Reverse(chars);
         for (int i = 0; i < chars.Length; i ++)
          if (chars.Length % 2 == 0)
       {
           chars[i] = char.ToUpper(chars[i]);
       }
            return new string (chars);
         
    }
}
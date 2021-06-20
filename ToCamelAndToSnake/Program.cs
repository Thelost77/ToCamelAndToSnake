using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToCamelAndToSnake
{
    
    class Program
    {
        private static string ToCamelCase(string givenSentence)
    {           
            var sb = new StringBuilder();
            char previousChar = char.MinValue;
            string charToAppend;

            foreach (char c in givenSentence)
            {
                if (sb.Length == 0 && char.IsUpper(c))
                {
                    charToAppend = c.ToString().ToLower();
                    sb.Append(charToAppend);
                    continue;
                }

                if (c == ' ' || c == '_')
                {
                    previousChar = c;
                    continue;
                }

                if (previousChar == ' ' || previousChar == '_' && !char.IsUpper(c))
                {
                    charToAppend = c.ToString().ToUpper();
                    sb.Append(charToAppend);
                    previousChar = c;
                    continue;
                }

                sb.Append(c);
                previousChar = c;
            }
            return sb.ToString();
        }
        private static string ToSnakeCase(string givenSentence)
        {
            var sb = new StringBuilder();
            char previousChar = char.MinValue;
            foreach (char c in givenSentence)
            {
                if (c == ' ' || c == '_')
                {
                    previousChar = c;
                    continue;
                }
                if (char.IsUpper(c) && sb.Length != 0 || previousChar == ' ' || previousChar == '_')
                        sb.Append("_");  
                sb.Append(c);
                previousChar = c;
            }
            return sb.ToString().ToLower();
        }
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            Console.WriteLine(ToCamelCase(a));
            Console.WriteLine(ToSnakeCase(a));
            Console.ReadLine();
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    public class StringUtility
    {

        public static string SummerizeText(string text, int maxLength = 20)
        {
            if (text.Length < maxLength)
            {
                return text;
            } else
            {
                string[] words = text.Split(' ');
                int totalChars = 0;
                List<string> summaryWords = new List<string>();

                foreach (string word in words)
                {
                    summaryWords.Add(word);
                    totalChars += word.Length + 1;

                    if (totalChars > maxLength)
                    {
                        break;
                    }
                }
                return String.Join(" ", summaryWords) + "...";
            }

        }
    }
}

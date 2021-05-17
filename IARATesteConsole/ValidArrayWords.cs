using System;
using System.Collections.Generic;
using System.Text;

namespace IARATesteConsole
{
    public class ValidArrayWords
    {
        public List<string> ContainsDuplicateValue(string[] values)
        {
            List<string> result = new List<string>(values);
            List<string> words = new List<string>();
            string word = string.Empty;

            foreach (string i in result)
            {
                string valueWord = i;
                word = string.Empty;
                string previousLetter = string.Empty;
                for (int x = 0; x < i.Length; x++)
                {
                    if (x > 0)
                        previousLetter = i.Substring(x - 1, 1).ToString();
                    if (!previousLetter.Equals(i.Substring(x, 1).ToString()))
                        word += i.Substring(x, 1).ToString();
                }

                words.Add(word);
            }
            return words;
        }
    }
}

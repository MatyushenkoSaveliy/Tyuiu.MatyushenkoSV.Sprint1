using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MatyushenkoSV.Sprint1.Task6.V10.Lib
{
    public class DataService : ISprint1Task6V10
    {
        public string DeleteMiddleLetter(string value)
        {
            string[] words = value.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];

                if (word.Length % 2 != 0)
                {
                    int centerIndex = word.Length / 2;

                    words[i] = word.Remove(centerIndex, 1);
                }
            }

            return string.Join(" ", words);
        }
    }
}

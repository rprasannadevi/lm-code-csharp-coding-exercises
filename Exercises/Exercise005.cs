using System;
namespace Exercises
{
    public class Exercise005
    {
        public bool IsPangram(string input)
        {
            var isPangram = false;

            if (!string.IsNullOrEmpty(input))
            {
                string toCheckPangram = "abcdefghijklmnopqrstuvwxyz";
                int count = 0;
                foreach(var c in toCheckPangram)
                {
                    foreach(var ch in input.ToLower())
                    {
                        //Console.WriteLine(ch);
                        //Console.WriteLine(c);
                        if (c == ch)
                        {
                            count++;
                            break;
                        }
                    }
                }
                if (count == 26)
                    isPangram =  true;
             
            }

            return isPangram;
        }
    }
}

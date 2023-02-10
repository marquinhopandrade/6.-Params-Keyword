using System;

namespace _6._Params_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParamsMethod("this", " is", " a ", " long", " string.", " I", " have", " no", " idea", " when", " it's", " going", " to", " end", "...");
        }
        public static void ParamsMethod(params string[] sentence)
        {
            for (int i = 0; i < sentence.Length; i++)
            {
                Console.Write(sentence[i] + " ");
            }
        }
    }
}

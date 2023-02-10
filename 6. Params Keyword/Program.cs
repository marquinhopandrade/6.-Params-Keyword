using System;

namespace _6._Params_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int price = 50;
            float pi = 3.14f;
            char at = '@';
            string book = "The Hobbit";
            ParamsMethod2(price, pi, at, book);
            ParamsMethod2("Hello", 5.3, '$');
            ParamsMethod("this", " is", " a ", " long", " string.", " I", " have", " no", " idea", " when", " it's", " going", " to", " end", "...");
        }
        public static void ParamsMethod(params string[] sentence)
        {
            for (int i = 0; i < sentence.Length; i++)
            {
                Console.Write(sentence[i] + " ");
            }
        }
        public static void ParamsMethod2(params object[] stuff)
        {
            //foreach loop to go through the array of objects
            foreach (object obj in stuff)
            {
                //print each object followed by a space
                Console.WriteLine(obj + " ");
            }
            Console.WriteLine();
        }
    }
}

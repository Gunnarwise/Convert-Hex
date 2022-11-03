using System;
using System.Text;

namespace ConvertHex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            converthex("hello world");
        }

        static void converthex(string input)
        {
            // converts string to list of bytes
            byte[] text = Encoding.Default.GetBytes(input);

            // converts the list to a string separated by - then lower cases all letters
            string hex = BitConverter.ToString(text).ToLower();
            

            // replaces the - with spaces
            hex = hex.Replace("-", " ");
            Console.WriteLine(hex);
        }
    }
}

using System;

namespace BSTAndHashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to HashTable Problem\n\n");

            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "Paranoids");
            hash.Add("1", "are");
            hash.Add("2", "not");
            hash.Add("3", "paranoid");
            hash.Add("4", "because");
            hash.Add("5", "they");
            hash.Add("6", "are");
            hash.Add("7", "paranoid");
            hash.Add("8", "but");
            hash.Add("9", "because");
            hash.Add("10", "they");
            hash.Add("11", "keep");
            hash.Add("12", "putting");
            hash.Add("13", "themselves");
            hash.Add("14", "deliberately");
            hash.Add("15", "into");
            hash.Add("16", "paranoid");
            hash.Add("17", "avoidable");
            hash.Add("18", "situations");

            string hashget = hash.Get("17");
            Console.WriteLine("18th index value is: " + hashget);
            Console.WriteLine("Removing \"avoidable\" word from above paragraph\n");

            string hash2 = hash.Get("17");
            Console.WriteLine("Removed value from Paragraph is: " + hash2);
            hash.Remove("17");

        }
    }
}

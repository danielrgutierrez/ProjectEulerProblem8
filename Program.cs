using System;
using System.IO;
using System.Collections.Generic;

namespace ProjectEulerProblem8
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("digits.txt"))
            {
                string line = "";
                string input = "";
                while ((line = sr.ReadLine()) != null)
                {
                    input += line;
                }
                Console.WriteLine(FindLargestConsecutiveProduct(input));
            }
        }

        static decimal FindLargestConsecutiveProduct(string input, int length = 13)
        {
            var products = new List<decimal>();
            for (int i = 0; i < input.Length; i++)
            {
                if (i + (length - 1) < input.Length)
                {
                    decimal product = 1m;
                    for (int j = 0; j < length; j++)
                    {
                        product *= Decimal.Parse(input.Substring((i + j), 1));
                    }
                    products.Add(product);
                }
            }
            products.Sort();
            return products[products.Count - 1];
        }
    }
}

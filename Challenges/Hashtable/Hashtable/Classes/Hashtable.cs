﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtable.Classes
{
    public class Hashtable
    {
        public Node[] HT { get; set; }

        public Hashtable()
        {
            
        }

        public void Add(string key, string value)
        {

        }

        public string Get(string key)
        {
            string value = "";
            return value;
        }

        public bool Contains(string key)
        {
            return false;
        }

        public static int Hash(string key)
        {
            int current = 0;
            for (int i = 0; i < key.Length; i++)
            {

                int charValue = Convert.ToInt32(key[i]);
                Console.Write($"{charValue} ");
                current += charValue;
                if (i == (key.Length - 1))
                {
                    Console.Write("= ");
                }
                else
                {
                    Console.Write("+ ");
                }
            }
            Console.WriteLine(current);

            int primeVal = current * 499;
            Console.WriteLine($"{current} * 499 = {primeVal}");

            int index = primeVal % 1024;
            Console.WriteLine($"{primeVal} / 1024 = {index}");

            Console.WriteLine($"Key gets placed in index of {index}");
            return index;
        }
    }
}

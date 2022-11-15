﻿namespace CollectionHierarchy.IO
{
    using System;

    using Contracts;
    public class ConsoleWriter : IWriter
    {
        public void Write(string text)
        {
            Console.Write(text);
        }

        public void Write(int number)
        {
            Console.Write(number);
        }

        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }

        public void WriteLine()
        {
            Console.WriteLine();
        }
    }
}
using Core.IO;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DirUtil.DeleteBinAndObjDir(System.AppContext.BaseDirectory);
            Console.WriteLine("Hello World!");
        }
    }
}

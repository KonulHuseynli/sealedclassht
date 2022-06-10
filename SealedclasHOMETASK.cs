using System;

namespace ConsoleApp77
{
    class Program
    {
        static void Main(string[] args)
        {

            Tasksealed(27);
            Tasksealed("Konul");
            Tasksealed('h');
            Tasksealed(89.1);
            
        }
        public static void Tasksealed(object item)
        {
            Console.WriteLine(item);
        }
    }
}

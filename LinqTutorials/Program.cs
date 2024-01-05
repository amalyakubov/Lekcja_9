using System;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = LinqTasks.Task7();

            Console.WriteLine(
                LinqTasks.Task13(
                    new[] { 0, 0, 0, 0, 1, 17, 0, 0, 2, 2, 2, 2, 3, 3, 1} // powinno zwrócić: 17
                )
            );
        }
    }
}
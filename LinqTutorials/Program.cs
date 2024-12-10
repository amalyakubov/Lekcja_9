using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Metadata;
using LinqTutorials.Models;

namespace LinqTutorials
{
    class Program
    {
        static int runLinqTasks()
        {
            var t = LinqTasks.Task7();
            // Console.WriteLine(
            //     LinqTasks.Task13(
            //         new[] { 0, 0, 0, 0, 1, 17, 0, 0, 2, 2, 2, 2, 3, 3, 1} // powinno zwrócić: 17
            //     )
            // );
            Console.WriteLine("Task 1:");
            LinqTasks.Task1().ToList().ForEach(Employee => Console.WriteLine(Employee));

            Console.WriteLine("\nTask 2:");
            LinqTasks.Task2().ToList().ForEach(Employee => Console.WriteLine(Employee));

            Console.WriteLine("\nTask 3:");
            Console.WriteLine(LinqTasks.Task3());

            Console.WriteLine("\nTask 4:");
            LinqTasks.Task4().ToList().ForEach(Employee => Console.WriteLine(Employee));

            Console.WriteLine("\nTask 5:");
            LinqTasks.Task5().ToList().ForEach(Employee => Console.WriteLine(Employee));

            Console.WriteLine("\nTask 6:");
            LinqTasks.Task6().ToList().ForEach(Employee => Console.WriteLine(Employee));

            Console.WriteLine("\nTask7:");
            LinqTasks.Task7().ToList().ForEach(Employee => Console.WriteLine(Employee));

            Console.WriteLine("\nTask8:");
            Console.WriteLine(LinqTasks.Task8());

            Console.WriteLine("\nTask9:");
            LinqTasks.Task9().ToList().ForEach(Employee => Console.WriteLine(Employee));

            Console.WriteLine("\nTask10:");
            LinqTasks.Task10().ToList().ForEach(Employee => Console.WriteLine(Employee));

            Console.WriteLine("\nTask11:");
            LinqTasks.Task11().ToList().ForEach(Element => Console.WriteLine(Element));

            Console.WriteLine("\nTask12:");
            LinqTasks.Task12().ToList().ForEach(Result => Console.WriteLine(Result));

            Console.WriteLine("\nTask13:");
            Console.WriteLine(LinqTasks.Task13(new[] { 3, 3, 5, 5, 7, 7, 8, 9, 9 }));

            Console.WriteLine("\nTask14:");
            var departments = LinqTasks.Task14();

            foreach (var dept in departments)
            {
                Console.WriteLine($"Department Number: {dept.Deptno}, Department Name: {dept.Dname}");
            }
            return 0;
        }
        static void Main(string[] args)
        {
            runLinqTasks();
        }
    }
}
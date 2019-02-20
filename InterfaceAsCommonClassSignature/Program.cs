using System;
using System.Collections.Generic;

namespace InterfaceAsCommonClassSignature
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IConsumer> pendingtask = PopulateTask();
            
            foreach (var task in pendingtask)
            {
                task.PerformAction("Taiser");
                Console.WriteLine(task.GetType());

                if (task is IConsumer con)
                {
                    Console.WriteLine($" {con.Name}");
                    cw
                }
            }
            Console.ReadKey();
        }



        private static List<IConsumer> PopulateTask()
        {
            List<IConsumer> pendingtask = new List<IConsumer>();

            Individual individual1 = new Individual() { Name = "Monayeem", Address = "Candgaon", BirthDate = new DateTime(1993, 12, 25) };
            Individual individual2 = new Individual() { Name = "Juwel", Address = "City Gate", BirthDate = new DateTime(1993, 2, 7) };
            Group group = new Group() { Name = "UCB", Address = "Chittagong" };

            pendingtask.Add(individual1); 
            pendingtask.Add(group);
            pendingtask.Add(individual2);

            return pendingtask;
        }

    }
}

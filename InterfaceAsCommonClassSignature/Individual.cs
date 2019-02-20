using System;

namespace InterfaceAsCommonClassSignature
{
    class Individual : IConsumer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }

        public void PerformAction(string user)
        {
            DateTime today = DateTime.Today;
            Console.ForegroundColor = ConsoleColor.Green;
            

            if (BirthDate.Day == today.Day && BirthDate.Month == today.Month)
            {
                Console.WriteLine($"Today is {Name}'s Birthday. Sending birthday wish by {user}");
            }
            else
            {
                var age = Convert.ToInt32((DateTime.Today - BirthDate).TotalDays / 365);
                Console.WriteLine($"{Name} is {age} years old");
            }
            
        }
        
    }
}

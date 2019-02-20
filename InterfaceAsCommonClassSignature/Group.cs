using System;

namespace InterfaceAsCommonClassSignature
{
    public class Group : IConsumer
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public void PerformAction(string user)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"Group Messsage Sent By {user}");
        }
    }
}

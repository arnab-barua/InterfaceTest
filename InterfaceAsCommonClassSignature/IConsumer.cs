using System;

namespace InterfaceAsCommonClassSignature
{
    public interface IConsumer
    {
        string Name { get; set; }

        string Address { get; set; }

        void PerformAction(string user);
    }
}

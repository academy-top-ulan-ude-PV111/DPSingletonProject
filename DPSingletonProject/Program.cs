using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPSingletonProject
{
    class Computer
    {
        public OS OperationSystem { get; set; }
        public void Start(string os)
        {
            OperationSystem = OS.GetInstance(os);
        }
    }

    class OS
    {
        private static OS instance;
        public string Name { private set; get; }

        private OS(string name)
        {
            this.Name = name;
        }

        public static OS GetInstance(string name)
        {
            if (instance == null)
                instance = new OS(name);
            return instance;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer comp = new Computer();
            comp.Start("Ubuntu");
            Console.WriteLine(comp.OperationSystem.Name);

            comp.OperationSystem = OS.GetInstance("Max OS");
            Console.WriteLine(comp.OperationSystem.Name);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
{
    class university
    {
        public string name; // set access specifiers
        public int id;
    }
    static void Main(string[] args)
    {
        university people = new university();
        people.name = "Donald";
        people.id = 123456789;
        for (int K = 1; K < 5; K++)
        {
            Console.WriteLine("{0} {1} {2}", people.name, people.id, K);
        }
    }
}
}

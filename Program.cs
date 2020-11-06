using queue_test.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue_test
{
    class Program
    {
        static void Main(string[] args)
        {
            var simplequeue = new simplequeue<int>();
            simplequeue.Enqueue(1);
            simplequeue.Enqueue(2);
            simplequeue.Enqueue(3);
            simplequeue.Enqueue(4);
            simplequeue.Enqueue(5);

            Console.WriteLine(simplequeue.Dequeue());
            Console.WriteLine(simplequeue.Peek());
            Console.WriteLine(simplequeue.Dequeue());

            Console.ReadLine();
        }
    }
}

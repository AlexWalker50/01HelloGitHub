using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_01HelloGitHub
{
    class ProgramHello01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nBegin ProgramHello01\n");

            QueueCaller();

            Console.WriteLine("\nEND");
            Console.ReadKey();
        }
        //
        public static void QueueCaller()
        {
            Console.WriteLine("\nQueueCaller()");
        }

    }
}

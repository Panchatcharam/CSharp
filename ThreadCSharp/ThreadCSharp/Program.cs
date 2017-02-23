using System;
using System.Threading;

namespace ThreadCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate worker thread object
            WorkerThread wThread = new WorkerThread();

            // Create thread, Here the ThreadStart is a delegate
            Thread thrdObj = new Thread(new ThreadStart(wThread.HandleInput));

            // Start the thread
            thrdObj.Start();

            Console.WriteLine("Wait for thread to become alive");

            // Wait until thread to become alive
            while (!thrdObj.IsAlive) ;

            Console.WriteLine("Thread is alive");

            // Wait for the thread to finish
            thrdObj.Join();

            Console.WriteLine("All is Well!, Press any key to Exit...");

            Console.ReadLine();
        }
    }
}

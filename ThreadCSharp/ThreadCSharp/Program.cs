using System;
using System.Threading.Tasks;

namespace ThreadCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate worker thread object
            WorkerThread wThread = new WorkerThread();

            // Create thread, Here the ThreadStart is a delegate
            Task thrdObj = Task.Factory.StartNew(() => wThread.HandleInput());

            Form1 form = new Form1();
            Task thrForm = Task.Factory.StartNew(() => form.HandleForm());

            Task.WaitAll(thrdObj,thrForm);

            Console.WriteLine("All is Well!, Press any key to Exit...");
            Console.ReadLine();
            if (form.IsAccessible)
            {
                form.Close();
            }
        }
    }
}

using System;
using System.IO;
using System.Threading;

namespace ThreadCSharp
{
    // A simple thread class for understaing the thread functionality.
    class WorkerThread
    {
        // Thread function to handle the input from console and write
        // to a file.
        public void HandleInput()
        {
            string inputString;

            // Use the using here to automatically call dispose
            // This create file if its not created already.
            using (StreamWriter writer = File.AppendText("log.txt"))
            {
                // Get the user input from the console
                while ((inputString = Console.ReadLine()) != "")
                {
                    // Please not here that the using variable
                    // can not be passed as `ref` or `out`. They 
                    // are being treated as a read only.
                    FormatAndWrite(ref inputString, writer);
                    
                    // Sleep for sometime for letting other threads if any to run.
                    Thread.Sleep(1);
                }
            }
        }

        private void FormatAndWrite(ref string message, TextWriter w)
        {
            w.WriteLine("{0} : {1}", DateTime.Now.ToString(),message);
        }
    }
}

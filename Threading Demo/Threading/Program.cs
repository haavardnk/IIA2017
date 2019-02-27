using System;
using System.Threading;

//Example in using sleep() and Threads in C#
namespace Threading
{
    /// <summary>
    /// Thread-class
    /// </summary>
    internal class ThreadClass
    {
        private int _loopCnt;
        private readonly int _loopDelay;
        private readonly Thread _cThread;
        private readonly Semaphore _sharedResource;
        private string _loopTime;
        public ThreadClass(string name, int delay, Semaphore resource)
        {
            _loopCnt = 0;
            _loopDelay = delay;
            _sharedResource = resource;
            _cThread = new Thread(new ThreadStart(this.Run)) {Name = name};
            _cThread.Start();
        }
        // The main function in the ThreadClass
        private void Run()
        {
            Console.WriteLine(" Starting " + _cThread.Name);
            do
            {
                _loopCnt++;
                Thread.Sleep(_loopDelay);
                // Wait for shared resource.
                _sharedResource.WaitOne();
            
                _loopTime = DateTime.Now.ToString("HH:mm:ss.fff");
                Console.WriteLine(" " + _cThread.Name + ": Time=" + _loopTime +
                                  ": Loop=" + _loopCnt + ": Student= Håvard Kråkenes, 220888, 2019");

                // Release resource.
                _sharedResource.Release();

            } while (_loopCnt < 5);
            // Ending of the thread
            Console.WriteLine(" Ending " + _cThread.Name);
        }
    }
    // The application
    internal class ThreadSys
    {
        /// <summary>
        /// Start of the main program
        /// </summary>
        
        // A semaphore to simulate a shared resource.
        private static Semaphore _resource;

        public static void Main()
        {
            // Initialize Semaphore resource
            _resource = new Semaphore(1,1);

            Console.WriteLine(" Start of main program ");
            // Making 5 threads ..
            var ct1 = new ThreadClass("Thread#1", 95, _resource);
            var ct2 = new ThreadClass("Thread#2", 131, _resource);
            var ct3 = new ThreadClass("Thread#3", 167, _resource);
            var ct4 = new ThreadClass("Thread#4", 203, _resource);
            var ct5 = new ThreadClass("Thread#5", 239, _resource);
            
            // Wait while the threads are running ...
            for (var cnt = 0; cnt < 30; cnt++)
            {
                // Wait for shared resource
                _resource.WaitOne();

                Console.Write(".");

                // Release resource and sleep
                _resource.Release();
                Thread.Sleep(100);
            }

            // End of main program
            Console.WriteLine(" End of main program ");
            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TasksAndParallelism
{
    /// <summary>
    /// http://www.codemag.com/Article/1211071
    /// </summary>
    public class Tasks
    {

        public static void Run()
        {
            //var task = SimpleTask();
            //Console.WriteLine("This is the main thread.");

            var task = SimpleTaskWithReturn(20);

            task.ContinueWith(taskInfo =>  {  Console.WriteLine("This is the Task Callback executing. The result from the task is {0}.", taskInfo.Result); });

            task.Start();

            Console.WriteLine("I should _not_ be blocked by the Task!");

            //What’s important to note here is that reference to the Result property will block the calling thread until the task completes. 
            //So in this case, the task starts the 3-second sleep cycle. 
            //On the main thread you would immediately see the message that follows the Start method, but the result message will not show until the task is complete. 
            //This means that you can execute whatever code you want between the time you start the task and the time you reference the Result property, 
            //but when you get to the latter you’ll be waiting for completion of the task and the thread will be blocked while you wait. 
            //This is important to remember when you’re calling thread happens to be the UI thread.
            Console.WriteLine("This is the main thread. {0}", task.Result);


            Console.WriteLine("I will be blocked by the Task and will show after the Result!");
        
        }


        private static Task SimpleTask()
        { 
            Task task = new Task(() =>
            {
                Console.WriteLine("Task on thread {0} started.",
                                    Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(5000);
            
                Console.WriteLine("Task on thread {0} finished.",
                                    Thread.CurrentThread.ManagedThreadId);
            });

            return task;
        }

        private static Task<int> SimpleTaskWithReturn(int value)
        {
            Task<int> task = new Task<int>(() =>
            {
                Console.WriteLine("Task on thread {0} started.",
                                    Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(3000);

                Console.WriteLine("Task on thread {0} finished.",
                                    Thread.CurrentThread.ManagedThreadId);

                return value + value;
            });

            return task;
        }

    }
}

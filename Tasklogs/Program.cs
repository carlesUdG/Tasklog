using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasklogs
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string> { "1", "2", "E", "4" };

            List<Tasklog> listTask = new List<Tasklog>();


            foreach (var item in list)
            {
                Tasklog t = new Tasklog();
                t.status = TaskStatus.pending;
                t.item = item;
                t.processItem();
                listTask.Add(t);
            }
            showList(listTask);
            Console.ReadLine();
        }

        public static void showList(List<Tasklog> tasklist)
        {
            foreach (var task in tasklist)
            {
                Console.Write("Task: " + task.item + " ==> ");

                switch (task.status)
                {
                    case TaskStatus.pending:
                        Console.WriteLine("PENDING");
                        break;
                    case TaskStatus.completed:
                        Console.WriteLine("COMPLETED");
                        break;
                    case TaskStatus.failed:
                        Console.WriteLine("FAILED");
                        break;
                    default:
                        Console.WriteLine("UNKNOWN");
                        break;
                }
            }
        }
    }
}

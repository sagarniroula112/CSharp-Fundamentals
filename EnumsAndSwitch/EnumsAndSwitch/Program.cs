using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAndSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Todo> tasks = new List<Todo>
            {
                new Todo { Description = "Task 1", EstimatedHours = 3, Status = Status.NotStarted },
                new Todo { Description = "Task 2", EstimatedHours = 5, Status = Status.InProgress },
                new Todo { Description = "Task 3", EstimatedHours = 2, Status = Status.Completed },
                new Todo { Description = "Task 4", EstimatedHours = 6, Status = Status.OnHold },
                new Todo { Description = "Task 5", EstimatedHours = 1, Status = Status.NotStarted },
                new Todo { Description = "Task 6", EstimatedHours = 4, Status = Status.Deleted },
                new Todo { Description = "Task 7", EstimatedHours = 7, Status = Status.InProgress },
                new Todo { Description = "Task 8", EstimatedHours = 3, Status = Status.Completed },
                new Todo { Description = "Task 9", EstimatedHours = 2, Status = Status.OnHold },
                new Todo { Description = "Task 10", EstimatedHours = 5, Status = Status.NotStarted },
                new Todo { Description = "Task 11", EstimatedHours = 4, Status = Status.Completed },
                new Todo { Description = "Task 12", EstimatedHours = 6, Status = Status.InProgress },
                new Todo { Description = "Task 13", EstimatedHours = 2, Status = Status.Deleted },
                new Todo { Description = "Task 14", EstimatedHours = 3, Status = Status.Completed }
            };

            PrintAssessment(tasks);
        }

        private static void PrintAssessment(List<Todo> todos)
        {
            foreach(var todo in todos)
            {
                switch (todo.Status)
                {
                    case Status.OnHold:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        break;

                    case Status.Deleted:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                }
                Console.WriteLine(todo.Description);
            }
        }
    }

    class Todo
    {
        public int EstimatedHours { get; set; }
        public Status Status { get; set; }
        public string Description { get; set; }
    }

    enum Status
    {
        NotStarted,
        InProgress,
        OnHold,
        Completed,
        Deleted
    }
}

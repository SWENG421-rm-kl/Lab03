using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lab_03;

/**
 * Worker.cs
 * Abstract class to add worker-task functionality to the Employee class
 */
public abstract class Worker : Employee
{
    List<Task> tasks = new List<Task>();
    protected Worker(string n, int a, string t, int s) : base(n, a, t, s)
    {
    }

    /**
     * addTask
     * Method to add task if the worker's task list is not already full
     */
    public void addTask(Task t)
    {
        if (this.tasks.Count == 2)
        {
            Console.WriteLine("\nUNABLE TO ADD TASK...");
            Console.WriteLine("Employee already has two tasks.\n");
        }
        else
        {
            this.tasks.Add(t);
        }
    }

    /**
     * transferTasks
     * Method to transfer tasks to another worker if their task list is not already full
     */
    public void transferTask(Worker w)
    {
        foreach (var t in this.tasks)
        {
            if (w.tasks.Count == 2)
            {
                Console.WriteLine("\nUNABLE TO ADD TASK...");
                Console.WriteLine("Employee already has two tasks.\n");
            }
            else
            {
                w.addTask(t);
                this.tasks.Remove(t);
            }
        }
    }

    /**
     * perform
     * Method to "perform task" by printing out a task completed message
     */
    public void perform()
    {
        foreach (var t in this.tasks)
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("TASK COMPLETE");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Task ID: " + t.getID());
            Console.WriteLine("Due Date: " + t.getDueDate());
            Console.WriteLine("Description: " + t.getDescription());
            Console.WriteLine("****************************************");
        }
    }
}
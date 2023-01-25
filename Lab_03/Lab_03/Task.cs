using System;
using System.Threading.Tasks;

namespace Lab_03
{
    /**
     * Task.cs
     * Class to hold the information for a task
     */
    public class Task
    {
        private String id, description;
        private int due_month, due_day, due_year;
        
        public Task() { }
        
        public Task(String i, String d, int month, int day, int year)
        {
            this.id = i;
            this.description = d;
            this.due_month = month;
            this.due_day = day;
            this.due_year = year;
        }

        public String getID()
        {
            return this.id;
        }

        public String getDescription()
        {
            return this.description;
        }

        public String getDueDate()
        {
            String due_date = this.due_month + "/" + this.due_day + "/" + this.due_year;
            return due_date;
        }

        public void setID(String i)
        {
            this.id = i;
        }
        
        public void setDescription(String d)
        {
            this.description = d;
        }
        
        public void setDueDate(int month, int day, int year)
        {
            this.due_month = month;
            this.due_day = day;
            this.due_year = year;
        }

    } // end class
}
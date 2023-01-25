using System;
using System.Runtime.CompilerServices;

namespace Lab_03
{
    /**
     * Employee.cs
     * Class to store and deliver base information of an employee
     */
    public class Employee
    {
        private String name, title;
        private int age, salary;

        public Employee(String n, int a, String t, int s)
        {
            this.name = n;
            this.age = a;
            this.title = t;
            this.salary = s;
        }

        public String getName()
        {
            return this.name;
        }
        public int getAge()
        {
            return this.age;
        }
        public String getTitle()
        {
            return this.title;
        }
        public int getSalary()
        {
            return this.salary;
        }
        
        public void setName(String n)
        {
            this.name = n;
        }
        public void setAge(int a)
        {
            this.age = a;
        }
        public void setTitle(String t)
        {
            this.title = t;
        }
        public void setSalary(int s)
        {
            this.salary = s;
        }

    } // end class
}
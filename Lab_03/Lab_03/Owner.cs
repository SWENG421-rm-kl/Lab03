using System;
using System.Collections.Generic;

namespace Lab_03
{
    /**
     * Owner.cs
     * Class to add owner functionality to the employee class
     */
    public class Owner : Employee, OwnerIF
    {
        public Owner(string n, int a, string t, int s) : base(n, a, t, s)
        {
        }

        /**
         * sendMSG
         * Method to print message to a list of employees to console
         */
        public void sendMSG(List<Employee> emps, string msg)
        {
            int count = 0;
            
            Console.Write("To: ");
            foreach (var emp in emps)
            {
                Console.Write(emp.getName());
                count++;
                
                if (count == emps.Count)
                    break;
                else
                    Console.Write(",");
            }
            Console.WriteLine("\n\t" + msg);
        }
    }
}
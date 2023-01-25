using System;
using System.Collections.Generic;

namespace Lab_03
{
    /**
     * Manager.cs
     * Class to add manager functionality to the worker class
     */
    public class Manager: Worker, OwnerIF
    {
        public Manager(string n, int a, string t, int s) : base(n, a, t, s)
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

        public void evaluate(Accountant emp, int rank)
        {
            emp.setEvaluationRank(rank);
        }
        
        public void evaluate(Blacksmith emp, int rank)
        {
            emp.setEvaluationRank(rank);
        }
    } // end class
}
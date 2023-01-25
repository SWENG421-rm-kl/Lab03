using System;
using System.Collections.Generic;
using System.Xml.Schema;

namespace Lab_03
{
    /**
     * Program.cs
     * Class to run a scenario implementing the classes for the blacksmith company
     */
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create company and employees
            Company XYZ = new Company();
            Owner craig = new Owner("Craig", 72, "Owner", 100000);
            Manager john = new Manager("John", 45, "Manager", 50000);
            Manager mary = new Manager("Mary", 43, "Manager", 50000);
            Accountant jane = new Accountant("Jane", 27, "Accountant", 45000);
            Accountant joe = new Accountant("Joe", 29, "Accountant", 45000);
            Blacksmith jack = new Blacksmith("Jack", 30, "Blacksmith", 35000);
            Blacksmith katie = new Blacksmith("Katie", 31, "Blacksmith", 35000);
            Blacksmith amy = new Blacksmith("Amy", 32, "Blacksmith", 35000);
            Blacksmith lin = new Blacksmith("Lin", 33, "Blacksmith", 35000);
            Blacksmith greg = new Blacksmith("Greg", 34, "Blacksmith", 35000);
            
            // add employees to company
            XYZ.setOwner(craig);
            XYZ.addEmployee(john);
            XYZ.addEmployee(mary);
            XYZ.addEmployee(jane);
            XYZ.addEmployee(joe);
            XYZ.addEmployee(jack);
            XYZ.addEmployee(katie);
            XYZ.addEmployee(lin);
            XYZ.addEmployee(amy);
            XYZ.addEmployee(greg);
            
            // create tasks and add to workers
            Task t1 = new Task("008574", "Forge 10 inch damascus steel blade", 10, 25, 2023);
            Task t2 = new Task("008575", "Perform maintenance on equipment", 10, 26, 2023);
            Task t3 = new Task("008576", "Perform inventory checks", 12, 1, 2023);
            greg.addTask(t1);
            amy.addTask(t2);
            lin.addTask(t3);

            // Test scenario
            List<Employee> j3 = new List<Employee>(){ john, jane, jack };
            craig.sendMSG(j3, "Good Job");
            amy.transferTask(greg);
            greg.perform();
            jane.updateSalaray(greg, greg.getSalary() + 1000);
            Console.WriteLine("Greg's new salary: " + greg.getSalary());
            lin.transferTask(jane);
            jane.perform();
            mary.evaluate(jack, 4);
            mary.evaluate(katie, 5);
            Console.WriteLine("Jack's rank: " + jack.getEvaluationRank());
            Console.WriteLine("Katie's rank: " + katie.getEvaluationRank());
            
            
            

        }
    }
}
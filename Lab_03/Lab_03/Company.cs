using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Lab_03
{
    /**
     * Company.cs
     * Class to store employees and owner of a company
     */
    public class Company
    {
        private List<Employee> employees = new List<Employee>();
        private Owner owner;

        public void setOwner(Owner o)
        {
            this.owner = o;
        }

        public void addEmployee(Employee e)
        {
            this.employees.Add(e);
        }

        public void addEmployee(List<Employee> es)
        {
            foreach (var t in es)
                this.employees.Add(t);
        }

        public Owner getOwner()
        {
            return this.owner;
        }

        public List<Employee> getEmployees()
        {
            return this.employees;
        }

    } // end class
}
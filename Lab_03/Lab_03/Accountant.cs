namespace Lab_03
{
    /**
     * Accountant.cs
     * Class to add accountant functionality to the worker class
     */
    public class Accountant : Worker
    {
        private int evaluation_rank;
        
        public Accountant(string n, int a, string t, int s) : base(n, a, t, s)
        {
        }

        public int getEvaluationRank()
        {
            return this.evaluation_rank;
        }

        public void setEvaluationRank(int rank)
        {
            this.evaluation_rank = rank;
        }

        public void updateSalaray(Employee emp, int sal)
        {
            emp.setSalary(sal);
        }
        
    }
}
namespace Lab_03
{
    /**
     * Blacksmith.cs
     * Class to add blacksmith functionality to the worker class
     */
    public class Blacksmith : Worker
    {
        private int evaluation_rank;
        
        public Blacksmith(string n, int a, string t, int s) : base(n, a, t, s)
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
        
    }
}
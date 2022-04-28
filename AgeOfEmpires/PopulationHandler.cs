namespace AgeOfEmpires0
{
    public class PopulationHandler
    {
        public PopulationHandler()
        {
            AllVillagers = 3;
            FreeVillagers = 3;
            MaxPopulation = 10;
            CurrentPopulation = AllVillagers;
        }

        public int AllVillagers { get; set; }
        public int FreeVillagers { get; set; }
        public int MaxPopulation { get; set; }
        public int CurrentPopulation { get; set; }
    }
}

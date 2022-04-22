using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfEmpires0
{
    public class PopulationHandler
    {
        public PopulationHandler()
        {
            AllVillagers = 3;
            AvailableVillagers = 3;
            MaxPopulation = 10;
            CurrentPopulation = AllVillagers;
        }
        public uint AllVillagers { get; set; }

        public uint AvailableVillagers { get; set; }

        public uint MaxPopulation { get; set; }
        public uint CurrentPopulation { get; set; }
    }
}

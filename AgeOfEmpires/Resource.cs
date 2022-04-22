using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfEmpires0
{
    public struct Resource
    {
        public Resource(uint initialAmount)
        {
            CollectorsAmount = 0;
            Amount = initialAmount;
        }
        public uint Amount { get; set; }
        public uint CollectorsAmount { get; set; }
        public void Collect() => Amount += CollectorsAmount;
        
    }
}

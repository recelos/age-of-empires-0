using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfEmpires0
{
    public class Resource
    {
        public Resource(int initialAmount)
        {
            CollectorsAmount = 0;
            Amount = initialAmount;
        }
        public int Amount { get; set; }
        public int CollectorsAmount { get; set; }
        public void Collect() => Amount += CollectorsAmount;
        public void IncreaseCollectors() => CollectorsAmount++;
        public void SubtractCollectors() => CollectorsAmount--;

    }
}

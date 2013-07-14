using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo.AnimalMaker.Core
{
    public interface IAnimal
    {
        string TypeName { get; set; }
        int NumberOfLegs { get; set; }
        decimal DailyFeedCost { get; set; }
    }
}

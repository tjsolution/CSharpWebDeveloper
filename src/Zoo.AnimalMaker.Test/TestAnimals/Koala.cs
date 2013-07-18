using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.AnimalMaker.Core;

namespace Zoo.AnimalMaker.Test.TestAnimals
{
    /// <summary>
    /// Animal type used for testing Animal Maker extension functionality.
    /// </summary>
    class Koala : IAnimal
    {
        public string TypeName
        {
            get { return GetType().Name; }
        }

        public int NumberOfLegs
        {
            get { return 4; }
        }

        public decimal DailyFeedCost
        {
            get { return 5; }
        }
    }
}

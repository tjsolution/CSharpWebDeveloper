
namespace Zoo.AnimalMaker.Core
{
    /// <summary>
    /// Man's best friend.
    /// </summary>
    public class Dog : IAnimal
    {
        public string TypeName { get { return GetType().Name; } }
        public int NumberOfLegs { get { return 4; } }

        public decimal DailyFeedCost { get { return 15; } }
    }
}

namespace Zoo.AnimalMaker.Core.Animals
{
    /// <summary>
    /// A furry animal that likes to sleep.
    /// </summary>
    public class Cat : IAnimal
    {
        public string TypeName { get { return GetType().Name; } }
        public int NumberOfLegs { get { return 4; } }

        public decimal DailyFeedCost { get { return 10; } }
    }
}

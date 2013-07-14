
namespace Zoo.AnimalMaker.Core
{
    public class Dog : IAnimal
    {
        public Dog()
        {
            TypeName = "Dog";
            DailyFeedCost = 15;
            NumberOfLegs = 4;
        }

        public string TypeName { get; set; }
        public int NumberOfLegs { get; set; }
        public decimal DailyFeedCost { get; set; }
    }
}

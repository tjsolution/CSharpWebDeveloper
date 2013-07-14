namespace Zoo.AnimalMaker.Core.Animals
{
    public class Cat : IAnimal
    {

        public Cat()
        {
            TypeName = "Cat";
            DailyFeedCost = 10;
        }

        public string TypeName { get; set; }
        public int NumberOfLegs { get; set; }
        public decimal DailyFeedCost { get; set; }
    }
}

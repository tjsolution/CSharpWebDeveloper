using NUnit.Framework;
using Zoo.AnimalMaker.Core;
using Zoo.AnimalMaker.Core.Animals;
using Zoo.AnimalMaker.Test.TestAnimals;

namespace Zoo.AnimalMaker.Test
{
    [TestFixture]
    public class MakerTest
    {
        [TestCase()]
        public void Maker_MakeADog_Success()
        {
            var dog = Maker.Make("Dog");
            Assert.IsNotNull(dog);
            Assert.IsInstanceOf(typeof(Dog), dog);
            Assert.AreEqual(typeof(Dog).Name, dog.TypeName);
            Assert.AreEqual(4, dog.NumberOfLegs);
            Assert.AreEqual(15, dog.DailyFeedCost);
        }

        [TestCase()]
        public void Maker_MakeACat_Success()
        {
            var cat = Maker.Make("Cat");
            Assert.IsNotNull(cat);
            Assert.IsInstanceOf(typeof(Cat), cat);
            Assert.AreEqual(typeof(Cat).Name, cat.TypeName);
            Assert.AreEqual(4, cat.NumberOfLegs);
            Assert.AreEqual(10, cat.DailyFeedCost);
        }

        [TestCase()]
        [ExpectedException(typeof(AnimalMakerException))]
        public void Maker_MakeACat_NullValue()
        {
            var cat = Maker.Make(null);
        }

        [TestCase()]
        [ExpectedException(typeof(AnimalMakerException))]
        public void Maker_MakeNoneExistantAnimal()
        {
            var cat = Maker.Make("Wallaby");
        }

        [TestCase()]
        public void Maker_TypeExtension_Koala()
        {
            Maker.Register<Koala>();
            var koala = Maker.Make(typeof(Koala).Name);
            Assert.IsNotNull(koala);
            Assert.IsInstanceOf(typeof(Koala), koala);
            Assert.AreEqual(4, koala.NumberOfLegs);
            Assert.AreEqual(5, koala.DailyFeedCost);
        }
    }
}

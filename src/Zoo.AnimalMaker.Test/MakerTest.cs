using NUnit.Framework;
using Zoo.AnimalMaker.Core;
using Zoo.AnimalMaker.Core.Animals;

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
        }

        [TestCase()]
        public void Maker_MakeACat_Success()
        {
            var cat = Maker.Make("Cat");
            Assert.IsNotNull(cat);
            Assert.IsInstanceOf(typeof(Cat),cat);
        }
    }
}

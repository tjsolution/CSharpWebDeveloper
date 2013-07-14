using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zoo.AnimalMaker.Core.Animals;

namespace Zoo.AnimalMaker.Core
{
    public class Maker : IMaker
    {
        /// <summary>
        /// Decides which animal to make.
        /// </summary>
        public static IAnimal Make(string name)
        {
            switch (name)
            {
                case "Dog":
                    return new Dog();
                case "Cat":
                    return new Cat();
                default:
                    return null;
            }
        }
    }
}

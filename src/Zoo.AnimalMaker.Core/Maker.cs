using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Zoo.AnimalMaker.Core.Animals;

namespace Zoo.AnimalMaker.Core
{
    /// <summary>
    /// Factory for creating animal objects based on type names.
    /// </summary>
    public class Maker
    {

        /// <summary>
        /// Hash of animal types.
        /// Key: type name of type as a string.
        /// Value: Type of animal.
        /// </summary>
        private static readonly Dictionary<string, Type> AnimalTypeMap = 
            new Dictionary<string, Type>();

        static Maker()
        {
            AutoRegisterDefaultAnimals();
        }

        /// <summary>
        /// Creates an animal based on the given animal type name.
        /// </summary>
        /// <param name="typeName">Name of the type of animal to create.</param>
        /// <returns></returns>
        /// <exception cref="AnimalMakerException">Please specify the type of animal to create.</exception>
        public static IAnimal Make(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                throw new AnimalMakerException("Please specify the type of animal to create.");
            }

            Type animalType = null;
            if (AnimalTypeMap.TryGetValue(typeName, out animalType))
            {
                return (IAnimal)Activator.CreateInstance(animalType);
            }

            throw AnimalMakerException.Create("No type registered for {0}.", typeName);
        }

        /// <summary>
        /// Register a new animal type with the factory.
        /// </summary>
        /// <typeparam name="TAnimal">The type of the animal to register.</typeparam>
        /// <exception cref="AnimalMakerException">Throws an exception if invalid animal type is specified.</exception>
        public static void Register<TAnimal>() 
            where TAnimal : IAnimal, new()
        {
            Register(typeof(TAnimal));
        }

        private static void Register(Type type)
        {
            if (type.IsInterface || type.IsAbstract)
            {
                throw AnimalMakerException.Create("{0} is not a concrete type.", type.Name);
            }

            AnimalTypeMap.Add(type.Name, type);
        }

        /// <summary>
        /// Automatically registers the animals in the library.
        /// Reflection is slow so Animals can be registered manually in the constructor if necessary.
        /// </summary>
        private static void AutoRegisterDefaultAnimals()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var animalTypes = assembly.GetTypes()
                .Where(IsAnimal)
                .ToArray();
            Array.ForEach(animalTypes, Register);
        }

        /// <summary>
        /// Determines whether the specified type is an animal.
        /// </summary>
        /// <param name="type">The type to test.</param>
        /// <returns>
        ///   <c>true</c> if the specified type is an animal; otherwise, <c>false</c>.
        /// </returns>
        private static bool IsAnimal(Type type)
        {
            return typeof(IAnimal).IsAssignableFrom(type) 
                && 
                !type.IsInterface;
        }
    }
}

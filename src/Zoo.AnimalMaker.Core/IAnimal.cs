using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo.AnimalMaker.Core
{
    /// <summary>
    /// Interface for an Animal created by the Animal Maker.
    /// </summary>
    public interface IAnimal
    {
        /// <summary>
        /// Gets the name of the Animal Type.
        /// </summary>
        /// <value>
        /// The name of the Animal Type.
        /// </value>
        string TypeName { get; }

        /// <summary>
        /// Gets the number of legs for the Animal.
        /// </summary>
        /// <value>
        /// The number of legs for the Animal.
        /// </value>
        int NumberOfLegs { get; }

        /// <summary>
        /// Gets the daily feed cost for the Animal.
        /// </summary>
        /// <value>
        /// The daily feed cost for the Animal.
        /// </value>
        decimal DailyFeedCost { get; }
    }
}

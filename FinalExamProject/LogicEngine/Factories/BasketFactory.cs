// <copyright file="BasketFactory.cs" company="Charles Norden -- 011606177">
// Copyright (c) Charles Norden -- 011606177. All rights reserved.
// </copyright>

namespace LogicEngine.Factories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using LogicEngine.AbstractBaseClass;
    using LogicEngine.RunTimeClass.FoodItems;

    /// <summary>
    /// Basket Factory. Containing factory methods for creating Type-specific Baskets.
    /// </summary>
    /// <typeparam name="T">the generic type.</typeparam>
    internal static class BasketFactory
    {
        /// <summary>
        /// Creates a new Basket of Veggie.
        /// </summary>
        /// <returns>the new Veggie Basket.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1611:Element parameters should be documented", Justification = "throw away parameter.")]
        internal static Basket<Veggie> CreateBasket(Veggie obj) => new Basket<Veggie>();

        /// <summary>
        /// Creates a new Basket of Fruit.
        /// </summary>
        /// <returns>the new Fruit Basket.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1611:Element parameters should be documented", Justification = "throw away parameter.")]
        internal static Basket<Fruit> CreateBasket(Fruit obj) => new Basket<Fruit>();
    }
}

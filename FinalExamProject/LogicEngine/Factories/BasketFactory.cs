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
    internal static class BasketFactory
    {
        /// <summary>
        /// Creates a new Basket of generic type T.
        /// </summary>
        /// <typeparam name="T">a generic type.</typeparam>
        /// <returns>A new basket of generic type T.</returns>
        internal static Basket<T> CreateBasket<T>()
            where T : Food => new Basket<T>();
    }
}

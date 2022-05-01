// <copyright file="Veggie.cs" company="Charles Norden -- 011606177">
// Copyright (c) Charles Norden -- 011606177. All rights reserved.
// </copyright>

namespace LogicEngine.RunTimeClass.FoodItems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using LogicEngine.AbstractBaseClass;

    /// <summary>
    /// The class for Veggie item.
    /// </summary>
    internal class Veggie : Food
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Veggie"/> class.
        /// </summary>
        public Veggie()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Veggie"/> class.
        /// </summary>
        /// <param name="name">the name of the veggie.</param>
        public Veggie(string name)
        {
            this.Name = name;
        }
    }
}

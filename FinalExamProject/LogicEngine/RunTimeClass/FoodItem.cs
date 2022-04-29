// <copyright file="FoodItem.cs" company="Charles Norden -- 011606177">
// Copyright (c) Charles Norden -- 011606177. All rights reserved.
// </copyright>

namespace LogicEngine.RunTimeClass
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
            : base()
        {
        }
    }

    /// <summary>
    /// The class for Fruit item.
    /// </summary>
    internal class Fruit : Food
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Fruit"/> class.
        /// </summary>
        public Fruit()
            : base()
        {
        }
    }
}

// <copyright file="Food.cs" company="Charles Norden -- 011606177">
// Copyright (c) Charles Norden -- 011606177. All rights reserved.
// </copyright>

namespace LogicEngine.AbstractBaseClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using LogicEngine.AbstractBaseClass;
    using LogicEngine.ItemAttributes;

    /// <summary>
    /// The abstract class for food item.
    /// </summary>
    internal abstract class Food : Item
    {
        private ItemTaste taste;

        /// <summary>
        /// Initializes a new instance of the <see cref="Food"/> class.
        /// </summary>
        public Food()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Food"/> class.
        /// </summary>
        /// <param name="name">the name of the food item.</param>
        public Food(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Gets or sets the Taste of the Item.
        /// </summary>
        public string Taste
        {
            get => ((ItemTaste)this.taste).ToString();
            set => this.taste = (ItemTaste)Enum.Parse(typeof(ItemTaste), value, true);
        }

        /// <summary>
        /// Gets or sets the taste as enum.
        /// </summary>
        public ItemTaste EnumTaste
        {
            get => this.taste;
            set => this.taste = value;
        }
    }
}

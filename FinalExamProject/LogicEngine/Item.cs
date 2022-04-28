// <copyright file="Item.cs" company="Charles Norden -- 011606177">
// Copyright (c) Charles Norden -- 011606177. All rights reserved.
// </copyright>

namespace LogicEngine
{
    /// <summary>
    /// Item Color.
    /// </summary>
    internal enum ItColor
    {
        BLUE,
        GREEN,
        YELLOW,
        ORANGE,
        RED,
    }

    /// <summary>
    /// Item Shape.
    /// </summary>
    internal enum ItShape
    {
        SQUARE,
        CIRCLE,
        OVAL,
    }

    /// <summary>
    /// Item Texture.
    /// </summary>
    internal enum ItTexture
    {
        FIRM,
        SOFT,
        CRUNCHY,
        CHEWY,
    }

    /// <summary>
    /// Item Size.
    /// </summary>
    internal enum ItSize
    {
        TINY,
        SMALL,
        MEDIUM,
        LARGE,
        HUGE,
    }

    /// <summary>
    /// FoodItem Taste.
    /// </summary>
    internal enum ItTaste
    {
        SWEET,
        SOUR,
        BITTER,
    }

    /// <summary>
    /// The abstract class for item, which can be placed in a Basket.
    /// </summary>
    public abstract class Item
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Item"/> class.
        /// </summary>
        public Item()
        {
        }

        /// <summary>
        /// Gets or sets the Name of the Item.
        /// </summary>
        public int Name { get; set; }

        /// <summary>
        /// Gets or sets the Color of the Item.
        /// </summary>
        public int Color { get; set; }

        /// <summary>
        /// Gets or sets the Shape of the Item.
        /// </summary>
        public int Shape { get; set; }

        /// <summary>
        /// Gets or sets the Texture of the Item.
        /// </summary>
        public int Texture { get; set; }

        /// <summary>
        /// Gets or sets the Size of the Item.
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// Gets or sets the Taste of the Item.
        /// </summary>
        public int Taste { get; set; }
    }

}
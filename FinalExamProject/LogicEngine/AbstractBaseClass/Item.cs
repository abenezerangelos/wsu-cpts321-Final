// <copyright file="Item.cs" company="Charles Norden -- 011606177">
// Copyright (c) Charles Norden -- 011606177. All rights reserved.
// </copyright>

namespace LogicEngine.AbstractBaseClass
{
    using LogicEngine.ItemAttributes;

    /// <summary>
    /// The abstract class for item, which can be placed in a Basket.
    /// </summary>
    internal abstract class Item
    {
        private ItemColor color;
        private ItemShape shape;
        private ItemTexture texture;
        private ItemSize size;

        /// <summary>
        /// Initializes a new instance of the <see cref="Item"/> class.
        /// </summary>
        public Item()
        {
        }

        /// <summary>
        /// Gets or sets the Name of the Item.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the Color of the Item.
        /// </summary>
        public string Color
        {
            get => ((ItemColor)this.color).ToString();
            set => this.color = (ItemColor)Enum.Parse(typeof(ItemColor), value, true);
        }

        /// <summary>
        /// Gets or sets the Shape of the Item.
        /// </summary>
        public string Shape
        {
            get => ((ItemShape)this.shape).ToString();
            set => this.shape = (ItemShape)Enum.Parse(typeof(ItemShape), value, true);
        }

        /// <summary>
        /// Gets or sets the Texture of the Item.
        /// </summary>
        public string Texture
        {
            get => ((ItemTexture)this.texture).ToString();
            set => this.texture = (ItemTexture)Enum.Parse(typeof(ItemTexture), value, true);
        }

        /// <summary>
        /// Gets or sets the Size of the Item.
        /// </summary>
        public string Size
        {
            get => ((ItemSize)this.size).ToString();
            set => this.size = (ItemSize)Enum.Parse(typeof(ItemSize), value, true);
        }
    }
}

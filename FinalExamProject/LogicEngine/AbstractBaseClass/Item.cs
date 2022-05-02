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
        private ItemState state;

        /// <summary>
        /// Initializes a new instance of the <see cref="Item"/> class.
        /// </summary>
        public Item()
        {
            this.state = ItemState.ALIVE;
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

        /// <summary>
        /// Gets or sets the existenial state of the Item.
        /// </summary>
        public string State
        {
            get => ((ItemState)this.state).ToString();
            set => this.state = (ItemState)Enum.Parse(typeof(ItemState), value, true);
        }

        /// <summary>
        /// Gets or sets the color as enum.
        /// </summary>
        public ItemColor EnumColor
        {
            get => this.color;
            set => this.color = value;
        }

        /// <summary>
        /// Gets or sets the shape as enum.
        /// </summary>
        public ItemShape EnumShape
        {
            get => this.shape;
            set => this.shape = value;
        }

        /// <summary>
        /// Gets or sets the texture as enum.
        /// </summary>
        public ItemTexture EnumTexture
        {
            get => this.texture;
            set => this.texture = value;
        }

        /// <summary>
        /// Gets or sets the size as enum.
        /// </summary>
        public ItemSize EnumSize
        {
            get => this.size;
            set => this.size = value;
        }

        /// <summary>
        /// Gets or sets the state as enum.
        /// </summary>
        public ItemState EnumState
        {
            get => this.state;
            set => this.state = value;
        }
    }
}

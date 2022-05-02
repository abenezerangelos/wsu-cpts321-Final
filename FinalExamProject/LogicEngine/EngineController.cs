// <copyright file="EngineController.cs" company="Charles Norden -- 011606177">
// Copyright (c) Charles Norden -- 011606177. All rights reserved.
// </copyright>

namespace LogicEngine
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using LogicEngine.Factories;
    using LogicEngine.RunTimeClass;
    using LogicEngine.RunTimeClass.FoodItems;

    /// <summary>
    /// The manger for baskets and items.
    /// </summary>
    internal class EngineController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EngineController"/> class.
        /// </summary>
        public EngineController()
        {
            this.ItemContainer = new ArrayList();
            this.BasketContainer = new ArrayList();
        }

        /// <summary>
        /// Gets or sets the free items created by the users.
        /// </summary>
        internal ArrayList ItemContainer
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the list of existing baskets.
        /// </summary>
        internal ArrayList BasketContainer
        {
            get;
            set;
        }

        /// <summary>
        /// Creates a new food item.
        /// </summary>
        /// <param name="typeName">the type of the food item.</param>
        internal void CreateFoodItem(string typeName)
        {
            this.ItemContainer.Add(ItemFactory.CreateItem(typeName));
        }

        /// <summary>
        /// Changes an existing Food Item.
        /// </summary>
        /// <param name="itemIndex">item index.</param>
        /// <param name="attribute">item attribute.</param>
        /// <param name="value">new attribute value.</param>
        internal void ChangeFoodItem(int itemIndex, string attribute, string value)
        {
        }

        /// <summary>
        /// Creates a new basket.
        /// </summary>
        /// <param name="typeName">the type, either veggie or fruit.</param>
        internal void CreateBasket(string typeName)
        {
            switch (typeName)
            {
                case "Veggie":
                    this.BasketContainer.Add(BasketFactory.CreateBasket(new Veggie()));
                    break;

                case "Fruit":
                    this.BasketContainer.Add(BasketFactory.CreateBasket(new Fruit()));
                    break;

                default:
                    throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Adds a food item to an existing basket.
        /// </summary>
        /// <param name="itemIndex">the index of the free food item.</param>
        /// <param name="basketIndex">the index of the basket.</param>
        internal void AddFoodItemToBasket(int itemIndex, int basketIndex)
        {
            var item = this.ItemContainer[itemIndex];

            var basket = this.BasketContainer[basketIndex];
        }

        /// <summary>
        /// removes a veggie item from a basket.
        /// </summary>
        /// <param name="itemIndex">the item index.</param>
        /// <param name="basket">the basket.</param>
        internal void RemoveFoodItemFromBasket_Veggie(int itemIndex, Basket<Veggie> basket)
        {
            basket.RemoveAt(itemIndex);
        }

        /// <summary>
        /// removes a fruit item from a basket.
        /// </summary>
        /// <param name="itemIndex">the item index.</param>
        /// <param name="basket">the basket.</param>
        internal void RemoveFoodItemFromBasket_Fruit(int itemIndex, Basket<Fruit> basket)
        {
            basket.RemoveAt(itemIndex);
        }

        /// <summary>
        /// Delete a free Food Item.
        /// </summary>
        /// <param name="itemIndex">the index of the food item.</param>
        internal void DeleteAFoodItem(int itemIndex)
        {
            if (this.ItemContainer is null || this.ItemContainer.Count == 0)
            {
                return;
            }

            this.ItemContainer.RemoveAt(itemIndex);
        }

        /// <summary>
        /// Deletes a basket.
        /// </summary>
        /// <param name="basketIndex">the index of the basket.</param>
        internal void DeleteABasket(int basketIndex)
        {
            if (this.BasketContainer is null || this.BasketContainer.Count == 0)
            {
                return;
            }

            this.BasketContainer.RemoveAt(basketIndex);
        }
    }
}

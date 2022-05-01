// <copyright file="ItemFactory.cs" company="Charles Norden -- 011606177">
// Copyright (c) Charles Norden -- 011606177. All rights reserved.
// </copyright>

namespace LogicEngine.Factories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;
    using LogicEngine.RunTimeClass.FoodItems;

    /// <summary>
    /// The generic factory class for creating new Item.
    /// </summary>
    internal static class ItemFactory
    {
        /// <summary>
        /// Static method for creating a new instance of an object of type T.
        /// </summary>
        /// <param name="typeName">the type of the item, passed as string.</param>
        /// <returns>the newly created instance of the object.</returns>
        public static object? CreateItem(string? typeName)
        {
            if (typeName is null)
            {
                return null;
            }

            switch (typeName)
            {
                case "Veggie":
                    typeName = typeof(Veggie).AssemblyQualifiedName;
                    break;
                case "Fruit":
                    typeName = typeof(Fruit).AssemblyQualifiedName;
                    break;
                default:
                    throw new NotImplementedException();
            }

            Type? type = Type.GetType(typeName!);

            return Activator.CreateInstance(type!);
        }
    }
}

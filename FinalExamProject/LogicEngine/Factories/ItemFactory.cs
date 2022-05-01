// <copyright file="ItemFactory.cs" company="Charles Norden -- 011606177">
// Copyright (c) Charles Norden -- 011606177. All rights reserved.
// </copyright>

namespace LogicEngine.Factories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

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
        public static object? CreateItem(string typeName)
        {
            Type newItemType = Type.GetType(typeName);

            if (newItemType != null)
            {
                return Activator.CreateInstance(newItemType);
            }

            // Iterate through the assemblies to find the correct type.
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                newItemType = assembly.GetType(typeName);

                if (newItemType != null)
                {
                    return Activator.CreateInstance(newItemType);
                }
            }

            return null;
        }
}
}

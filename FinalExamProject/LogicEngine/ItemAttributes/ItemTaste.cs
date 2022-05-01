// <copyright file="ItemTaste.cs" company="Charles Norden -- 011606177">
// Copyright (c) Charles Norden -- 011606177. All rights reserved.
// </copyright>

namespace LogicEngine.ItemAttributes
{
    using System;

    /// <summary>
    /// FoodItem Taste.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1602:Enumeration items should be documented", Justification = "Too many enum elements and they are all self-explanatory.")]
    [Flags]
    internal enum ItemTaste
    {
        SWEET,
        SOUR,
        BITTER,
    }
}

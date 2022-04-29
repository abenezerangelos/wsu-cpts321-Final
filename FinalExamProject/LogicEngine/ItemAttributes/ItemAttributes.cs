// <copyright file="ItemAttributes.cs" company="Charles Norden -- 011606177">
// Copyright (c) Charles Norden -- 011606177. All rights reserved.
// </copyright>

namespace LogicEngine.ItemAttributes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Item Color.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1602:Enumeration items should be documented", Justification = "Too many enum elements and they are all self-explanatory.")]
    [Flags]
    internal enum ItemColor
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
    [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1602:Enumeration items should be documented", Justification = "Too many enum elements and they are all self-explanatory.")]
    [Flags]
    internal enum ItemShape
    {
        SQUARE,
        CIRCLE,
        OVAL,
    }

    /// <summary>
    /// Item Texture.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1602:Enumeration items should be documented", Justification = "Too many enum elements and they are all self-explanatory.")]
    [Flags]
    internal enum ItemTexture
    {
        FIRM,
        SOFT,
        CRUNCHY,
        CHEWY,
    }

    /// <summary>
    /// Item Size.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1602:Enumeration items should be documented", Justification = "Too many enum elements and they are all self-explanatory.")]
    [Flags]
    internal enum ItemSize
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
    [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1602:Enumeration items should be documented", Justification = "Too many enum elements and they are all self-explanatory.")]
    [Flags]
    internal enum ItemTaste
    {
        SWEET,
        SOUR,
        BITTER,
    }
}

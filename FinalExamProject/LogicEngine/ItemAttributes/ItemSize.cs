// <copyright file="ItemSize.cs" company="Charles Norden -- 011606177">
// Copyright (c) Charles Norden -- 011606177. All rights reserved.
// </copyright>

namespace LogicEngine.ItemAttributes
{
    using System;

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
        YUGE,
    }
}

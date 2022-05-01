// <copyright file="Basket.cs" company="Charles Norden -- 011606177">
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
    using LogicEngine.AbstractBaseClass;

    /// <summary>
    /// Class Basket. Container for Items.
    /// </summary>
    /// <typeparam name="T">Generic type T.</typeparam>
    internal class Basket<T> : List<T>
    {
        ///// <summary>
        ///// The content of the basket.
        ///// </summary>
        // [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1401:Fields should be private", Justification = "Basket content should be visible.")]
        // public List<T>? Contents;

        ///// <summary>
        ///// Initializes a new instance of the <see cref="Basket{T}"/> class.
        ///// </summary>
        // public Basket()
        // {
        //    this.Contents = null;
        // }

        ///// <summary>
        ///// Initializes a new instance of the <see cref="Basket{T}"/> class.
        ///// </summary>
        ///// <param name="item">The first item in the basket, which dictates the rest of the item.</param>
        // public Basket(T item)
        // {
        //    this.Contents = new List<T>();
        //    this.Contents.Add(item);
        // }

        ///// <summary>
        ///// Add the new item into the Basket.
        ///// </summary> /// <param name="item">the item to be added.</param>
        // public void Add(T item)
        // {
        //    if (this.Contents == null)
        //    {
        //        this.Contents = new List<T>();
        //    }

        // this.Contents.Add((T)item);
        // }
    }
}

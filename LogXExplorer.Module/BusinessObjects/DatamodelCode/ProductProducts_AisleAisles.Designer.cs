﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace LogXExplorer.Module.BusinessObjects.Database
{

    public partial class ProductProducts_AisleAisles : XPObject
    {
        Aisle fAisles;
        [Indexed(@"Products", Name = @"iAislesProducts_ProductProducts_AisleAisles", Unique = true)]
        [Association(@"ProductProducts_AisleAislesReferencesAisle")]
        public Aisle Aisles
        {
            get { return fAisles; }
            set { SetPropertyValue<Aisle>(nameof(Aisles), ref fAisles, value); }
        }
        Product fProducts;
        [Association(@"ProductProducts_AisleAislesReferencesProduct")]
        public Product Products
        {
            get { return fProducts; }
            set { SetPropertyValue<Product>(nameof(Products), ref fProducts, value); }
        }
    }

}
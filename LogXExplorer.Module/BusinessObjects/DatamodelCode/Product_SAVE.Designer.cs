﻿////------------------------------------------------------------------------------
//// <auto-generated>
////     This code was generated by a tool.
////
////     Changes to this file may cause incorrect behavior and will be lost if
////     the code is regenerated.
//// </auto-generated>
////------------------------------------------------------------------------------
//using System;
//using DevExpress.Xpo;
//using DevExpress.Xpo.Metadata;
//using DevExpress.Data.Filtering;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Reflection;

//namespace LogXExplorer.Module.BusinessObjects.Database
//{
//    public partial class ProductSAVE : XPObject
//    {
        
//        string fIdentifier;
//        public string Identifier
//        {
//            get { return fIdentifier; }
//            set { SetPropertyValue<string>(nameof(Identifier), ref fIdentifier, value); }
//        }
        
//        string fName;
//        public string Name
//        {
//            get { return fName; }
//            set { SetPropertyValue<string>(nameof(Name), ref fName, value); }
//        }

        
//        ProduktGroup fProductGroup;
//        [Indexed(Name = @"iProductGroup_Product")]
//        [Association(@"ProductReferencesProduktGroup")]
//        public ProduktGroup ProductGroup
//        {
//            get { return fProductGroup; }
//            set { SetPropertyValue<ProduktGroup>(nameof(ProductGroup), ref fProductGroup, value); }
//        }

        
//        Producer fProducer;
//        [Indexed(Name = @"iProducer_Product")]
//        [Association(@"ProductReferencesProducer")]
//        public Producer Producer
//        {
//            get { return fProducer; }
//            set { SetPropertyValue<Producer>(nameof(Producer), ref fProducer, value); }
//        }
//        string fType;
//        public string Type
//        {
//            get { return fType; }
//            set { SetPropertyValue<string>(nameof(Type), ref fType, value); }
//        }
//        string fVTSZ;
//        public string VTSZ
//        {
//            get { return fVTSZ; }
//            set { SetPropertyValue<string>(nameof(VTSZ), ref fVTSZ, value); }
//        }
//        string fBarCode;
//        public string BarCode
//        {
//            get { return fBarCode; }
//            set { SetPropertyValue<string>(nameof(BarCode), ref fBarCode, value); }
//        }

        
//        UnitType fUnitType;
//        [Indexed(Name = @"iUnitType_Product")]
//        [Association(@"ProductReferencesUnitType")]
//        public UnitType UnitType
//        {
//            get { return fUnitType; }
//            set { SetPropertyValue<UnitType>(nameof(UnitType), ref fUnitType, value); }
//        }

        
//        AbcType fAbcClass;
//        [Indexed(Name = @"iAbcClass_Product")]
//        public AbcType AbcClass
//        {
//            get { return fAbcClass; }
//            set { SetPropertyValue<AbcType>(nameof(AbcClass), ref fAbcClass, value); }
//        }

        
//        AccelarateType fAccelerateType;
//        [Indexed(Name = @"iAccelerateType_Product")]
//        [Association(@"ProductReferencesAccelarateType")]
//        public AccelarateType AccelerateType
//        {
//            get { return fAccelerateType; }
//            set { SetPropertyValue<AccelarateType>(nameof(AccelerateType), ref fAccelerateType, value); }
//        }
//        int fFPCType;
//        [Indexed(Name = @"iFPCType_Product")]
//        public int FPCType
//        {
//            get { return fFPCType; }
//            set { SetPropertyValue<int>(nameof(FPCType), ref fFPCType, value); }
//        }

        
//        LoadCarrierType fDefaultLCT;
//        [Indexed(Name = @"iDefaultLCT_Product")]
//        [Association(@"ProductReferencesLoadCarrierType")]
//        public LoadCarrierType DefaultLCT
//        {
//            get { return fDefaultLCT; }
//            set { SetPropertyValue<LoadCarrierType>(nameof(DefaultLCT), ref fDefaultLCT, value); }
//        }
//        decimal fWidth;
//        public decimal Width
//        {
//            get { return fWidth; }
//            set { SetPropertyValue<decimal>(nameof(Width), ref fWidth, value); }
//        }
//        decimal fLength;
//        public decimal Length
//        {
//            get { return fLength; }
//            set { SetPropertyValue<decimal>(nameof(Length), ref fLength, value); }
//        }
//        decimal fHeight;
//        public decimal Height
//        {
//            get { return fHeight; }
//            set { SetPropertyValue<decimal>(nameof(Height), ref fHeight, value); }
//        }
//        double fWeight;
//        public double Weight
//        {
//            get { return fWeight; }
//            set { SetPropertyValue<double>(nameof(Weight), ref fWeight, value); }
//        }

        
//        System.Drawing.Image fPhoto;
//        [Size(SizeAttribute.Unlimited)]
//        [ValueConverter(typeof(DevExpress.Xpo.Metadata.ImageValueConverter))]
//        [MemberDesignTimeVisibility(true)]
//        public System.Drawing.Image Photo
//        {
//            get { return fPhoto; }
//            set { SetPropertyValue<System.Drawing.Image>(nameof(Photo), ref fPhoto, value); }
//        }
//        double fNormalQty;
//        public double NormalQty
//        {
//            get { return fNormalQty; }
//            set { SetPropertyValue<double>(nameof(NormalQty), ref fNormalQty, value); }
//        }
//        double fReservedQty;
//        public double ReservedQty
//        {
//            get { return fReservedQty; }
//            set { SetPropertyValue<double>(nameof(ReservedQty), ref fReservedQty, value); }
//        }
//        double fBlockedQty;
//        public double BlockedQty
//        {
//            get { return fBlockedQty; }
//            set { SetPropertyValue<double>(nameof(BlockedQty), ref fBlockedQty, value); }
//        }
//        double fDispousedQty;
//        public double DispousedQty
//        {
//            get { return fDispousedQty; }
//            set { SetPropertyValue<double>(nameof(DispousedQty), ref fDispousedQty, value); }
//        }
//        int fStatus;
//        [Indexed(Name = @"iStatus_Product")]
//        public int Status
//        {
//            get { return fStatus; }
//            set { SetPropertyValue<int>(nameof(Status), ref fStatus, value); }
//        }

        
//        Aisle fDefaultAisle;
//        [Indexed(Name = @"iDefaultAisle_Product")]
//        public Aisle DefaultAisle
//        {
//            get { return fDefaultAisle; }
//            set { SetPropertyValue<Aisle>(nameof(DefaultAisle), ref fDefaultAisle, value); }
//        }
//        double fMinQty;
//        public double MinQty
//        {
//            get { return fMinQty; }
//            set { SetPropertyValue<double>(nameof(MinQty), ref fMinQty, value); }
//        }
//        double fMaxQty;
//        public double MaxQty
//        {
//            get { return fMaxQty; }
//            set { SetPropertyValue<double>(nameof(MaxQty), ref fMaxQty, value); }
//        }
//        double fEmergQty;
//        public double EmergQty
//        {
//            get { return fEmergQty; }
//            set { SetPropertyValue<double>(nameof(EmergQty), ref fEmergQty, value); }
//        }

//        [Association(@"CommonTrDetailReferencesProduct")]
//        public XPCollection<CommonTrDetail> CommonTrDetails { get { return GetCollection<CommonTrDetail>(nameof(CommonTrDetails)); } }

//        [Association(@"IocpReferencesProduct")]
//        public XPCollection<Iocp> Iocps { get { return GetCollection<Iocp>(nameof(Iocps)); } }
        
//        [Association(@"IocpReferencesProduct1")]
//        public XPCollection<Iocp> Iocps1 { get { return GetCollection<Iocp>(nameof(Iocps1)); } }

//        [Association(@"LctProConReferencesProduct")]
//        public XPCollection<LctProCon> LctProCons { get { return GetCollection<LctProCon>(nameof(LctProCons)); } }

//        [Association(@"ProductProducts_AisleAislesReferencesProduct")]
//        public XPCollection<ProductProducts_AisleAisles> ProductProducts_AisleAisless { get { return GetCollection<ProductProducts_AisleAisles>(nameof(ProductProducts_AisleAisless)); } }

//        [Association(@"QtyExchangeReferencesProduct")]
//        public XPCollection<QtyExchange> QtyExchanges { get { return GetCollection<QtyExchange>(nameof(QtyExchanges)); } }

//        [Association(@"StockReferencesProduct")]
//        public XPCollection<Stock> Stocks { get { return GetCollection<Stock>(nameof(Stocks)); } }

//        [Association(@"StockHistoryReferencesProduct")]
//        public XPCollection<StockHistory> StockHistories { get { return GetCollection<StockHistory>(nameof(StockHistories)); } }
//    }

//}
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

    public partial class Iocp : XPObject
    {
        string fName;
        public string Name
        {
            get { return fName; }
            set { SetPropertyValue<string>(nameof(Name), ref fName, value); }
        }
        string fIocpType;
        public string IocpType
        {
            get { return fIocpType; }
            set { SetPropertyValue<string>(nameof(IocpType), ref fIocpType, value); }
        }
        CommonTrType fActiveType;
        public CommonTrType ActiveType
        {
            get { return fActiveType; }
            set { SetPropertyValue<CommonTrType>(nameof(ActiveType), ref fActiveType, value); }
        }
        CommonTrHeader fActiveCTrH;
        [Association(@"IocpReferencesCommonTrHeader")]
        public CommonTrHeader ActiveCTrH
        {
            get { return fActiveCTrH; }
            set { SetPropertyValue<CommonTrHeader>(nameof(ActiveCTrH), ref fActiveCTrH, value); }
        }
        CommonTrDetail fActiveCtrD;
        [Association(@"IocpReferencesCommonTrDetail")]
        public CommonTrDetail ActiveCtrD
        {
            get { return fActiveCtrD; }
            set { SetPropertyValue<CommonTrDetail>(nameof(ActiveCtrD), ref fActiveCtrD, value); }
        }
        LoadCarrier fActiveLc;
        [Association(@"IocpReferencesLoadCarrier")]
        public LoadCarrier ActiveLc
        {
            get { return fActiveLc; }
            set { SetPropertyValue<LoadCarrier>(nameof(ActiveLc), ref fActiveLc, value); }
        }
        Product fActiveProduct;
        [Association(@"IocpReferencesProduct")]
        public Product ActiveProduct
        {
            get { return fActiveProduct; }
            set { SetPropertyValue<Product>(nameof(ActiveProduct), ref fActiveProduct, value); }
        }
        int fCalcLcNumber;
        public int CalcLcNumber
        {
            get { return fCalcLcNumber; }
            set { SetPropertyValue<int>(nameof(CalcLcNumber), ref fCalcLcNumber, value); }
        }
        bool fLcCallingOK;
        public bool LcCallingOK
        {
            get { return fLcCallingOK; }
            set { SetPropertyValue<bool>(nameof(LcCallingOK), ref fLcCallingOK, value); }
        }
        QtyExchange fQexchange;
        [Association(@"IocpReferencesQtyExchange")]
        public QtyExchange Qexchange
        {
            get { return fQexchange; }
            set { SetPropertyValue<QtyExchange>(nameof(Qexchange), ref fQexchange, value); }
        }
        int fStoredQty;
        public int StoredQty
        {
            get { return fStoredQty; }
            set { SetPropertyValue<int>(nameof(StoredQty), ref fStoredQty, value); }
        }
        decimal fWieghtBeforeStart;
        public decimal WieghtBeforeStart
        {
            get { return fWieghtBeforeStart; }
            set { SetPropertyValue<decimal>(nameof(WieghtBeforeStart), ref fWieghtBeforeStart, value); }
        }
        int fWeightCurrent;
        public int WeightCurrent
        {
            get { return fWeightCurrent; }
            set { SetPropertyValue<int>(nameof(WeightCurrent), ref fWeightCurrent, value); }
        }
        string fBarcode;
        [ColumnDefaultValue("")]
        [NonPersistent]
        public string Barcode
        {
            get { return fBarcode; }
            set { SetPropertyValue<string>(nameof(Barcode), ref fBarcode, value); }
        }
        double fStoredUnit;
        public double StoredUnit
        {
            get { return fStoredUnit; }
            set { SetPropertyValue<double>(nameof(StoredUnit), ref fStoredUnit, value); }
        }
        byte fTargetTag;
        public byte TargetTag
        {
            get { return fTargetTag; }
            set { SetPropertyValue<byte>(nameof(TargetTag), ref fTargetTag, value); }
        }
        Product fTargetProduct;
        [Association(@"IocpReferencesProduct1")]
        public Product TargetProduct
        {
            get { return fTargetProduct; }
            set { SetPropertyValue<Product>(nameof(TargetProduct), ref fTargetProduct, value); }
        }
        byte ftargetLcNum;
        public byte targetLcNum
        {
            get { return ftargetLcNum; }
            set { SetPropertyValue<byte>(nameof(targetLcNum), ref ftargetLcNum, value); }
        }
        string fRFIDtag;
        public string RFIDtag
        {
            get { return fRFIDtag; }
            set { SetPropertyValue<string>(nameof(RFIDtag), ref fRFIDtag, value); }
        }
        string fMerlegTag;
        public string MerlegTag
        {
            get { return fMerlegTag; }
            set { SetPropertyValue<string>(nameof(MerlegTag), ref fMerlegTag, value); }
        }
        [Association(@"TransportOrderReferencesIocp")]
        public XPCollection<TransportOrder> TransportOrders { get { return GetCollection<TransportOrder>(nameof(TransportOrders)); } }
    }

}

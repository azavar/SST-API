﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.17929.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("SSTReceipt", Namespace="", IsNullable=false)]
public partial class SSTReceiptType {
    
    private SSTReceiptTypeReceiptHeader receiptHeaderField;
    
    private SSTReceiptTypeTransmissionReceipt transmissionReceiptField;
    
    private string receiptVersionField;
    
    public SSTReceiptType() {
        this.receiptVersionField = "SST2015V01";
    }
    
    /// <remarks/>
    public SSTReceiptTypeReceiptHeader ReceiptHeader {
        get {
            return this.receiptHeaderField;
        }
        set {
            this.receiptHeaderField = value;
        }
    }
    
    /// <remarks/>
    public SSTReceiptTypeTransmissionReceipt TransmissionReceipt {
        get {
            return this.transmissionReceiptField;
        }
        set {
            this.transmissionReceiptField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string receiptVersion {
        get {
            return this.receiptVersionField;
        }
        set {
            this.receiptVersionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class SSTReceiptTypeReceiptHeader {
    
    private System.DateTime receiptTimestampField;
    
    /// <remarks/>
    public System.DateTime ReceiptTimestamp {
        get {
            return this.receiptTimestampField;
        }
        set {
            this.receiptTimestampField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class SSTReceiptTypeTransmissionReceipt {
    
    private string transmissionIDField;
    
    private System.DateTime transmissionTimestampField;
    
    /// <remarks/>
    public string TransmissionID {
        get {
            return this.transmissionIDField;
        }
        set {
            this.transmissionIDField = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime TransmissionTimestamp {
        get {
            return this.transmissionTimestampField;
        }
        set {
            this.transmissionTimestampField = value;
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Этот исходный код был создан с помощью xsd, версия=4.6.81.0.
// 
namespace WordReportsFull.XSDSheme.NdflFl.XML {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("Ndfl", Namespace="", IsNullable=false)]
    public partial class NdflFl {
        
        private NdflFlFn1534[] fn1534Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Fn1534")]
        public NdflFlFn1534[] Fn1534 {
            get {
                return this.fn1534Field;
            }
            set {
                this.fn1534Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class NdflFlFn1534 {
        
        private NdflFlFn1534FN17091 fN17091Field;
        
        private string nDFLField;
        
        private string n590Field;
        
        /// <remarks/>
        public NdflFlFn1534FN17091 FN17091 {
            get {
                return this.fN17091Field;
            }
            set {
                this.fN17091Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NDFL {
            get {
                return this.nDFLField;
            }
            set {
                this.nDFLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string N590 {
            get {
                return this.n590Field;
            }
            set {
                this.n590Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class NdflFlFn1534FN17091 {
        
        private string d83_1Field;
        
        private string dataIzdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string D83_1 {
            get {
                return this.d83_1Field;
            }
            set {
                this.d83_1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DataIzd {
            get {
                return this.dataIzdField;
            }
            set {
                this.dataIzdField = value;
            }
        }
    }
}

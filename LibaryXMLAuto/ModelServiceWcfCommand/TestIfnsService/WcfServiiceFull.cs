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
// Этот исходный код был создан с помощью xsd, версия=4.7.2053.0.
// 
namespace LibaryXMLAutoModelServiceWcfCommand.TestIfnsService {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2053.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("ServiceWcfFullCommand", Namespace="", IsNullable=false)]
    public partial class ServiceWcf {
        
        private ServiceWcfCommand serviceWcfCommandField;
        
        /// <remarks/>
        public ServiceWcfCommand ServiceWcfCommand {
            get {
                return this.serviceWcfCommandField;
            }
            set {
                this.serviceWcfCommandField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2053.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class ServiceWcfCommand {
        
        private GroupOtdel groupOtdelField;
        
        private ClassOtdel classOtdelField;
        
        private SobytieOtdel sobytieOtdelField;
        
        private int idField;
        
        private bool idFieldSpecified;
        
        private int idGroupField;
        
        private bool idGroupFieldSpecified;
        
        private int idClassField;
        
        private bool idClassFieldSpecified;
        
        private int idSobytieSystemField;
        
        private bool idSobytieSystemFieldSpecified;
        
        private string descriptionFullField;
        
        private string descriptionParamField;
        
        private string commandField;
        
        private System.DateTime dateCreateField;
        
        private bool dateCreateFieldSpecified;
        
        /// <remarks/>
        public GroupOtdel GroupOtdel {
            get {
                return this.groupOtdelField;
            }
            set {
                this.groupOtdelField = value;
            }
        }
        
        /// <remarks/>
        public ClassOtdel ClassOtdel {
            get {
                return this.classOtdelField;
            }
            set {
                this.classOtdelField = value;
            }
        }
        
        /// <remarks/>
        public SobytieOtdel SobytieOtdel {
            get {
                return this.sobytieOtdelField;
            }
            set {
                this.sobytieOtdelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdSpecified {
            get {
                return this.idFieldSpecified;
            }
            set {
                this.idFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int IdGroup {
            get {
                return this.idGroupField;
            }
            set {
                this.idGroupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdGroupSpecified {
            get {
                return this.idGroupFieldSpecified;
            }
            set {
                this.idGroupFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int IdClass {
            get {
                return this.idClassField;
            }
            set {
                this.idClassField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdClassSpecified {
            get {
                return this.idClassFieldSpecified;
            }
            set {
                this.idClassFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int IdSobytieSystem {
            get {
                return this.idSobytieSystemField;
            }
            set {
                this.idSobytieSystemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdSobytieSystemSpecified {
            get {
                return this.idSobytieSystemFieldSpecified;
            }
            set {
                this.idSobytieSystemFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DescriptionFull {
            get {
                return this.descriptionFullField;
            }
            set {
                this.descriptionFullField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DescriptionParam {
            get {
                return this.descriptionParamField;
            }
            set {
                this.descriptionParamField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Command {
            get {
                return this.commandField;
            }
            set {
                this.commandField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime DateCreate {
            get {
                return this.dateCreateField;
            }
            set {
                this.dateCreateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateCreateSpecified {
            get {
                return this.dateCreateFieldSpecified;
            }
            set {
                this.dateCreateFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2053.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class GroupOtdel {
        
        private int idGroupField;
        
        private bool idGroupFieldSpecified;
        
        private string groupDescriptionField;
        
        private string nameGroupField;
        
        private System.DateTime dateCreateField;
        
        private bool dateCreateFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int IdGroup {
            get {
                return this.idGroupField;
            }
            set {
                this.idGroupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdGroupSpecified {
            get {
                return this.idGroupFieldSpecified;
            }
            set {
                this.idGroupFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string GroupDescription {
            get {
                return this.groupDescriptionField;
            }
            set {
                this.groupDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NameGroup {
            get {
                return this.nameGroupField;
            }
            set {
                this.nameGroupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime DateCreate {
            get {
                return this.dateCreateField;
            }
            set {
                this.dateCreateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateCreateSpecified {
            get {
                return this.dateCreateFieldSpecified;
            }
            set {
                this.dateCreateFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2053.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class ClassOtdel {
        
        private int idClassField;
        
        private bool idClassFieldSpecified;
        
        private string classLanguageField;
        
        private string classDescriptionField;
        
        private System.DateTime dateCreateField;
        
        private bool dateCreateFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int IdClass {
            get {
                return this.idClassField;
            }
            set {
                this.idClassField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdClassSpecified {
            get {
                return this.idClassFieldSpecified;
            }
            set {
                this.idClassFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ClassLanguage {
            get {
                return this.classLanguageField;
            }
            set {
                this.classLanguageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ClassDescription {
            get {
                return this.classDescriptionField;
            }
            set {
                this.classDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime DateCreate {
            get {
                return this.dateCreateField;
            }
            set {
                this.dateCreateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateCreateSpecified {
            get {
                return this.dateCreateFieldSpecified;
            }
            set {
                this.dateCreateFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2053.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class SobytieOtdel {
        
        private int idSobytieSystemField;
        
        private bool idSobytieSystemFieldSpecified;
        
        private string descriptionSobytieField;
        
        private System.DateTime dateCreateField;
        
        private bool dateCreateFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int IdSobytieSystem {
            get {
                return this.idSobytieSystemField;
            }
            set {
                this.idSobytieSystemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdSobytieSystemSpecified {
            get {
                return this.idSobytieSystemFieldSpecified;
            }
            set {
                this.idSobytieSystemFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DescriptionSobytie {
            get {
                return this.descriptionSobytieField;
            }
            set {
                this.descriptionSobytieField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime DateCreate {
            get {
                return this.dateCreateField;
            }
            set {
                this.dateCreateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateCreateSpecified {
            get {
                return this.dateCreateFieldSpecified;
            }
            set {
                this.dateCreateFieldSpecified = value;
            }
        }
    }
}

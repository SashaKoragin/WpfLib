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
// Этот исходный код был создан с помощью xsd, версия=4.7.2046.0.
// 
namespace EfDatabaseAutomation.Automation.SelectParametrSheme {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class ServiceWcfAutomation : ModelSelect {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ModelSelect {
        
        private ParametrsSelect parametrsSelectField;
        
        private LogicsSelectAutomation logicsSelectAutomationField;
        
        private InfoViewAutomation[] infoViewAutomationField;
        
        private ParameterProcedureWeb parameterProcedureWebField;
        
        private string resultSelectProcedureWebField;
        
        private TemplateProcedure templateProcedureField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public ParametrsSelect ParametrsSelect {
            get {
                return this.parametrsSelectField;
            }
            set {
                this.parametrsSelectField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public LogicsSelectAutomation LogicsSelectAutomation {
            get {
                return this.logicsSelectAutomationField;
            }
            set {
                this.logicsSelectAutomationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InfoViewAutomation", IsNullable=true)]
        public InfoViewAutomation[] InfoViewAutomation {
            get {
                return this.infoViewAutomationField;
            }
            set {
                this.infoViewAutomationField = value;
            }
        }
        
        /// <remarks/>
        public ParameterProcedureWeb ParameterProcedureWeb {
            get {
                return this.parameterProcedureWebField;
            }
            set {
                this.parameterProcedureWebField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string ResultSelectProcedureWeb {
            get {
                return this.resultSelectProcedureWebField;
            }
            set {
                this.resultSelectProcedureWebField = value;
            }
        }
        
        /// <remarks/>
        public TemplateProcedure TemplateProcedure {
            get {
                return this.templateProcedureField;
            }
            set {
                this.templateProcedureField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class ParametrsSelect {
        
        private int idField;
        
        private int idCodeProcedureField;
        
        private string innField;
        
        private long regNumberField;
        
        public ParametrsSelect() {
            this.idCodeProcedureField = 0;
            this.innField = "";
            this.regNumberField = ((long)(0));
        }
        
        /// <remarks/>
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(0)]
        public int IdCodeProcedure {
            get {
                return this.idCodeProcedureField;
            }
            set {
                this.idCodeProcedureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string Inn {
            get {
                return this.innField;
            }
            set {
                this.innField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(long), "0")]
        public long RegNumber {
            get {
                return this.regNumberField;
            }
            set {
                this.regNumberField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class LogicsSelectAutomation {
        
        private int idField;
        
        private string selectInfoField;
        
        private string selectedParametrField;
        
        private string selectUserField;
        
        /// <remarks/>
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SelectInfo {
            get {
                return this.selectInfoField;
            }
            set {
                this.selectInfoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SelectedParametr {
            get {
                return this.selectedParametrField;
            }
            set {
                this.selectedParametrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SelectUser {
            get {
                return this.selectUserField;
            }
            set {
                this.selectUserField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class InfoViewAutomation {
        
        private bool isVisibleField;
        
        private string valueField;
        
        private string nameTableField;
        
        private string nameColumnField;
        
        private string infoField;
        
        private string typeColumnField;
        
        /// <remarks/>
        public bool IsVisible {
            get {
                return this.isVisibleField;
            }
            set {
                this.isVisibleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NameTable {
            get {
                return this.nameTableField;
            }
            set {
                this.nameTableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NameColumn {
            get {
                return this.nameColumnField;
            }
            set {
                this.nameColumnField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Info {
            get {
                return this.infoField;
            }
            set {
                this.infoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TypeColumn {
            get {
                return this.typeColumnField;
            }
            set {
                this.typeColumnField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class ParameterProcedureWeb {
        
        private int idField;
        
        private string selectInfoModelField;
        
        private string selectParameterTableField;
        
        private string modelClassFindField;
        
        private string parameterProcedureField;
        
        private string selectUserField;
        
        /// <remarks/>
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SelectInfoModel {
            get {
                return this.selectInfoModelField;
            }
            set {
                this.selectInfoModelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SelectParameterTable {
            get {
                return this.selectParameterTableField;
            }
            set {
                this.selectParameterTableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ModelClassFind {
            get {
                return this.modelClassFindField;
            }
            set {
                this.modelClassFindField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ParameterProcedure {
            get {
                return this.parameterProcedureField;
            }
            set {
                this.parameterProcedureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SelectUser {
            get {
                return this.selectUserField;
            }
            set {
                this.selectUserField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class TemplateProcedure {
        
        private int idTemplateField;
        
        private string[] innField;
        
        /// <remarks/>
        public int IdTemplate {
            get {
                return this.idTemplateField;
            }
            set {
                this.idTemplateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string[] Inn {
            get {
                return this.innField;
            }
            set {
                this.innField = value;
            }
        }
    }
}

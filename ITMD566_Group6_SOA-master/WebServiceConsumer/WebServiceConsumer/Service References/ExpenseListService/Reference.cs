﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServiceConsumer.ExpenseListService {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2556.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ITMD466/")]
    public partial class Exception : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
                this.RaisePropertyChanged("message");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2556.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ITMD466/")]
    public partial class expense : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string advanceAmountField;
        
        private string amountField;
        
        private string datePurchasedField;
        
        private string dateSubmittedField;
        
        private string descriptionField;
        
        private string employeeIDField;
        
        private string expenseCategotyField;
        
        private string expenseIDField;
        
        private string expenseTypeField;
        
        private string paymentMethodField;
        
        private string truckIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string advanceAmount {
            get {
                return this.advanceAmountField;
            }
            set {
                this.advanceAmountField = value;
                this.RaisePropertyChanged("advanceAmount");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
                this.RaisePropertyChanged("amount");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string datePurchased {
            get {
                return this.datePurchasedField;
            }
            set {
                this.datePurchasedField = value;
                this.RaisePropertyChanged("datePurchased");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string dateSubmitted {
            get {
                return this.dateSubmittedField;
            }
            set {
                this.dateSubmittedField = value;
                this.RaisePropertyChanged("dateSubmitted");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
                this.RaisePropertyChanged("description");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string employeeID {
            get {
                return this.employeeIDField;
            }
            set {
                this.employeeIDField = value;
                this.RaisePropertyChanged("employeeID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string expenseCategoty {
            get {
                return this.expenseCategotyField;
            }
            set {
                this.expenseCategotyField = value;
                this.RaisePropertyChanged("expenseCategoty");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string expenseID {
            get {
                return this.expenseIDField;
            }
            set {
                this.expenseIDField = value;
                this.RaisePropertyChanged("expenseID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string expenseType {
            get {
                return this.expenseTypeField;
            }
            set {
                this.expenseTypeField = value;
                this.RaisePropertyChanged("expenseType");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string paymentMethod {
            get {
                return this.paymentMethodField;
            }
            set {
                this.paymentMethodField = value;
                this.RaisePropertyChanged("paymentMethod");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public string truckID {
            get {
                return this.truckIDField;
            }
            set {
                this.truckIDField = value;
                this.RaisePropertyChanged("truckID");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ITMD466/", ConfigurationName="ExpenseListService.ExpenseList")]
    public interface ExpenseList {
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://ITMD466/ExpenseList/paymentMethodRequest", ReplyAction="http://ITMD466/ExpenseList/paymentMethodResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WebServiceConsumer.ExpenseListService.Exception), Action="http://ITMD466/ExpenseList/paymentMethod/Fault/Exception", Name="Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WebServiceConsumer.ExpenseListService.paymentMethodResponse paymentMethod(WebServiceConsumer.ExpenseListService.paymentMethodRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ITMD466/ExpenseList/paymentMethodRequest", ReplyAction="http://ITMD466/ExpenseList/paymentMethodResponse")]
        System.Threading.Tasks.Task<WebServiceConsumer.ExpenseListService.paymentMethodResponse> paymentMethodAsync(WebServiceConsumer.ExpenseListService.paymentMethodRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="paymentMethod", WrapperNamespace="http://ITMD466/", IsWrapped=true)]
    public partial class paymentMethodRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ITMD466/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string paymentMethod;
        
        public paymentMethodRequest() {
        }
        
        public paymentMethodRequest(string paymentMethod) {
            this.paymentMethod = paymentMethod;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="paymentMethodResponse", WrapperNamespace="http://ITMD466/", IsWrapped=true)]
    public partial class paymentMethodResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ITMD466/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WebServiceConsumer.ExpenseListService.expense[] @return;
        
        public paymentMethodResponse() {
        }
        
        public paymentMethodResponse(WebServiceConsumer.ExpenseListService.expense[] @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ExpenseListChannel : WebServiceConsumer.ExpenseListService.ExpenseList, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ExpenseListClient : System.ServiceModel.ClientBase<WebServiceConsumer.ExpenseListService.ExpenseList>, WebServiceConsumer.ExpenseListService.ExpenseList {
        
        public ExpenseListClient() {
        }
        
        public ExpenseListClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ExpenseListClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ExpenseListClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ExpenseListClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServiceConsumer.ExpenseListService.paymentMethodResponse WebServiceConsumer.ExpenseListService.ExpenseList.paymentMethod(WebServiceConsumer.ExpenseListService.paymentMethodRequest request) {
            return base.Channel.paymentMethod(request);
        }
        
        public WebServiceConsumer.ExpenseListService.expense[] paymentMethod(string paymentMethod1) {
            WebServiceConsumer.ExpenseListService.paymentMethodRequest inValue = new WebServiceConsumer.ExpenseListService.paymentMethodRequest();
            inValue.paymentMethod = paymentMethod1;
            WebServiceConsumer.ExpenseListService.paymentMethodResponse retVal = ((WebServiceConsumer.ExpenseListService.ExpenseList)(this)).paymentMethod(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServiceConsumer.ExpenseListService.paymentMethodResponse> WebServiceConsumer.ExpenseListService.ExpenseList.paymentMethodAsync(WebServiceConsumer.ExpenseListService.paymentMethodRequest request) {
            return base.Channel.paymentMethodAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebServiceConsumer.ExpenseListService.paymentMethodResponse> paymentMethodAsync(string paymentMethod) {
            WebServiceConsumer.ExpenseListService.paymentMethodRequest inValue = new WebServiceConsumer.ExpenseListService.paymentMethodRequest();
            inValue.paymentMethod = paymentMethod;
            return ((WebServiceConsumer.ExpenseListService.ExpenseList)(this)).paymentMethodAsync(inValue);
        }
    }
}

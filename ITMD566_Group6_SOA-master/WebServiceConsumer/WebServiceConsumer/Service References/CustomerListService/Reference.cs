﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServiceConsumer.CustomerListService {
    
    
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
    public partial class customer : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string billingAddressField;
        
        private string businessNameField;
        
        private string cityField;
        
        private string companyNameField;
        
        private string contactNameField;
        
        private string countryField;
        
        private string customerIDField;
        
        private string customerNameField;
        
        private string customerTypeField;
        
        private string dateField;
        
        private string emailAddressField;
        
        private string faxNumberField;
        
        private string otherNumberField;
        
        private string phoneNumberField;
        
        private string postalCodeField;
        
        private string stateField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string billingAddress {
            get {
                return this.billingAddressField;
            }
            set {
                this.billingAddressField = value;
                this.RaisePropertyChanged("billingAddress");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string businessName {
            get {
                return this.businessNameField;
            }
            set {
                this.businessNameField = value;
                this.RaisePropertyChanged("businessName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string city {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
                this.RaisePropertyChanged("city");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string companyName {
            get {
                return this.companyNameField;
            }
            set {
                this.companyNameField = value;
                this.RaisePropertyChanged("companyName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string contactName {
            get {
                return this.contactNameField;
            }
            set {
                this.contactNameField = value;
                this.RaisePropertyChanged("contactName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
                this.RaisePropertyChanged("country");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string customerID {
            get {
                return this.customerIDField;
            }
            set {
                this.customerIDField = value;
                this.RaisePropertyChanged("customerID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string customerName {
            get {
                return this.customerNameField;
            }
            set {
                this.customerNameField = value;
                this.RaisePropertyChanged("customerName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string customerType {
            get {
                return this.customerTypeField;
            }
            set {
                this.customerTypeField = value;
                this.RaisePropertyChanged("customerType");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string date {
            get {
                return this.dateField;
            }
            set {
                this.dateField = value;
                this.RaisePropertyChanged("date");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public string emailAddress {
            get {
                return this.emailAddressField;
            }
            set {
                this.emailAddressField = value;
                this.RaisePropertyChanged("emailAddress");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public string faxNumber {
            get {
                return this.faxNumberField;
            }
            set {
                this.faxNumberField = value;
                this.RaisePropertyChanged("faxNumber");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public string otherNumber {
            get {
                return this.otherNumberField;
            }
            set {
                this.otherNumberField = value;
                this.RaisePropertyChanged("otherNumber");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
        public string phoneNumber {
            get {
                return this.phoneNumberField;
            }
            set {
                this.phoneNumberField = value;
                this.RaisePropertyChanged("phoneNumber");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=14)]
        public string postalCode {
            get {
                return this.postalCodeField;
            }
            set {
                this.postalCodeField = value;
                this.RaisePropertyChanged("postalCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=15)]
        public string state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
                this.RaisePropertyChanged("state");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ITMD466/", ConfigurationName="CustomerListService.CustomerList")]
    public interface CustomerList {
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://ITMD466/CustomerList/listCustomersRequest", ReplyAction="http://ITMD466/CustomerList/listCustomersResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WebServiceConsumer.CustomerListService.Exception), Action="http://ITMD466/CustomerList/listCustomers/Fault/Exception", Name="Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WebServiceConsumer.CustomerListService.listCustomersResponse listCustomers(WebServiceConsumer.CustomerListService.listCustomersRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ITMD466/CustomerList/listCustomersRequest", ReplyAction="http://ITMD466/CustomerList/listCustomersResponse")]
        System.Threading.Tasks.Task<WebServiceConsumer.CustomerListService.listCustomersResponse> listCustomersAsync(WebServiceConsumer.CustomerListService.listCustomersRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listCustomers", WrapperNamespace="http://ITMD466/", IsWrapped=true)]
    public partial class listCustomersRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ITMD466/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string city;
        
        public listCustomersRequest() {
        }
        
        public listCustomersRequest(string city) {
            this.city = city;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listCustomersResponse", WrapperNamespace="http://ITMD466/", IsWrapped=true)]
    public partial class listCustomersResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ITMD466/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WebServiceConsumer.CustomerListService.customer[] @return;
        
        public listCustomersResponse() {
        }
        
        public listCustomersResponse(WebServiceConsumer.CustomerListService.customer[] @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CustomerListChannel : WebServiceConsumer.CustomerListService.CustomerList, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CustomerListClient : System.ServiceModel.ClientBase<WebServiceConsumer.CustomerListService.CustomerList>, WebServiceConsumer.CustomerListService.CustomerList {
        
        public CustomerListClient() {
        }
        
        public CustomerListClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CustomerListClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerListClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerListClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServiceConsumer.CustomerListService.listCustomersResponse WebServiceConsumer.CustomerListService.CustomerList.listCustomers(WebServiceConsumer.CustomerListService.listCustomersRequest request) {
            return base.Channel.listCustomers(request);
        }
        
        public WebServiceConsumer.CustomerListService.customer[] listCustomers(string city) {
            WebServiceConsumer.CustomerListService.listCustomersRequest inValue = new WebServiceConsumer.CustomerListService.listCustomersRequest();
            inValue.city = city;
            WebServiceConsumer.CustomerListService.listCustomersResponse retVal = ((WebServiceConsumer.CustomerListService.CustomerList)(this)).listCustomers(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServiceConsumer.CustomerListService.listCustomersResponse> WebServiceConsumer.CustomerListService.CustomerList.listCustomersAsync(WebServiceConsumer.CustomerListService.listCustomersRequest request) {
            return base.Channel.listCustomersAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebServiceConsumer.CustomerListService.listCustomersResponse> listCustomersAsync(string city) {
            WebServiceConsumer.CustomerListService.listCustomersRequest inValue = new WebServiceConsumer.CustomerListService.listCustomersRequest();
            inValue.city = city;
            return ((WebServiceConsumer.CustomerListService.CustomerList)(this)).listCustomersAsync(inValue);
        }
    }
}

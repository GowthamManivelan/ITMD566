﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServiceConsumer.TrucksList {
    
    
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
    public partial class truck : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string colorField;
        
        private string costField;
        
        private string employeeIDField;
        
        private string licensePlateNumberField;
        
        private string makeYearField;
        
        private string modelField;
        
        private string truckIDField;
        
        private string vINField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string color {
            get {
                return this.colorField;
            }
            set {
                this.colorField = value;
                this.RaisePropertyChanged("color");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string cost {
            get {
                return this.costField;
            }
            set {
                this.costField = value;
                this.RaisePropertyChanged("cost");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string licensePlateNumber {
            get {
                return this.licensePlateNumberField;
            }
            set {
                this.licensePlateNumberField = value;
                this.RaisePropertyChanged("licensePlateNumber");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string makeYear {
            get {
                return this.makeYearField;
            }
            set {
                this.makeYearField = value;
                this.RaisePropertyChanged("makeYear");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string model {
            get {
                return this.modelField;
            }
            set {
                this.modelField = value;
                this.RaisePropertyChanged("model");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string truckID {
            get {
                return this.truckIDField;
            }
            set {
                this.truckIDField = value;
                this.RaisePropertyChanged("truckID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string VIN {
            get {
                return this.vINField;
            }
            set {
                this.vINField = value;
                this.RaisePropertyChanged("VIN");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ITMD466/", ConfigurationName="TrucksList.TrucksListService")]
    public interface TrucksListService {
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://ITMD466/TrucksListService/listTrucksRequest", ReplyAction="http://ITMD466/TrucksListService/listTrucksResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WebServiceConsumer.TrucksList.Exception), Action="http://ITMD466/TrucksListService/listTrucks/Fault/Exception", Name="Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WebServiceConsumer.TrucksList.listTrucksResponse listTrucks(WebServiceConsumer.TrucksList.listTrucksRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ITMD466/TrucksListService/listTrucksRequest", ReplyAction="http://ITMD466/TrucksListService/listTrucksResponse")]
        System.Threading.Tasks.Task<WebServiceConsumer.TrucksList.listTrucksResponse> listTrucksAsync(WebServiceConsumer.TrucksList.listTrucksRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listTrucks", WrapperNamespace="http://ITMD466/", IsWrapped=true)]
    public partial class listTrucksRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ITMD466/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string employeeID;
        
        public listTrucksRequest() {
        }
        
        public listTrucksRequest(string employeeID) {
            this.employeeID = employeeID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listTrucksResponse", WrapperNamespace="http://ITMD466/", IsWrapped=true)]
    public partial class listTrucksResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ITMD466/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WebServiceConsumer.TrucksList.truck[] @return;
        
        public listTrucksResponse() {
        }
        
        public listTrucksResponse(WebServiceConsumer.TrucksList.truck[] @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface TrucksListServiceChannel : WebServiceConsumer.TrucksList.TrucksListService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TrucksListServiceClient : System.ServiceModel.ClientBase<WebServiceConsumer.TrucksList.TrucksListService>, WebServiceConsumer.TrucksList.TrucksListService {
        
        public TrucksListServiceClient() {
        }
        
        public TrucksListServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TrucksListServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TrucksListServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TrucksListServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServiceConsumer.TrucksList.listTrucksResponse WebServiceConsumer.TrucksList.TrucksListService.listTrucks(WebServiceConsumer.TrucksList.listTrucksRequest request) {
            return base.Channel.listTrucks(request);
        }
        
        public WebServiceConsumer.TrucksList.truck[] listTrucks(string employeeID) {
            WebServiceConsumer.TrucksList.listTrucksRequest inValue = new WebServiceConsumer.TrucksList.listTrucksRequest();
            inValue.employeeID = employeeID;
            WebServiceConsumer.TrucksList.listTrucksResponse retVal = ((WebServiceConsumer.TrucksList.TrucksListService)(this)).listTrucks(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServiceConsumer.TrucksList.listTrucksResponse> WebServiceConsumer.TrucksList.TrucksListService.listTrucksAsync(WebServiceConsumer.TrucksList.listTrucksRequest request) {
            return base.Channel.listTrucksAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebServiceConsumer.TrucksList.listTrucksResponse> listTrucksAsync(string employeeID) {
            WebServiceConsumer.TrucksList.listTrucksRequest inValue = new WebServiceConsumer.TrucksList.listTrucksRequest();
            inValue.employeeID = employeeID;
            return ((WebServiceConsumer.TrucksList.TrucksListService)(this)).listTrucksAsync(inValue);
        }
    }
}

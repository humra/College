﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IISVjezbe09Klijent.WSJava {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://java.racunarstvo/", ConfigurationName="WSJava.WSVjezbe09")]
    public interface WSVjezbe09 {
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://java.racunarstvo/WSVjezbe09/helloRequest", ReplyAction="http://java.racunarstvo/WSVjezbe09/helloResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        IISVjezbe09Klijent.WSJava.helloResponse hello(IISVjezbe09Klijent.WSJava.helloRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://java.racunarstvo/WSVjezbe09/helloRequest", ReplyAction="http://java.racunarstvo/WSVjezbe09/helloResponse")]
        System.Threading.Tasks.Task<IISVjezbe09Klijent.WSJava.helloResponse> helloAsync(IISVjezbe09Klijent.WSJava.helloRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://java.racunarstvo/WSVjezbe09/getStudentByIdRequest", ReplyAction="http://java.racunarstvo/WSVjezbe09/getStudentByIdResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        IISVjezbe09Klijent.WSJava.getStudentByIdResponse getStudentById(IISVjezbe09Klijent.WSJava.getStudentByIdRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://java.racunarstvo/WSVjezbe09/getStudentByIdRequest", ReplyAction="http://java.racunarstvo/WSVjezbe09/getStudentByIdResponse")]
        System.Threading.Tasks.Task<IISVjezbe09Klijent.WSJava.getStudentByIdResponse> getStudentByIdAsync(IISVjezbe09Klijent.WSJava.getStudentByIdRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="hello", WrapperNamespace="http://java.racunarstvo/", IsWrapped=true)]
    public partial class helloRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://java.racunarstvo/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string name;
        
        public helloRequest() {
        }
        
        public helloRequest(string name) {
            this.name = name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="helloResponse", WrapperNamespace="http://java.racunarstvo/", IsWrapped=true)]
    public partial class helloResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://java.racunarstvo/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string @return;
        
        public helloResponse() {
        }
        
        public helloResponse(string @return) {
            this.@return = @return;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://java.racunarstvo/")]
    public partial class student : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string imeField;
        
        private string prezimeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string ime {
            get {
                return this.imeField;
            }
            set {
                this.imeField = value;
                this.RaisePropertyChanged("ime");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string prezime {
            get {
                return this.prezimeField;
            }
            set {
                this.prezimeField = value;
                this.RaisePropertyChanged("prezime");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getStudentById", WrapperNamespace="http://java.racunarstvo/", IsWrapped=true)]
    public partial class getStudentByIdRequest {
        
        public getStudentByIdRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getStudentByIdResponse", WrapperNamespace="http://java.racunarstvo/", IsWrapped=true)]
    public partial class getStudentByIdResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://java.racunarstvo/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public IISVjezbe09Klijent.WSJava.student @return;
        
        public getStudentByIdResponse() {
        }
        
        public getStudentByIdResponse(IISVjezbe09Klijent.WSJava.student @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WSVjezbe09Channel : IISVjezbe09Klijent.WSJava.WSVjezbe09, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSVjezbe09Client : System.ServiceModel.ClientBase<IISVjezbe09Klijent.WSJava.WSVjezbe09>, IISVjezbe09Klijent.WSJava.WSVjezbe09 {
        
        public WSVjezbe09Client() {
        }
        
        public WSVjezbe09Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSVjezbe09Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSVjezbe09Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSVjezbe09Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        IISVjezbe09Klijent.WSJava.helloResponse IISVjezbe09Klijent.WSJava.WSVjezbe09.hello(IISVjezbe09Klijent.WSJava.helloRequest request) {
            return base.Channel.hello(request);
        }
        
        public string hello(string name) {
            IISVjezbe09Klijent.WSJava.helloRequest inValue = new IISVjezbe09Klijent.WSJava.helloRequest();
            inValue.name = name;
            IISVjezbe09Klijent.WSJava.helloResponse retVal = ((IISVjezbe09Klijent.WSJava.WSVjezbe09)(this)).hello(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<IISVjezbe09Klijent.WSJava.helloResponse> IISVjezbe09Klijent.WSJava.WSVjezbe09.helloAsync(IISVjezbe09Klijent.WSJava.helloRequest request) {
            return base.Channel.helloAsync(request);
        }
        
        public System.Threading.Tasks.Task<IISVjezbe09Klijent.WSJava.helloResponse> helloAsync(string name) {
            IISVjezbe09Klijent.WSJava.helloRequest inValue = new IISVjezbe09Klijent.WSJava.helloRequest();
            inValue.name = name;
            return ((IISVjezbe09Klijent.WSJava.WSVjezbe09)(this)).helloAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        IISVjezbe09Klijent.WSJava.getStudentByIdResponse IISVjezbe09Klijent.WSJava.WSVjezbe09.getStudentById(IISVjezbe09Klijent.WSJava.getStudentByIdRequest request) {
            return base.Channel.getStudentById(request);
        }
        
        public IISVjezbe09Klijent.WSJava.student getStudentById() {
            IISVjezbe09Klijent.WSJava.getStudentByIdRequest inValue = new IISVjezbe09Klijent.WSJava.getStudentByIdRequest();
            IISVjezbe09Klijent.WSJava.getStudentByIdResponse retVal = ((IISVjezbe09Klijent.WSJava.WSVjezbe09)(this)).getStudentById(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<IISVjezbe09Klijent.WSJava.getStudentByIdResponse> IISVjezbe09Klijent.WSJava.WSVjezbe09.getStudentByIdAsync(IISVjezbe09Klijent.WSJava.getStudentByIdRequest request) {
            return base.Channel.getStudentByIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<IISVjezbe09Klijent.WSJava.getStudentByIdResponse> getStudentByIdAsync() {
            IISVjezbe09Klijent.WSJava.getStudentByIdRequest inValue = new IISVjezbe09Klijent.WSJava.getStudentByIdRequest();
            return ((IISVjezbe09Klijent.WSJava.WSVjezbe09)(this)).getStudentByIdAsync(inValue);
        }
    }
}
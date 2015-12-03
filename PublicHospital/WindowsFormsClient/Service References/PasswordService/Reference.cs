﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsClient.PasswordService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PasswordFault", Namespace="http://schemas.datacontract.org/2004/07/ServiceLayer")]
    [System.SerializableAttribute()]
    public partial class PasswordFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FaultMessageField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FaultMessage {
            get {
                return this.FaultMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.FaultMessageField, value) != true)) {
                    this.FaultMessageField = value;
                    this.RaisePropertyChanged("FaultMessage");
                }
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PasswordService.IPasswordService")]
    public interface IPasswordService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPasswordService/authenticatePerson", ReplyAction="http://tempuri.org/IPasswordService/authenticatePersonResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WindowsFormsClient.PasswordService.PasswordFault), Action="http://tempuri.org/IPasswordService/authenticatePersonPasswordFaultFault", Name="PasswordFault", Namespace="http://schemas.datacontract.org/2004/07/ServiceLayer")]
        WindowsFormsClient.PasswordService.authenticatePersonResponse authenticatePerson(WindowsFormsClient.PasswordService.authenticatePersonRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPasswordService/authenticatePerson", ReplyAction="http://tempuri.org/IPasswordService/authenticatePersonResponse")]
        System.Threading.Tasks.Task<WindowsFormsClient.PasswordService.authenticatePersonResponse> authenticatePersonAsync(WindowsFormsClient.PasswordService.authenticatePersonRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="authenticatePerson", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class authenticatePersonRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string login;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string password;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string message;
        
        public authenticatePersonRequest() {
        }
        
        public authenticatePersonRequest(string login, string password, string message) {
            this.login = login;
            this.password = password;
            this.message = message;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="authenticatePersonResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class authenticatePersonResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string[] authenticatePersonResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string message;
        
        public authenticatePersonResponse() {
        }
        
        public authenticatePersonResponse(string[] authenticatePersonResult, string message) {
            this.authenticatePersonResult = authenticatePersonResult;
            this.message = message;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPasswordServiceChannel : WindowsFormsClient.PasswordService.IPasswordService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PasswordServiceClient : System.ServiceModel.ClientBase<WindowsFormsClient.PasswordService.IPasswordService>, WindowsFormsClient.PasswordService.IPasswordService {
        
        public PasswordServiceClient() {
        }
        
        public PasswordServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PasswordServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PasswordServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PasswordServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsClient.PasswordService.authenticatePersonResponse WindowsFormsClient.PasswordService.IPasswordService.authenticatePerson(WindowsFormsClient.PasswordService.authenticatePersonRequest request) {
            return base.Channel.authenticatePerson(request);
        }
        
        public string[] authenticatePerson(string login, string password, ref string message) {
            WindowsFormsClient.PasswordService.authenticatePersonRequest inValue = new WindowsFormsClient.PasswordService.authenticatePersonRequest();
            inValue.login = login;
            inValue.password = password;
            inValue.message = message;
            WindowsFormsClient.PasswordService.authenticatePersonResponse retVal = ((WindowsFormsClient.PasswordService.IPasswordService)(this)).authenticatePerson(inValue);
            message = retVal.message;
            return retVal.authenticatePersonResult;
        }
        
        public System.Threading.Tasks.Task<WindowsFormsClient.PasswordService.authenticatePersonResponse> authenticatePersonAsync(WindowsFormsClient.PasswordService.authenticatePersonRequest request) {
            return base.Channel.authenticatePersonAsync(request);
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsClient.PatientService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Patient", Namespace="http://schemas.datacontract.org/2004/07/ServiceLayer")]
    [System.SerializableAttribute()]
    public partial class Patient : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime dateOfBirthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string firstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string lastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string loginField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string passField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string phoneNrField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string streetField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int streetNrField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int zipField;
        
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
        public string city {
            get {
                return this.cityField;
            }
            set {
                if ((object.ReferenceEquals(this.cityField, value) != true)) {
                    this.cityField = value;
                    this.RaisePropertyChanged("city");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime dateOfBirth {
            get {
                return this.dateOfBirthField;
            }
            set {
                if ((this.dateOfBirthField.Equals(value) != true)) {
                    this.dateOfBirthField = value;
                    this.RaisePropertyChanged("dateOfBirth");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string firstName {
            get {
                return this.firstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.firstNameField, value) != true)) {
                    this.firstNameField = value;
                    this.RaisePropertyChanged("firstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string lastName {
            get {
                return this.lastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.lastNameField, value) != true)) {
                    this.lastNameField = value;
                    this.RaisePropertyChanged("lastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string login {
            get {
                return this.loginField;
            }
            set {
                if ((object.ReferenceEquals(this.loginField, value) != true)) {
                    this.loginField = value;
                    this.RaisePropertyChanged("login");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string pass {
            get {
                return this.passField;
            }
            set {
                if ((object.ReferenceEquals(this.passField, value) != true)) {
                    this.passField = value;
                    this.RaisePropertyChanged("pass");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string phoneNr {
            get {
                return this.phoneNrField;
            }
            set {
                if ((object.ReferenceEquals(this.phoneNrField, value) != true)) {
                    this.phoneNrField = value;
                    this.RaisePropertyChanged("phoneNr");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string street {
            get {
                return this.streetField;
            }
            set {
                if ((object.ReferenceEquals(this.streetField, value) != true)) {
                    this.streetField = value;
                    this.RaisePropertyChanged("street");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int streetNr {
            get {
                return this.streetNrField;
            }
            set {
                if ((this.streetNrField.Equals(value) != true)) {
                    this.streetNrField = value;
                    this.RaisePropertyChanged("streetNr");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int zip {
            get {
                return this.zipField;
            }
            set {
                if ((this.zipField.Equals(value) != true)) {
                    this.zipField = value;
                    this.RaisePropertyChanged("zip");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PatientFault", Namespace="http://schemas.datacontract.org/2004/07/ServiceLayer")]
    [System.SerializableAttribute()]
    public partial class PatientFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PatientService.IPatientService")]
    public interface IPatientService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPatientService/GetPatient", ReplyAction="http://tempuri.org/IPatientService/GetPatientResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WindowsFormsClient.PatientService.PatientFault), Action="http://tempuri.org/IPatientService/GetPatientPatientFaultFault", Name="PatientFault", Namespace="http://schemas.datacontract.org/2004/07/ServiceLayer")]
        WindowsFormsClient.PatientService.Patient GetPatient(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPatientService/GetPatient", ReplyAction="http://tempuri.org/IPatientService/GetPatientResponse")]
        System.Threading.Tasks.Task<WindowsFormsClient.PatientService.Patient> GetPatientAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPatientService/UpdatePatient", ReplyAction="http://tempuri.org/IPatientService/UpdatePatientResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WindowsFormsClient.PatientService.PatientFault), Action="http://tempuri.org/IPatientService/UpdatePatientPatientFaultFault", Name="PatientFault", Namespace="http://schemas.datacontract.org/2004/07/ServiceLayer")]
        WindowsFormsClient.PatientService.UpdatePatientResponse UpdatePatient(WindowsFormsClient.PatientService.UpdatePatientRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPatientService/UpdatePatient", ReplyAction="http://tempuri.org/IPatientService/UpdatePatientResponse")]
        System.Threading.Tasks.Task<WindowsFormsClient.PatientService.UpdatePatientResponse> UpdatePatientAsync(WindowsFormsClient.PatientService.UpdatePatientRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPatientService/GetAllpatients", ReplyAction="http://tempuri.org/IPatientService/GetAllpatientsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WindowsFormsClient.PatientService.PatientFault), Action="http://tempuri.org/IPatientService/GetAllpatientsPatientFaultFault", Name="PatientFault", Namespace="http://schemas.datacontract.org/2004/07/ServiceLayer")]
        System.Data.DataSet GetAllpatients();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPatientService/GetAllpatients", ReplyAction="http://tempuri.org/IPatientService/GetAllpatientsResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetAllpatientsAsync();
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdatePatient", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UpdatePatientRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsClient.PatientService.Patient Patient;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string message;
        
        public UpdatePatientRequest() {
        }
        
        public UpdatePatientRequest(WindowsFormsClient.PatientService.Patient Patient, string message) {
            this.Patient = Patient;
            this.message = message;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdatePatientResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UpdatePatientResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool UpdatePatientResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public WindowsFormsClient.PatientService.Patient Patient;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string message;
        
        public UpdatePatientResponse() {
        }
        
        public UpdatePatientResponse(bool UpdatePatientResult, WindowsFormsClient.PatientService.Patient Patient, string message) {
            this.UpdatePatientResult = UpdatePatientResult;
            this.Patient = Patient;
            this.message = message;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPatientServiceChannel : WindowsFormsClient.PatientService.IPatientService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PatientServiceClient : System.ServiceModel.ClientBase<WindowsFormsClient.PatientService.IPatientService>, WindowsFormsClient.PatientService.IPatientService {
        
        public PatientServiceClient() {
        }
        
        public PatientServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PatientServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PatientServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PatientServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WindowsFormsClient.PatientService.Patient GetPatient(int id) {
            return base.Channel.GetPatient(id);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsClient.PatientService.Patient> GetPatientAsync(int id) {
            return base.Channel.GetPatientAsync(id);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsClient.PatientService.UpdatePatientResponse WindowsFormsClient.PatientService.IPatientService.UpdatePatient(WindowsFormsClient.PatientService.UpdatePatientRequest request) {
            return base.Channel.UpdatePatient(request);
        }
        
        public bool UpdatePatient(ref WindowsFormsClient.PatientService.Patient Patient, ref string message) {
            WindowsFormsClient.PatientService.UpdatePatientRequest inValue = new WindowsFormsClient.PatientService.UpdatePatientRequest();
            inValue.Patient = Patient;
            inValue.message = message;
            WindowsFormsClient.PatientService.UpdatePatientResponse retVal = ((WindowsFormsClient.PatientService.IPatientService)(this)).UpdatePatient(inValue);
            Patient = retVal.Patient;
            message = retVal.message;
            return retVal.UpdatePatientResult;
        }
        
        public System.Threading.Tasks.Task<WindowsFormsClient.PatientService.UpdatePatientResponse> UpdatePatientAsync(WindowsFormsClient.PatientService.UpdatePatientRequest request) {
            return base.Channel.UpdatePatientAsync(request);
        }
        
        public System.Data.DataSet GetAllpatients() {
            return base.Channel.GetAllpatients();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetAllpatientsAsync() {
            return base.Channel.GetAllpatientsAsync();
        }
    }
}

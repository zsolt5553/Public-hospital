﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsClient.getDoctorTable {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Doctor", Namespace="http://schemas.datacontract.org/2004/07/ServiceLayer")]
    [System.SerializableAttribute()]
    public partial class Doctor : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descriptionField;
        
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
        private string specialtyField;
        
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
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.descriptionField, value) != true)) {
                    this.descriptionField = value;
                    this.RaisePropertyChanged("description");
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
        public string specialty {
            get {
                return this.specialtyField;
            }
            set {
                if ((object.ReferenceEquals(this.specialtyField, value) != true)) {
                    this.specialtyField = value;
                    this.RaisePropertyChanged("specialty");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DoctorFault", Namespace="http://schemas.datacontract.org/2004/07/ServiceLayer")]
    [System.SerializableAttribute()]
    public partial class DoctorFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="getDoctorTable.IDoctorService")]
    public interface IDoctorService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoctorService/GetDoctor", ReplyAction="http://tempuri.org/IDoctorService/GetDoctorResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WindowsFormsClient.getDoctorTable.DoctorFault), Action="http://tempuri.org/IDoctorService/GetDoctorDoctorFaultFault", Name="DoctorFault", Namespace="http://schemas.datacontract.org/2004/07/ServiceLayer")]
        WindowsFormsClient.getDoctorTable.Doctor GetDoctor(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoctorService/GetDoctor", ReplyAction="http://tempuri.org/IDoctorService/GetDoctorResponse")]
        System.Threading.Tasks.Task<WindowsFormsClient.getDoctorTable.Doctor> GetDoctorAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoctorService/GetAllDoctors", ReplyAction="http://tempuri.org/IDoctorService/GetAllDoctorsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WindowsFormsClient.getDoctorTable.DoctorFault), Action="http://tempuri.org/IDoctorService/GetAllDoctorsDoctorFaultFault", Name="DoctorFault", Namespace="http://schemas.datacontract.org/2004/07/ServiceLayer")]
        WindowsFormsClient.getDoctorTable.Doctor[] GetAllDoctors();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoctorService/GetAllDoctors", ReplyAction="http://tempuri.org/IDoctorService/GetAllDoctorsResponse")]
        System.Threading.Tasks.Task<WindowsFormsClient.getDoctorTable.Doctor[]> GetAllDoctorsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoctorService/GetDoctorTable", ReplyAction="http://tempuri.org/IDoctorService/GetDoctorTableResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WindowsFormsClient.getDoctorTable.DoctorFault), Action="http://tempuri.org/IDoctorService/GetDoctorTableDoctorFaultFault", Name="DoctorFault", Namespace="http://schemas.datacontract.org/2004/07/ServiceLayer")]
        System.Data.DataSet GetDoctorTable();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoctorService/GetDoctorTable", ReplyAction="http://tempuri.org/IDoctorService/GetDoctorTableResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetDoctorTableAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoctorService/SaveDoctor", ReplyAction="http://tempuri.org/IDoctorService/SaveDoctorResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WindowsFormsClient.getDoctorTable.DoctorFault), Action="http://tempuri.org/IDoctorService/SaveDoctorDoctorFaultFault", Name="DoctorFault", Namespace="http://schemas.datacontract.org/2004/07/ServiceLayer")]
        WindowsFormsClient.getDoctorTable.SaveDoctorResponse SaveDoctor(WindowsFormsClient.getDoctorTable.SaveDoctorRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoctorService/SaveDoctor", ReplyAction="http://tempuri.org/IDoctorService/SaveDoctorResponse")]
        System.Threading.Tasks.Task<WindowsFormsClient.getDoctorTable.SaveDoctorResponse> SaveDoctorAsync(WindowsFormsClient.getDoctorTable.SaveDoctorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoctorService/UpdateDoctor", ReplyAction="http://tempuri.org/IDoctorService/UpdateDoctorResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WindowsFormsClient.getDoctorTable.DoctorFault), Action="http://tempuri.org/IDoctorService/UpdateDoctorDoctorFaultFault", Name="DoctorFault", Namespace="http://schemas.datacontract.org/2004/07/ServiceLayer")]
        WindowsFormsClient.getDoctorTable.UpdateDoctorResponse UpdateDoctor(WindowsFormsClient.getDoctorTable.UpdateDoctorRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDoctorService/UpdateDoctor", ReplyAction="http://tempuri.org/IDoctorService/UpdateDoctorResponse")]
        System.Threading.Tasks.Task<WindowsFormsClient.getDoctorTable.UpdateDoctorResponse> UpdateDoctorAsync(WindowsFormsClient.getDoctorTable.UpdateDoctorRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SaveDoctor", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SaveDoctorRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsClient.getDoctorTable.Doctor doctor;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string message;
        
        public SaveDoctorRequest() {
        }
        
        public SaveDoctorRequest(WindowsFormsClient.getDoctorTable.Doctor doctor, string message) {
            this.doctor = doctor;
            this.message = message;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SaveDoctorResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SaveDoctorResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool SaveDoctorResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public WindowsFormsClient.getDoctorTable.Doctor doctor;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string message;
        
        public SaveDoctorResponse() {
        }
        
        public SaveDoctorResponse(bool SaveDoctorResult, WindowsFormsClient.getDoctorTable.Doctor doctor, string message) {
            this.SaveDoctorResult = SaveDoctorResult;
            this.doctor = doctor;
            this.message = message;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateDoctor", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UpdateDoctorRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsClient.getDoctorTable.Doctor doctor;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string message;
        
        public UpdateDoctorRequest() {
        }
        
        public UpdateDoctorRequest(WindowsFormsClient.getDoctorTable.Doctor doctor, string message) {
            this.doctor = doctor;
            this.message = message;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateDoctorResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UpdateDoctorResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool UpdateDoctorResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public WindowsFormsClient.getDoctorTable.Doctor doctor;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string message;
        
        public UpdateDoctorResponse() {
        }
        
        public UpdateDoctorResponse(bool UpdateDoctorResult, WindowsFormsClient.getDoctorTable.Doctor doctor, string message) {
            this.UpdateDoctorResult = UpdateDoctorResult;
            this.doctor = doctor;
            this.message = message;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDoctorServiceChannel : WindowsFormsClient.getDoctorTable.IDoctorService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DoctorServiceClient : System.ServiceModel.ClientBase<WindowsFormsClient.getDoctorTable.IDoctorService>, WindowsFormsClient.getDoctorTable.IDoctorService {
        
        public DoctorServiceClient() {
        }
        
        public DoctorServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DoctorServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DoctorServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DoctorServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WindowsFormsClient.getDoctorTable.Doctor GetDoctor(int id) {
            return base.Channel.GetDoctor(id);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsClient.getDoctorTable.Doctor> GetDoctorAsync(int id) {
            return base.Channel.GetDoctorAsync(id);
        }
        
        public WindowsFormsClient.getDoctorTable.Doctor[] GetAllDoctors() {
            return base.Channel.GetAllDoctors();
        }
        
        public System.Threading.Tasks.Task<WindowsFormsClient.getDoctorTable.Doctor[]> GetAllDoctorsAsync() {
            return base.Channel.GetAllDoctorsAsync();
        }
        
        public System.Data.DataSet GetDoctorTable() {
            return base.Channel.GetDoctorTable();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetDoctorTableAsync() {
            return base.Channel.GetDoctorTableAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsClient.getDoctorTable.SaveDoctorResponse WindowsFormsClient.getDoctorTable.IDoctorService.SaveDoctor(WindowsFormsClient.getDoctorTable.SaveDoctorRequest request) {
            return base.Channel.SaveDoctor(request);
        }
        
        public bool SaveDoctor(ref WindowsFormsClient.getDoctorTable.Doctor doctor, ref string message) {
            WindowsFormsClient.getDoctorTable.SaveDoctorRequest inValue = new WindowsFormsClient.getDoctorTable.SaveDoctorRequest();
            inValue.doctor = doctor;
            inValue.message = message;
            WindowsFormsClient.getDoctorTable.SaveDoctorResponse retVal = ((WindowsFormsClient.getDoctorTable.IDoctorService)(this)).SaveDoctor(inValue);
            doctor = retVal.doctor;
            message = retVal.message;
            return retVal.SaveDoctorResult;
        }
        
        public System.Threading.Tasks.Task<WindowsFormsClient.getDoctorTable.SaveDoctorResponse> SaveDoctorAsync(WindowsFormsClient.getDoctorTable.SaveDoctorRequest request) {
            return base.Channel.SaveDoctorAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsClient.getDoctorTable.UpdateDoctorResponse WindowsFormsClient.getDoctorTable.IDoctorService.UpdateDoctor(WindowsFormsClient.getDoctorTable.UpdateDoctorRequest request) {
            return base.Channel.UpdateDoctor(request);
        }
        
        public bool UpdateDoctor(ref WindowsFormsClient.getDoctorTable.Doctor doctor, ref string message) {
            WindowsFormsClient.getDoctorTable.UpdateDoctorRequest inValue = new WindowsFormsClient.getDoctorTable.UpdateDoctorRequest();
            inValue.doctor = doctor;
            inValue.message = message;
            WindowsFormsClient.getDoctorTable.UpdateDoctorResponse retVal = ((WindowsFormsClient.getDoctorTable.IDoctorService)(this)).UpdateDoctor(inValue);
            doctor = retVal.doctor;
            message = retVal.message;
            return retVal.UpdateDoctorResult;
        }
        
        public System.Threading.Tasks.Task<WindowsFormsClient.getDoctorTable.UpdateDoctorResponse> UpdateDoctorAsync(WindowsFormsClient.getDoctorTable.UpdateDoctorRequest request) {
            return base.Channel.UpdateDoctorAsync(request);
        }
    }
}

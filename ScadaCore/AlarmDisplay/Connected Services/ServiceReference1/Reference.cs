﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlarmDisplay.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Tag", Namespace="http://schemas.datacontract.org/2004/07/Models")]
    [System.SerializableAttribute()]
    public partial class Tag : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ioAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tagNameField;
        
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
        public string ioAddress {
            get {
                return this.ioAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.ioAddressField, value) != true)) {
                    this.ioAddressField = value;
                    this.RaisePropertyChanged("ioAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tagName {
            get {
                return this.tagNameField;
            }
            set {
                if ((object.ReferenceEquals(this.tagNameField, value) != true)) {
                    this.tagNameField = value;
                    this.RaisePropertyChanged("tagName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Alarm", Namespace="http://schemas.datacontract.org/2004/07/Models")]
    [System.SerializableAttribute()]
    public partial class Alarm : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string alarmIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double limitField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string priorityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tagIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double tagValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime timeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AlarmDisplay.ServiceReference1.TypeOfAlarm typeField;
        
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
        public string alarmId {
            get {
                return this.alarmIdField;
            }
            set {
                if ((object.ReferenceEquals(this.alarmIdField, value) != true)) {
                    this.alarmIdField = value;
                    this.RaisePropertyChanged("alarmId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double limit {
            get {
                return this.limitField;
            }
            set {
                if ((this.limitField.Equals(value) != true)) {
                    this.limitField = value;
                    this.RaisePropertyChanged("limit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string priority {
            get {
                return this.priorityField;
            }
            set {
                if ((object.ReferenceEquals(this.priorityField, value) != true)) {
                    this.priorityField = value;
                    this.RaisePropertyChanged("priority");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tagId {
            get {
                return this.tagIdField;
            }
            set {
                if ((object.ReferenceEquals(this.tagIdField, value) != true)) {
                    this.tagIdField = value;
                    this.RaisePropertyChanged("tagId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double tagValue {
            get {
                return this.tagValueField;
            }
            set {
                if ((this.tagValueField.Equals(value) != true)) {
                    this.tagValueField = value;
                    this.RaisePropertyChanged("tagValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime time {
            get {
                return this.timeField;
            }
            set {
                if ((this.timeField.Equals(value) != true)) {
                    this.timeField = value;
                    this.RaisePropertyChanged("time");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AlarmDisplay.ServiceReference1.TypeOfAlarm type {
            get {
                return this.typeField;
            }
            set {
                if ((this.typeField.Equals(value) != true)) {
                    this.typeField = value;
                    this.RaisePropertyChanged("type");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TypeOfAlarm", Namespace="http://schemas.datacontract.org/2004/07/Models")]
    public enum TypeOfAlarm : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        LOW = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        HIGH = 1,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IRTU")]
    public interface IRTU {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRTU/getAvailableAddresses", ReplyAction="http://tempuri.org/IRTU/getAvailableAddressesResponse")]
        string[] getAvailableAddresses();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRTU/getAvailableAddresses", ReplyAction="http://tempuri.org/IRTU/getAvailableAddressesResponse")]
        System.Threading.Tasks.Task<string[]> getAvailableAddressesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRTU/sendToService", ReplyAction="http://tempuri.org/IRTU/sendToServiceResponse")]
        void sendToService(string address, double value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRTU/sendToService", ReplyAction="http://tempuri.org/IRTU/sendToServiceResponse")]
        System.Threading.Tasks.Task sendToServiceAsync(string address, double value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRTU/addAddress", ReplyAction="http://tempuri.org/IRTU/addAddressResponse")]
        bool addAddress(string address);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRTU/addAddress", ReplyAction="http://tempuri.org/IRTU/addAddressResponse")]
        System.Threading.Tasks.Task<bool> addAddressAsync(string address);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRTUChannel : AlarmDisplay.ServiceReference1.IRTU, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RTUClient : System.ServiceModel.ClientBase<AlarmDisplay.ServiceReference1.IRTU>, AlarmDisplay.ServiceReference1.IRTU {
        
        public RTUClient() {
        }
        
        public RTUClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RTUClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RTUClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RTUClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] getAvailableAddresses() {
            return base.Channel.getAvailableAddresses();
        }
        
        public System.Threading.Tasks.Task<string[]> getAvailableAddressesAsync() {
            return base.Channel.getAvailableAddressesAsync();
        }
        
        public void sendToService(string address, double value) {
            base.Channel.sendToService(address, value);
        }
        
        public System.Threading.Tasks.Task sendToServiceAsync(string address, double value) {
            return base.Channel.sendToServiceAsync(address, value);
        }
        
        public bool addAddress(string address) {
            return base.Channel.addAddress(address);
        }
        
        public System.Threading.Tasks.Task<bool> addAddressAsync(string address) {
            return base.Channel.addAddressAsync(address);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IDbManager")]
    public interface IDbManager {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDbManager/DoWork", ReplyAction="http://tempuri.org/IDbManager/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDbManager/DoWork", ReplyAction="http://tempuri.org/IDbManager/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDbManager/AddTag", ReplyAction="http://tempuri.org/IDbManager/AddTagResponse")]
        void AddTag(AlarmDisplay.ServiceReference1.Tag tag);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDbManager/AddTag", ReplyAction="http://tempuri.org/IDbManager/AddTagResponse")]
        System.Threading.Tasks.Task AddTagAsync(AlarmDisplay.ServiceReference1.Tag tag);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDbManagerChannel : AlarmDisplay.ServiceReference1.IDbManager, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DbManagerClient : System.ServiceModel.ClientBase<AlarmDisplay.ServiceReference1.IDbManager>, AlarmDisplay.ServiceReference1.IDbManager {
        
        public DbManagerClient() {
        }
        
        public DbManagerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DbManagerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DbManagerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DbManagerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        public void AddTag(AlarmDisplay.ServiceReference1.Tag tag) {
            base.Channel.AddTag(tag);
        }
        
        public System.Threading.Tasks.Task AddTagAsync(AlarmDisplay.ServiceReference1.Tag tag) {
            return base.Channel.AddTagAsync(tag);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IAlarmDisplay", CallbackContract=typeof(AlarmDisplay.ServiceReference1.IAlarmDisplayCallback))]
    public interface IAlarmDisplay {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlarmDisplay/initializationAlarmDisplay", ReplyAction="http://tempuri.org/IAlarmDisplay/initializationAlarmDisplayResponse")]
        void initializationAlarmDisplay();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlarmDisplay/initializationAlarmDisplay", ReplyAction="http://tempuri.org/IAlarmDisplay/initializationAlarmDisplayResponse")]
        System.Threading.Tasks.Task initializationAlarmDisplayAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAlarmDisplayCallback {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlarmDisplay/showAlarmDisplay", ReplyAction="http://tempuri.org/IAlarmDisplay/showAlarmDisplayResponse")]
        void showAlarmDisplay(AlarmDisplay.ServiceReference1.Alarm alarm);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAlarmDisplayChannel : AlarmDisplay.ServiceReference1.IAlarmDisplay, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AlarmDisplayClient : System.ServiceModel.DuplexClientBase<AlarmDisplay.ServiceReference1.IAlarmDisplay>, AlarmDisplay.ServiceReference1.IAlarmDisplay {
        
        public AlarmDisplayClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public AlarmDisplayClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public AlarmDisplayClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public AlarmDisplayClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public AlarmDisplayClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void initializationAlarmDisplay() {
            base.Channel.initializationAlarmDisplay();
        }
        
        public System.Threading.Tasks.Task initializationAlarmDisplayAsync() {
            return base.Channel.initializationAlarmDisplayAsync();
        }
    }
}

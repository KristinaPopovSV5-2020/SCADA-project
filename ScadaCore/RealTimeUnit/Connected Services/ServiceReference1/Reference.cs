﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RealTimeUnit.ServiceReference1 {
    
    
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
    public interface IRTUChannel : RealTimeUnit.ServiceReference1.IRTU, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RTUClient : System.ServiceModel.ClientBase<RealTimeUnit.ServiceReference1.IRTU>, RealTimeUnit.ServiceReference1.IRTU {
        
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
        void AddTag(Models.Tag tag);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDbManager/AddTag", ReplyAction="http://tempuri.org/IDbManager/AddTagResponse")]
        System.Threading.Tasks.Task AddTagAsync(Models.Tag tag);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDbManagerChannel : RealTimeUnit.ServiceReference1.IDbManager, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DbManagerClient : System.ServiceModel.ClientBase<RealTimeUnit.ServiceReference1.IDbManager>, RealTimeUnit.ServiceReference1.IDbManager {
        
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
        
        public void AddTag(Models.Tag tag) {
            base.Channel.AddTag(tag);
        }
        
        public System.Threading.Tasks.Task AddTagAsync(Models.Tag tag) {
            return base.Channel.AddTagAsync(tag);
        }
    }
}

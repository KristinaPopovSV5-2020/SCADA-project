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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDbManager/AddTag", ReplyAction="http://tempuri.org/IDbManager/AddTagResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Models.InputTag))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Models.DigitalInput))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Models.AnalogInput))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Models.OutputTag))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Models.DigitalOutput))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Models.AnalogOutput))]
        bool AddTag(Models.Tag tag, bool realTimeOn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDbManager/AddTag", ReplyAction="http://tempuri.org/IDbManager/AddTagResponse")]
        System.Threading.Tasks.Task<bool> AddTagAsync(Models.Tag tag, bool realTimeOn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDbManager/GetOutputTags", ReplyAction="http://tempuri.org/IDbManager/GetOutputTagsResponse")]
        Models.Tag[] GetOutputTags();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDbManager/GetOutputTags", ReplyAction="http://tempuri.org/IDbManager/GetOutputTagsResponse")]
        System.Threading.Tasks.Task<Models.Tag[]> GetOutputTagsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDbManager/GetAllUsers", ReplyAction="http://tempuri.org/IDbManager/GetAllUsersResponse")]
        Models.User[] GetAllUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDbManager/GetAllUsers", ReplyAction="http://tempuri.org/IDbManager/GetAllUsersResponse")]
        System.Threading.Tasks.Task<Models.User[]> GetAllUsersAsync();
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
        
        public bool AddTag(Models.Tag tag, bool realTimeOn) {
            return base.Channel.AddTag(tag, realTimeOn);
        }
        
        public System.Threading.Tasks.Task<bool> AddTagAsync(Models.Tag tag, bool realTimeOn) {
            return base.Channel.AddTagAsync(tag, realTimeOn);
        }
        
        public Models.Tag[] GetOutputTags() {
            return base.Channel.GetOutputTags();
        }
        
        public System.Threading.Tasks.Task<Models.Tag[]> GetOutputTagsAsync() {
            return base.Channel.GetOutputTagsAsync();
        }
        
        public Models.User[] GetAllUsers() {
            return base.Channel.GetAllUsers();
        }
        
        public System.Threading.Tasks.Task<Models.User[]> GetAllUsersAsync() {
            return base.Channel.GetAllUsersAsync();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IAlarmDisplay", CallbackContract=typeof(RealTimeUnit.ServiceReference1.IAlarmDisplayCallback))]
    public interface IAlarmDisplay {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlarmDisplay/initializationAlarmDisplay", ReplyAction="http://tempuri.org/IAlarmDisplay/initializationAlarmDisplayResponse")]
        void initializationAlarmDisplay();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlarmDisplay/initializationAlarmDisplay", ReplyAction="http://tempuri.org/IAlarmDisplay/initializationAlarmDisplayResponse")]
        System.Threading.Tasks.Task initializationAlarmDisplayAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAlarmDisplayCallback {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlarmDisplay/showAlarmDisplay", ReplyAction="http://tempuri.org/IAlarmDisplay/showAlarmDisplayResponse")]
        void showAlarmDisplay(Models.Alarm alarm);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAlarmDisplayChannel : RealTimeUnit.ServiceReference1.IAlarmDisplay, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AlarmDisplayClient : System.ServiceModel.DuplexClientBase<RealTimeUnit.ServiceReference1.IAlarmDisplay>, RealTimeUnit.ServiceReference1.IAlarmDisplay {
        
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ITrending", CallbackContract=typeof(RealTimeUnit.ServiceReference1.ITrendingCallback))]
    public interface ITrending {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITrending/initTrending", ReplyAction="http://tempuri.org/ITrending/initTrendingResponse")]
        void initTrending();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITrending/initTrending", ReplyAction="http://tempuri.org/ITrending/initTrendingResponse")]
        System.Threading.Tasks.Task initTrendingAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITrendingCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ITrending/addTagValue")]
        void addTagValue(string tagName, double value);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITrendingChannel : RealTimeUnit.ServiceReference1.ITrending, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TrendingClient : System.ServiceModel.DuplexClientBase<RealTimeUnit.ServiceReference1.ITrending>, RealTimeUnit.ServiceReference1.ITrending {
        
        public TrendingClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public TrendingClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public TrendingClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public TrendingClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public TrendingClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void initTrending() {
            base.Channel.initTrending();
        }
        
        public System.Threading.Tasks.Task initTrendingAsync() {
            return base.Channel.initTrendingAsync();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IReportManager")]
    public interface IReportManager {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReportManager/alarmsSpecifiedTimePeriodSortByPriority", ReplyAction="http://tempuri.org/IReportManager/alarmsSpecifiedTimePeriodSortByPriorityResponse" +
            "")]
        Models.Alarm[] alarmsSpecifiedTimePeriodSortByPriority(System.DateTime start, System.DateTime end);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReportManager/alarmsSpecifiedTimePeriodSortByPriority", ReplyAction="http://tempuri.org/IReportManager/alarmsSpecifiedTimePeriodSortByPriorityResponse" +
            "")]
        System.Threading.Tasks.Task<Models.Alarm[]> alarmsSpecifiedTimePeriodSortByPriorityAsync(System.DateTime start, System.DateTime end);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReportManager/alarmsSpecifiedTimePeriodSortByTime", ReplyAction="http://tempuri.org/IReportManager/alarmsSpecifiedTimePeriodSortByTimeResponse")]
        Models.Alarm[] alarmsSpecifiedTimePeriodSortByTime(System.DateTime start, System.DateTime end);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReportManager/alarmsSpecifiedTimePeriodSortByTime", ReplyAction="http://tempuri.org/IReportManager/alarmsSpecifiedTimePeriodSortByTimeResponse")]
        System.Threading.Tasks.Task<Models.Alarm[]> alarmsSpecifiedTimePeriodSortByTimeAsync(System.DateTime start, System.DateTime end);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReportManager/alarmsSpecifiedPrioritySortByTime", ReplyAction="http://tempuri.org/IReportManager/alarmsSpecifiedPrioritySortByTimeResponse")]
        Models.Alarm[] alarmsSpecifiedPrioritySortByTime(string priority);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReportManager/alarmsSpecifiedPrioritySortByTime", ReplyAction="http://tempuri.org/IReportManager/alarmsSpecifiedPrioritySortByTimeResponse")]
        System.Threading.Tasks.Task<Models.Alarm[]> alarmsSpecifiedPrioritySortByTimeAsync(string priority);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReportManager/tagsSpecifiedTimePeriodSortByTime", ReplyAction="http://tempuri.org/IReportManager/tagsSpecifiedTimePeriodSortByTimeResponse")]
        Models.Log[] tagsSpecifiedTimePeriodSortByTime(System.DateTime start, System.DateTime end);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReportManager/tagsSpecifiedTimePeriodSortByTime", ReplyAction="http://tempuri.org/IReportManager/tagsSpecifiedTimePeriodSortByTimeResponse")]
        System.Threading.Tasks.Task<Models.Log[]> tagsSpecifiedTimePeriodSortByTimeAsync(System.DateTime start, System.DateTime end);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReportManager/lastValueOfAITagsSortByTime", ReplyAction="http://tempuri.org/IReportManager/lastValueOfAITagsSortByTimeResponse")]
        Models.Tag[] lastValueOfAITagsSortByTime();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReportManager/lastValueOfAITagsSortByTime", ReplyAction="http://tempuri.org/IReportManager/lastValueOfAITagsSortByTimeResponse")]
        System.Threading.Tasks.Task<Models.Tag[]> lastValueOfAITagsSortByTimeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReportManager/lastValueOfDITagsSortByTime", ReplyAction="http://tempuri.org/IReportManager/lastValueOfDITagsSortByTimeResponse")]
        Models.Tag[] lastValueOfDITagsSortByTime();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReportManager/lastValueOfDITagsSortByTime", ReplyAction="http://tempuri.org/IReportManager/lastValueOfDITagsSortByTimeResponse")]
        System.Threading.Tasks.Task<Models.Tag[]> lastValueOfDITagsSortByTimeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReportManager/tagValuesSpecificIdSortByValue", ReplyAction="http://tempuri.org/IReportManager/tagValuesSpecificIdSortByValueResponse")]
        Models.Tag[] tagValuesSpecificIdSortByValue(string tagId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReportManager/tagValuesSpecificIdSortByValue", ReplyAction="http://tempuri.org/IReportManager/tagValuesSpecificIdSortByValueResponse")]
        System.Threading.Tasks.Task<Models.Tag[]> tagValuesSpecificIdSortByValueAsync(string tagId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IReportManagerChannel : RealTimeUnit.ServiceReference1.IReportManager, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ReportManagerClient : System.ServiceModel.ClientBase<RealTimeUnit.ServiceReference1.IReportManager>, RealTimeUnit.ServiceReference1.IReportManager {
        
        public ReportManagerClient() {
        }
        
        public ReportManagerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ReportManagerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReportManagerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReportManagerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Models.Alarm[] alarmsSpecifiedTimePeriodSortByPriority(System.DateTime start, System.DateTime end) {
            return base.Channel.alarmsSpecifiedTimePeriodSortByPriority(start, end);
        }
        
        public System.Threading.Tasks.Task<Models.Alarm[]> alarmsSpecifiedTimePeriodSortByPriorityAsync(System.DateTime start, System.DateTime end) {
            return base.Channel.alarmsSpecifiedTimePeriodSortByPriorityAsync(start, end);
        }
        
        public Models.Alarm[] alarmsSpecifiedTimePeriodSortByTime(System.DateTime start, System.DateTime end) {
            return base.Channel.alarmsSpecifiedTimePeriodSortByTime(start, end);
        }
        
        public System.Threading.Tasks.Task<Models.Alarm[]> alarmsSpecifiedTimePeriodSortByTimeAsync(System.DateTime start, System.DateTime end) {
            return base.Channel.alarmsSpecifiedTimePeriodSortByTimeAsync(start, end);
        }
        
        public Models.Alarm[] alarmsSpecifiedPrioritySortByTime(string priority) {
            return base.Channel.alarmsSpecifiedPrioritySortByTime(priority);
        }
        
        public System.Threading.Tasks.Task<Models.Alarm[]> alarmsSpecifiedPrioritySortByTimeAsync(string priority) {
            return base.Channel.alarmsSpecifiedPrioritySortByTimeAsync(priority);
        }
        
        public Models.Log[] tagsSpecifiedTimePeriodSortByTime(System.DateTime start, System.DateTime end) {
            return base.Channel.tagsSpecifiedTimePeriodSortByTime(start, end);
        }
        
        public System.Threading.Tasks.Task<Models.Log[]> tagsSpecifiedTimePeriodSortByTimeAsync(System.DateTime start, System.DateTime end) {
            return base.Channel.tagsSpecifiedTimePeriodSortByTimeAsync(start, end);
        }
        
        public Models.Tag[] lastValueOfAITagsSortByTime() {
            return base.Channel.lastValueOfAITagsSortByTime();
        }
        
        public System.Threading.Tasks.Task<Models.Tag[]> lastValueOfAITagsSortByTimeAsync() {
            return base.Channel.lastValueOfAITagsSortByTimeAsync();
        }
        
        public Models.Tag[] lastValueOfDITagsSortByTime() {
            return base.Channel.lastValueOfDITagsSortByTime();
        }
        
        public System.Threading.Tasks.Task<Models.Tag[]> lastValueOfDITagsSortByTimeAsync() {
            return base.Channel.lastValueOfDITagsSortByTimeAsync();
        }
        
        public Models.Tag[] tagValuesSpecificIdSortByValue(string tagId) {
            return base.Channel.tagValuesSpecificIdSortByValue(tagId);
        }
        
        public System.Threading.Tasks.Task<Models.Tag[]> tagValuesSpecificIdSortByValueAsync(string tagId) {
            return base.Channel.tagValuesSpecificIdSortByValueAsync(tagId);
        }
    }
}

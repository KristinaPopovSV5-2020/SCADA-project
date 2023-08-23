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
        System.Collections.Generic.List<string> getAvailableAddresses();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRTU/getAvailableAddresses", ReplyAction="http://tempuri.org/IRTU/getAvailableAddressesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<string>> getAvailableAddressesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRTU/sendToService", ReplyAction="http://tempuri.org/IRTU/sendToServiceResponse")]
        void sendToService(string address, double value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRTU/sendToService", ReplyAction="http://tempuri.org/IRTU/sendToServiceResponse")]
        System.Threading.Tasks.Task sendToServiceAsync(string address, double value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRTU/addAddress", ReplyAction="http://tempuri.org/IRTU/addAddressResponse")]
        bool addAddress(string address);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRTU/addAddress", ReplyAction="http://tempuri.org/IRTU/addAddressResponse")]
        System.Threading.Tasks.Task<bool> addAddressAsync(string address);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRTU/GetTagForAddress", ReplyAction="http://tempuri.org/IRTU/GetTagForAddressResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Models.InputTag))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Models.DigitalInput))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Models.AnalogInput))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Models.OutputTag))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Models.DigitalOutput))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Models.AnalogOutput))]
        Models.Tag GetTagForAddress(string address);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRTU/GetTagForAddress", ReplyAction="http://tempuri.org/IRTU/GetTagForAddressResponse")]
        System.Threading.Tasks.Task<Models.Tag> GetTagForAddressAsync(string address);
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
        
        public System.Collections.Generic.List<string> getAvailableAddresses() {
            return base.Channel.getAvailableAddresses();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<string>> getAvailableAddressesAsync() {
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
        
        public Models.Tag GetTagForAddress(string address) {
            return base.Channel.GetTagForAddress(address);
        }
        
        public System.Threading.Tasks.Task<Models.Tag> GetTagForAddressAsync(string address) {
            return base.Channel.GetTagForAddressAsync(address);
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDbManager/Register", ReplyAction="http://tempuri.org/IDbManager/RegisterResponse")]
        bool Register(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDbManager/Register", ReplyAction="http://tempuri.org/IDbManager/RegisterResponse")]
        System.Threading.Tasks.Task<bool> RegisterAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDbManager/GetAnalogOutputTags", ReplyAction="http://tempuri.org/IDbManager/GetAnalogOutputTagsResponse")]
        System.Collections.Generic.List<Models.AnalogOutput> GetAnalogOutputTags();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDbManager/GetAnalogOutputTags", ReplyAction="http://tempuri.org/IDbManager/GetAnalogOutputTagsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Models.AnalogOutput>> GetAnalogOutputTagsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDbManager/GetAnalogInputTags", ReplyAction="http://tempuri.org/IDbManager/GetAnalogInputTagsResponse")]
        System.Collections.Generic.List<Models.AnalogInput> GetAnalogInputTags();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDbManager/GetAnalogInputTags", ReplyAction="http://tempuri.org/IDbManager/GetAnalogInputTagsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Models.AnalogInput>> GetAnalogInputTagsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDbManager/GetDigitalInputTags", ReplyAction="http://tempuri.org/IDbManager/GetDigitalInputTagsResponse")]
        System.Collections.Generic.List<Models.DigitalInput> GetDigitalInputTags();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDbManager/GetDigitalInputTags", ReplyAction="http://tempuri.org/IDbManager/GetDigitalInputTagsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Models.DigitalInput>> GetDigitalInputTagsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDbManager/GetDigitalOutputTags", ReplyAction="http://tempuri.org/IDbManager/GetDigitalOutputTagsResponse")]
        System.Collections.Generic.List<Models.DigitalOutput> GetDigitalOutputTags();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDbManager/GetDigitalOutputTags", ReplyAction="http://tempuri.org/IDbManager/GetDigitalOutputTagsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Models.DigitalOutput>> GetDigitalOutputTagsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDbManager/DeleteTag", ReplyAction="http://tempuri.org/IDbManager/DeleteTagResponse")]
        void DeleteTag(string tagId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDbManager/DeleteTag", ReplyAction="http://tempuri.org/IDbManager/DeleteTagResponse")]
        System.Threading.Tasks.Task DeleteTagAsync(string tagId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDbManager/OnOffScan", ReplyAction="http://tempuri.org/IDbManager/OnOffScanResponse")]
        void OnOffScan(string tagId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDbManager/OnOffScan", ReplyAction="http://tempuri.org/IDbManager/OnOffScanResponse")]
        System.Threading.Tasks.Task OnOffScanAsync(string tagId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDbManager/UpdateValue", ReplyAction="http://tempuri.org/IDbManager/UpdateValueResponse")]
        void UpdateValue(string tagId, double value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDbManager/UpdateValue", ReplyAction="http://tempuri.org/IDbManager/UpdateValueResponse")]
        System.Threading.Tasks.Task UpdateValueAsync(string tagId, double value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDbManager/newAlarm", ReplyAction="http://tempuri.org/IDbManager/newAlarmResponse")]
        void newAlarm(Models.Alarm alarm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDbManager/newAlarm", ReplyAction="http://tempuri.org/IDbManager/newAlarmResponse")]
        System.Threading.Tasks.Task newAlarmAsync(Models.Alarm alarm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDbManager/deleteAlarm", ReplyAction="http://tempuri.org/IDbManager/deleteAlarmResponse")]
        void deleteAlarm(string alarmId, string tagId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDbManager/deleteAlarm", ReplyAction="http://tempuri.org/IDbManager/deleteAlarmResponse")]
        System.Threading.Tasks.Task deleteAlarmAsync(string alarmId, string tagId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDbManager/findAlarm", ReplyAction="http://tempuri.org/IDbManager/findAlarmResponse")]
        System.Collections.Generic.List<Models.Alarm> findAlarm(string tagId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDbManager/findAlarm", ReplyAction="http://tempuri.org/IDbManager/findAlarmResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Models.Alarm>> findAlarmAsync(string tagId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDbManager/GetAllUsers", ReplyAction="http://tempuri.org/IDbManager/GetAllUsersResponse")]
        System.Collections.Generic.List<Models.User> GetAllUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDbManager/GetAllUsers", ReplyAction="http://tempuri.org/IDbManager/GetAllUsersResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Models.User>> GetAllUsersAsync();
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
        
        public bool Register(string username, string password) {
            return base.Channel.Register(username, password);
        }
        
        public System.Threading.Tasks.Task<bool> RegisterAsync(string username, string password) {
            return base.Channel.RegisterAsync(username, password);
        }
        
        public System.Collections.Generic.List<Models.AnalogOutput> GetAnalogOutputTags() {
            return base.Channel.GetAnalogOutputTags();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Models.AnalogOutput>> GetAnalogOutputTagsAsync() {
            return base.Channel.GetAnalogOutputTagsAsync();
        }
        
        public System.Collections.Generic.List<Models.AnalogInput> GetAnalogInputTags() {
            return base.Channel.GetAnalogInputTags();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Models.AnalogInput>> GetAnalogInputTagsAsync() {
            return base.Channel.GetAnalogInputTagsAsync();
        }
        
        public System.Collections.Generic.List<Models.DigitalInput> GetDigitalInputTags() {
            return base.Channel.GetDigitalInputTags();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Models.DigitalInput>> GetDigitalInputTagsAsync() {
            return base.Channel.GetDigitalInputTagsAsync();
        }
        
        public System.Collections.Generic.List<Models.DigitalOutput> GetDigitalOutputTags() {
            return base.Channel.GetDigitalOutputTags();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Models.DigitalOutput>> GetDigitalOutputTagsAsync() {
            return base.Channel.GetDigitalOutputTagsAsync();
        }
        
        public void DeleteTag(string tagId) {
            base.Channel.DeleteTag(tagId);
        }
        
        public System.Threading.Tasks.Task DeleteTagAsync(string tagId) {
            return base.Channel.DeleteTagAsync(tagId);
        }
        
        public void OnOffScan(string tagId) {
            base.Channel.OnOffScan(tagId);
        }
        
        public System.Threading.Tasks.Task OnOffScanAsync(string tagId) {
            return base.Channel.OnOffScanAsync(tagId);
        }
        
        public void UpdateValue(string tagId, double value) {
            base.Channel.UpdateValue(tagId, value);
        }
        
        public System.Threading.Tasks.Task UpdateValueAsync(string tagId, double value) {
            return base.Channel.UpdateValueAsync(tagId, value);
        }
        
        public void newAlarm(Models.Alarm alarm) {
            base.Channel.newAlarm(alarm);
        }
        
        public System.Threading.Tasks.Task newAlarmAsync(Models.Alarm alarm) {
            return base.Channel.newAlarmAsync(alarm);
        }
        
        public void deleteAlarm(string alarmId, string tagId) {
            base.Channel.deleteAlarm(alarmId, tagId);
        }
        
        public System.Threading.Tasks.Task deleteAlarmAsync(string alarmId, string tagId) {
            return base.Channel.deleteAlarmAsync(alarmId, tagId);
        }
        
        public System.Collections.Generic.List<Models.Alarm> findAlarm(string tagId) {
            return base.Channel.findAlarm(tagId);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Models.Alarm>> findAlarmAsync(string tagId) {
            return base.Channel.findAlarmAsync(tagId);
        }
        
        public System.Collections.Generic.List<Models.User> GetAllUsers() {
            return base.Channel.GetAllUsers();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Models.User>> GetAllUsersAsync() {
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
        System.Collections.Generic.List<Models.Alarm> alarmsSpecifiedTimePeriodSortByPriority(System.DateTime start, System.DateTime end);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReportManager/alarmsSpecifiedTimePeriodSortByPriority", ReplyAction="http://tempuri.org/IReportManager/alarmsSpecifiedTimePeriodSortByPriorityResponse" +
            "")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Models.Alarm>> alarmsSpecifiedTimePeriodSortByPriorityAsync(System.DateTime start, System.DateTime end);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReportManager/alarmsSpecifiedTimePeriodSortByTime", ReplyAction="http://tempuri.org/IReportManager/alarmsSpecifiedTimePeriodSortByTimeResponse")]
        System.Collections.Generic.List<Models.Alarm> alarmsSpecifiedTimePeriodSortByTime(System.DateTime start, System.DateTime end);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReportManager/alarmsSpecifiedTimePeriodSortByTime", ReplyAction="http://tempuri.org/IReportManager/alarmsSpecifiedTimePeriodSortByTimeResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Models.Alarm>> alarmsSpecifiedTimePeriodSortByTimeAsync(System.DateTime start, System.DateTime end);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReportManager/alarmsSpecifiedPrioritySortByTime", ReplyAction="http://tempuri.org/IReportManager/alarmsSpecifiedPrioritySortByTimeResponse")]
        System.Collections.Generic.List<Models.Alarm> alarmsSpecifiedPrioritySortByTime(string priority);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReportManager/alarmsSpecifiedPrioritySortByTime", ReplyAction="http://tempuri.org/IReportManager/alarmsSpecifiedPrioritySortByTimeResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Models.Alarm>> alarmsSpecifiedPrioritySortByTimeAsync(string priority);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReportManager/tagsSpecifiedTimePeriodSortByTime", ReplyAction="http://tempuri.org/IReportManager/tagsSpecifiedTimePeriodSortByTimeResponse")]
        System.Collections.Generic.List<Models.Log> tagsSpecifiedTimePeriodSortByTime(System.DateTime start, System.DateTime end);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReportManager/tagsSpecifiedTimePeriodSortByTime", ReplyAction="http://tempuri.org/IReportManager/tagsSpecifiedTimePeriodSortByTimeResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Models.Log>> tagsSpecifiedTimePeriodSortByTimeAsync(System.DateTime start, System.DateTime end);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReportManager/lastValueOfAITagsSortByTime", ReplyAction="http://tempuri.org/IReportManager/lastValueOfAITagsSortByTimeResponse")]
        System.Collections.Generic.List<Models.Log> lastValueOfAITagsSortByTime();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReportManager/lastValueOfAITagsSortByTime", ReplyAction="http://tempuri.org/IReportManager/lastValueOfAITagsSortByTimeResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Models.Log>> lastValueOfAITagsSortByTimeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReportManager/lastValueOfDITagsSortByTime", ReplyAction="http://tempuri.org/IReportManager/lastValueOfDITagsSortByTimeResponse")]
        System.Collections.Generic.List<Models.Log> lastValueOfDITagsSortByTime();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReportManager/lastValueOfDITagsSortByTime", ReplyAction="http://tempuri.org/IReportManager/lastValueOfDITagsSortByTimeResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Models.Log>> lastValueOfDITagsSortByTimeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReportManager/tagValuesSpecificIdSortByValue", ReplyAction="http://tempuri.org/IReportManager/tagValuesSpecificIdSortByValueResponse")]
        System.Collections.Generic.List<Models.Log> tagValuesSpecificIdSortByValue(string tagId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReportManager/tagValuesSpecificIdSortByValue", ReplyAction="http://tempuri.org/IReportManager/tagValuesSpecificIdSortByValueResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Models.Log>> tagValuesSpecificIdSortByValueAsync(string tagId);
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
        
        public System.Collections.Generic.List<Models.Alarm> alarmsSpecifiedTimePeriodSortByPriority(System.DateTime start, System.DateTime end) {
            return base.Channel.alarmsSpecifiedTimePeriodSortByPriority(start, end);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Models.Alarm>> alarmsSpecifiedTimePeriodSortByPriorityAsync(System.DateTime start, System.DateTime end) {
            return base.Channel.alarmsSpecifiedTimePeriodSortByPriorityAsync(start, end);
        }
        
        public System.Collections.Generic.List<Models.Alarm> alarmsSpecifiedTimePeriodSortByTime(System.DateTime start, System.DateTime end) {
            return base.Channel.alarmsSpecifiedTimePeriodSortByTime(start, end);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Models.Alarm>> alarmsSpecifiedTimePeriodSortByTimeAsync(System.DateTime start, System.DateTime end) {
            return base.Channel.alarmsSpecifiedTimePeriodSortByTimeAsync(start, end);
        }
        
        public System.Collections.Generic.List<Models.Alarm> alarmsSpecifiedPrioritySortByTime(string priority) {
            return base.Channel.alarmsSpecifiedPrioritySortByTime(priority);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Models.Alarm>> alarmsSpecifiedPrioritySortByTimeAsync(string priority) {
            return base.Channel.alarmsSpecifiedPrioritySortByTimeAsync(priority);
        }
        
        public System.Collections.Generic.List<Models.Log> tagsSpecifiedTimePeriodSortByTime(System.DateTime start, System.DateTime end) {
            return base.Channel.tagsSpecifiedTimePeriodSortByTime(start, end);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Models.Log>> tagsSpecifiedTimePeriodSortByTimeAsync(System.DateTime start, System.DateTime end) {
            return base.Channel.tagsSpecifiedTimePeriodSortByTimeAsync(start, end);
        }
        
        public System.Collections.Generic.List<Models.Log> lastValueOfAITagsSortByTime() {
            return base.Channel.lastValueOfAITagsSortByTime();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Models.Log>> lastValueOfAITagsSortByTimeAsync() {
            return base.Channel.lastValueOfAITagsSortByTimeAsync();
        }
        
        public System.Collections.Generic.List<Models.Log> lastValueOfDITagsSortByTime() {
            return base.Channel.lastValueOfDITagsSortByTime();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Models.Log>> lastValueOfDITagsSortByTimeAsync() {
            return base.Channel.lastValueOfDITagsSortByTimeAsync();
        }
        
        public System.Collections.Generic.List<Models.Log> tagValuesSpecificIdSortByValue(string tagId) {
            return base.Channel.tagValuesSpecificIdSortByValue(tagId);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Models.Log>> tagValuesSpecificIdSortByValueAsync(string tagId) {
            return base.Channel.tagValuesSpecificIdSortByValueAsync(tagId);
        }
    }
}

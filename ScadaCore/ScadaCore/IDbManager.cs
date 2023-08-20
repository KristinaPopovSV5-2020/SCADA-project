using Models;
using System.Collections.Generic;
using System.ServiceModel;

namespace ScadaCore
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDbManager" in both code and config file together.
    [ServiceContract]
    public interface IDbManager
    {
        [OperationContract]
        bool AddTag(Tag tag, bool realTimeOn);
        [OperationContract]
        List<AnalogOutput> GetAnalogOutputTags();
        [OperationContract]
        List<AnalogInput> GetAnalogInputTags();
        [OperationContract]
        List<DigitalInput> GetDigitalInputTags();
        [OperationContract]
        List<DigitalOutput> GetDigitalOutputTags();

        [OperationContract]
        void DeleteTag(string tagId);
        [OperationContract]
        void OnOffScan(string tagId);

        [OperationContract]
        void UpdateValue(string tagId, double value);
        [OperationContract]
        void newAlarm(Alarm alarm);
        [OperationContract]
        void deleteAlarm(string alarmId);
        [OperationContract]
        List<Alarm> findAlarm(string tagId);


    }
}

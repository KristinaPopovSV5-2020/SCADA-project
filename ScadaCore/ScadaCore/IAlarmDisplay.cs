using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ScadaCore
{
    [ServiceContract(CallbackContract = typeof(IAlarmDisplayCallback))]
    public interface IAlarmDisplay
    {
        [OperationContract]
        void initializationAlarmDisplay();
    }


    public interface IAlarmDisplayCallback
    {
        [OperationContract]
        void showAlarmDisplay(Alarm alarm);

    }
}

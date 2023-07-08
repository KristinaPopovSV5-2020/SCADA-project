using Models;
using System.Collections.Generic;
using System.ServiceModel;

namespace ScadaCore
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDbManager" in both code and config file together.
    [ServiceContract]
    public interface IRTU
    {
        [OperationContract]
        List<string> getAvailableAddresses();

        [OperationContract]
        void sendToService(string address, double value);

        [OperationContract]
        bool addAddress(string address);


    }
}

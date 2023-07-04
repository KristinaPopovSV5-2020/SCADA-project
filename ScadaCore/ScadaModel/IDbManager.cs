using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ScadaModel
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDbManager" in both code and config file together.
    [ServiceContract]
    public interface IDbManager
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        void AddTag(Tag tag);


    }
}

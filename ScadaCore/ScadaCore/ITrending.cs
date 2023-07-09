using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace ScadaCore
{
    public interface ITrendingCB
    {
        [OperationContract(IsOneWay = true)]
        void addTagValue(string tagName, int value);
    }

    [ServiceContract(CallbackContract = typeof(ITrendingCB))]
    public interface ITrending
    {
        [OperationContract]
        void initTrending();
    }
}
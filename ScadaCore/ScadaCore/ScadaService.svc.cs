using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ScadaCore
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service.svc or Service.svc.cs at the Solution Explorer and start debugging.
    public class ScadaService : IDbManager
    {
        void IDbManager.AddTag(Tag tag)
        {
            throw new NotImplementedException();
        }

        void IDbManager.DoWork()
        {
            throw new NotImplementedException();
        }
    }
}

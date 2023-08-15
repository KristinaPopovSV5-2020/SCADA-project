using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ScadaCore
{
    [ServiceContract]
    public interface ILogin
    {
        [OperationContract]
        List<User> getUsers();


    }
}

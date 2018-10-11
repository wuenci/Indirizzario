using Indirizzario.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Indirizzario.Wcf.Contracts
{
    // Define a service contract.
    [ServiceContract(Namespace = "Indirizzario.Wcf.Contracts")]
    public interface ICom
    {
        [OperationContract]
        void AddPerson(Person person);
        //[OperationContract]
        //void DeletePerson(Person person);
        //[OperationContract]
        //void RemovePerson(Person person);
        //[OperationContract]
        //void UpdatePerson(Person person);

        [OperationContract]
        void AddAddress(Address address);
        //[OperationContract]
        //void DeleteAddress(Address address);
        //[OperationContract]
        //void RemoveAddress(Address address);
        //[OperationContract]
        //void UpdateAddress(Address address);

    }
}

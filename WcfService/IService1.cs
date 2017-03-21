using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string Encrypt(string plainText, string passPhrase);

        [OperationContract]
        string Decrypt(string cipherText, string passPhrase);

        [OperationContract]
        Int32 Add(Int32 n1, Int32 n2);
    }

}

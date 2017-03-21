using EnCryptDecrypt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public int Add(int n1, int n2)
        {
            return  n1 + n2;
        }


        public string Encrypt(string plainText, string passPhrase)
        {
            return CryptorEngine.Encrypt(plainText, passPhrase);
        }

        public string Decrypt(string cipherText, string passPhrase)
        {
            return CryptorEngine.Decrypt(cipherText, passPhrase);
        }

    }
}

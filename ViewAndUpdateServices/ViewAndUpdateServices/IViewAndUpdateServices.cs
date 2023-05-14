using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ViewAndUpdateServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IViewAndUpdateServices" in both code and config file together.
    [ServiceContract]
    public interface IViewAndUpdateServices
    {
        [OperationContract]  //1  
        string viewName(int id);

        [OperationContract]  //2
        string viewEmail(int id);

        [OperationContract]  //3  
        string viewPassword(int id);

        [OperationContract]  //4
        string viewUserName(int id);

        [OperationContract]  //5
        string viewMobileNumber(int id);

        [OperationContract]  //6
        string viewAddress(int id);

        [OperationContract]  //7
        string viewCreditNumber(int id);

        [OperationContract]  //8
        string viewCreditPassword(int id);

        [OperationContract]
        void UpdateuserName(string data, int uid);
        [OperationContract]
        void UpdateuserAddress(string data, int uid);
        [OperationContract]
        void UpdateuserEmail(string data, int uid);
        [OperationContract]
        void UpdateuserPassword(string data, int uid);
        [OperationContract]
        void UpdateuserUserName(string data, int uid);
        [OperationContract]
        void UpdateuserMobileNumber(string data, int uid);
        [OperationContract]
        void UpdateuserCreditNumber(string data, int uid);
        [OperationContract]
        void UpdateuserCreditPassword(string data, int uid);


    }
}

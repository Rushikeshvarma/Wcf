using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        //[OperationContract]
        //[WebGet(UriTemplate = "CustomersJson", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        //Customer GetDataUsingDataContract();

        //[OperationContract]
        //[WebGet(UriTemplate = "CustomersXml", ResponseFormat = WebMessageFormat.Xml, RequestFormat = WebMessageFormat.Xml)]
        //Customer GetDataUsingDataContractXML();




        [OperationContract]
        //[WebGet(UriTemplate = "CustomersJson", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        [WebInvoke(UriTemplate = "CustomersJson", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        void PostDataUsingDataContract(Customer c);

        [OperationContract]
        [WebGet(UriTemplate = "CustomersXml", ResponseFormat = WebMessageFormat.Xml, RequestFormat = WebMessageFormat.Xml)]
        List<Customer> GetDataUsingDataContractXML();


    }
    [DataContract]
    public class Customer
    {


        //[DataMember]
        //public string CustName { get; set; }

        
        public string custname;
        [DataMember]
        public string CustName
        {
            get { return custname; }
            set { custname = value; }
        }



    }
}

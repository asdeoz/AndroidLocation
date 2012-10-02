using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AndroidLocationService
{
    [ServiceContract(Namespace= "http://services.example.com")]
    public interface ILocationService
    {
        [OperationContract]
        [WebGet(
            UriTemplate = "GetPlates",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json)]
        IList<string> GetPlates();

        [OperationContract]
        [WebGet(UriTemplate = "GetVehicle/{plate}",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json)]
        Vehicle GetVehicle(string plate);

        [OperationContract]
        [WebInvoke(
            Method = "POST",
            UriTemplate = "SaveVehicle",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json)]
        void SaveVehicle(Vehicle vehicle);

        [OperationContract]
        [WebGet(UriTemplate = "GetPlate",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json)]
        string GetPlate();

        [OperationContract]
        [WebGet(UriTemplate = "ToUpper/{toUpper}",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json)]
        string ToUpper(string toUpper);

        [OperationContract]
        [WebGet(UriTemplate = "Writer/{text}",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json)]
        void Writer(string text);

        [OperationContract]
        [WebGet(UriTemplate = "Reader",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json)]
        string Reader();

    }

    [DataContract]
    public class Vehicle
    {
        [DataMember(Name = "year")]
        public int Year { get; set; }

        [DataMember(Name = "plate")]
        public string Plate { get; set; }

        [DataMember(Name = "make")]
        public string Make { get; set; }

        [DataMember(Name = "model")]
        public string Model { get; set; }
    }

}

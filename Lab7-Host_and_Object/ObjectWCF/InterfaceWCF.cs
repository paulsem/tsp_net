using System.Collections.Generic;
using System.ServiceModel;
using PhotosApp;

namespace ObjectWCF
{
    [ServiceContract]
    interface InterfacePhotosApp
    {
      
        [OperationContract] void addDetails(string a, string b, string c, System.DateTime data, string[] x);

        [OperationContract] bool checkPath(string a);

        [OperationContract] void insertNewImage(string path, string locatie, string anotimp, System.DateTime data, string[] persoane);

        [OperationContract] void updateDetails(string a, string b, string c, System.DateTime data, string[] x);

        [OperationContract] void deleteDetails(string a);

        [OperationContract] List<string> getDetails(string a);

        [OperationContract] List<string> getPaths(string a);
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotosApp;

namespace ObjectWCF
{
    public class PhotosApp : InterfacePhotosApp
    {
        void InterfacePhotosApp.addDetails(string a, string b, string c, DateTime data, string[] x)
        {
            Class1.addDetails(a, b, c, data, x);
        }

        bool InterfacePhotosApp.checkPath(string a)
        {
            return Class1.checkPath(a);
        }

        void InterfacePhotosApp.deleteDetails(string a)
        {
            Class1.deleteDetails(a);
        }

        List<string> InterfacePhotosApp.getPaths(string a)
        {
            return Class1.getPaths(a);
        }

        List<string> InterfacePhotosApp.getDetails(string a)
        {
            return Class1.getDetails(a);
        }

        void InterfacePhotosApp.insertNewImage(string path, string locatie, string anotimp, DateTime data, string[] persoane)
        {
            Class1.insertNewImage(path, locatie, anotimp, data, persoane);
        }

        void InterfacePhotosApp.updateDetails(string a, string b, string c, DateTime data, string[] x)
        {
            Class1.updateDetails(a, b, c, data, x);
        }
    }
}

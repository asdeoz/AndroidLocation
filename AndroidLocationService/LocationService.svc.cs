using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.IO;

namespace AndroidLocationService
{
    public class LocationService : ILocationService
    {

        #region Miembros de ILocationService

        public IList<string> GetPlates()
        {
            List<string> lista = new List<string>();

            lista.Add("aaa");
            lista.Add("bbb");
            lista.Add("ccc");

            return lista;
        }

        public Vehicle GetVehicle(string plate)
        {
            Vehicle v = new Vehicle();

            v.Plate = plate;

            return v;
        }

        public void SaveVehicle(Vehicle vehicle)
        {
            
        }

        public string GetPlate()
        {
            return "aaa";
        }

        public string ToUpper(string toUpper)
        {
            return toUpper.ToUpper();
        }

        public void Writer(string text)
        {
            FileStream fs = new FileStream("|DataDirectory|/location.txt", FileMode.OpenOrCreate, FileAccess.Write);

            TextWriter tw = new StreamWriter(fs);

            tw.WriteLine(text);

            tw.Close();
        }

        public string Reader()
        {
            FileStream fs = new FileStream("location.txt", FileMode.Open, FileAccess.Read);

            TextReader tr = new StreamReader(fs);

            string line = tr.ReadLine();

            tr.Close();

            return line;
        }

        #endregion
    }
}

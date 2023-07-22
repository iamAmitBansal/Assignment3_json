using Assignment3_json.model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign3json.Models
{
    internal class jsonSerilizationDeserilization
    {
        public void serialize_deserialize()
        {
            Student s = new Student();

            Console.WriteLine("\n======== Serialization \n");
            string JSONresult = JsonConvert.SerializeObject(s); // Corrected SerializeObject method name.
            Console.WriteLine(JSONresult);

            Console.WriteLine("\n========== Deserialization \n");
            s = JsonConvert.DeserializeObject<Student>(JSONresult); // Corrected DeserializeObject method name.

            Console.WriteLine("ID = " + s.Stdid);
            Console.WriteLine("FirstName = " + s.Fname);
            Console.WriteLine("LastName = " + s.Lname);
            Console.WriteLine("Designation = " + s.Course);
        }

    }
}
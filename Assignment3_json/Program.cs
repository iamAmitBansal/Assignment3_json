// will work with json  

// Serialization and Deserialzation

using Assign3json.Models;
using Assignment3_json.model;

//jsonSerilizationDeserilization sd = new jsonSerilizationDeserilization();
//sd.serialize_deserialize();

  // ReadDataUrl
  Console.WriteLine("\n ============= ReadDataFromUrl =========\n");
ReadDataURL read = new ReadDataURL();
read.Read();  // getting the data from the URL
read.print_name();
read.print_email();
read.print_city();
read.createfile();

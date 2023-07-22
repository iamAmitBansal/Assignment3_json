using Assignment3_json.model;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;
using System.Text;

namespace Assign3json.Models
{
    internal class ReadDataURL
    {
        // Data: https://jsonplaceholder.typicode.com/users
        string jsonDataFromUrl;

        public void Read()
        {
            Console.WriteLine("- URL Data");

            string URL = "https://jsonplaceholder.typicode.com/users";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            using (Stream responseStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                jsonDataFromUrl = reader.ReadToEnd();

                if (jsonDataFromUrl != null)
                {
                    // Now log your data in the console
                    // Console.WriteLine("data- ---(" + jsonDataFromUrl + ")");
                }
                else
                {
                    Console.WriteLine("No Data- -");
                }
            }
        }

        public void print_name()
        {
            Console.WriteLine("\n\n============ print emp_email =========\n\n");

            // Parse the Json file into an Array object 
            var jsonObject = JArray.Parse(jsonDataFromUrl);

            // Iterate over the Json Array and print out the email of each item
            foreach (var jsonObjectItem in jsonObject)
            {
                Console.WriteLine(jsonObjectItem["name"]);
            }
        }

        public void print_email()
        {
            Console.WriteLine("\n\n============ print emp_email =========\n\n");

            // Parse the Json file into an Array object 
            var jsonObject = JArray.Parse(jsonDataFromUrl);

            // Iterate over the Json Array and print out the email of each item
            foreach (var jsonObjectItem in jsonObject)
            {
                Console.WriteLine(jsonObjectItem["email"]);
            }
        }


        //print_city
        public void print_city()
        {
            Console.WriteLine("\n\n============ print emp_city =========\n\n");

            // Parse the Json file into an Array object 
            var jsonObject = JArray.Parse(jsonDataFromUrl);

            // Iterate over the Json Array and print out the email of each item
            foreach (var jsonObjectItem in jsonObject)
            {
                Console.WriteLine(jsonObjectItem["address"]["city"]);
            }

        }

        // create file

// O references
/*using Newtonsoft.Json.Linq; */// Add the appropriate reference for JObject and JArray

    public void createfile()
    {
        // Parse the Json file into an Array object
        var jsonObject = JArray.Parse(jsonDataFromUrl);

        // Create a file named json_name.txt on your desktop
        string filedata = "";
        foreach (var jsonObjectItem in jsonObject)
        {
            filedata = filedata + jsonObjectItem["email"].ToString();
        }

        // Create a new file path
        string writefilename = "json_name.txt";
        string desktop = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

        // Get the location of the Desktop folder
        string writefilePath = $"{desktop}\\{writefilename}";

            // ****Using FileHelper

            // Fix the method name to use Write instead of write
        FileHelper.Write(writefilePath, filedata, append: true);
        FileHelper.Write("json_name.txt", filedata, append: true); //provide your file path here
        Console.WriteLine("file created");
    }
}
}


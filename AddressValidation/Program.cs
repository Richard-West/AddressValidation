using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using RestSharp;


namespace AddressValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            string customerId = "";
            string apikey = "";
            string address = "address1=2905+premiere+parkway+ste+200&zipcode=30097";
            string url = "https://rapid.peachtreedata.com/api/v1/AddressCleanseGeoCode";
            string fullurl = url + "?CustomerID=" + customerId + "&APIKEY=" + apikey + "&" + address;

            var client = new RestClient(url);
            var request = new RestRequest();

            request.AddParameter("CustomerID", "XXX999");
            request.AddParameter("apikey", "e78f9d79-8710-4753-a099-88c95ea11d0f");
            request.AddParameter("Address1", "2905 premiere parkway");
            request.AddParameter("ZIPCode", "30097");
            request.AddParameter("CompanyName", "peachtree  ");

            var response = client.Execute <AddressCleanseGeoCodeResponse>(request);

            Console.WriteLine("Primary Address:   {0}", response.Data.PrimaryAddress);
            Console.WriteLine("Secondary Address: {0}", response.Data.SecondaryAddress);
            Console.WriteLine("ZIP Code:          {0}", response.Data.Zip10);
            Console.WriteLine("Latitude:          {0}", response.Data.Latitude);
            Console.WriteLine("Longitude:         {0}", response.Data.Longitude);
            Console.WriteLine("Geo Assignment:    {0}", response.Data.AssignmentLevel);
            Console.WriteLine("Status:            {0}", response.Data.StatusMessage);
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();

        }
    }
}

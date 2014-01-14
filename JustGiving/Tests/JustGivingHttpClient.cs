using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace JustGiving.Tests
{
    public class JustGivingHttpClient
    {
        HttpClient client = new HttpClient();
        public void InitializeClient()
        {
            client.BaseAddress = new Uri("http://jgautomationrecruitment.apphb.com/api");

            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public void ParseResponseAndOutput()
        {
            HttpResponseMessage response = client.GetAsync("api/exercise2").Result;
            if (response.IsSuccessStatusCode)
            {
                var donation = response.Content.ReadAsAsync<IEnumerable<Donation>>().Result;
                foreach (var d in donation)
                {
                    Console.WriteLine("{0}\t{1};\t{2}", d.Amount, d.Id, d.Message);
                }
                Double TotalAmount = 0;
                foreach (var d in donation)
                {                    
                TotalAmount += d.Amount;              
                }
                Console.WriteLine("Total sum of all donation amount is " + "{0}", TotalAmount);      
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace Pika_Test_Framework
{
    class BVSInterface
    {
        async static void BVSGetRequest(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(url))
                {
                    using (HttpContent content = response.Content)
                    {
                        string responseString = await content.ReadAsStringAsync();
                        Console.WriteLine(responseString);
                        ;
                    }
                }
            }
        }
    }
}

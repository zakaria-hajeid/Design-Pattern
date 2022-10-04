using Chain_of_Responsibility.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    public class SecondHandlerToCallService: ThirdPartyService
    {
        public override int index => 1;

        public override async void SendRequest()
        {
            try
            {
                HttpClient client = new HttpClient();
                var respnse = await client.SendAsync(new HttpRequestMessage() { RequestUri = new Uri("127.0.0.1/welcome") });
                if (respnse.IsSuccessStatusCode)
                {
                    Console.WriteLine($"The proccess is compleated in {nameof(SecondHandlerToCallService)}");
                }
                else
                {
                    thirdPartyService.SendRequest();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("the process is faile from all handlers");
            }

        }
    }
}

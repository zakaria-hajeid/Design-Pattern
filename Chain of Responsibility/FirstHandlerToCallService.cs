using Chain_of_Responsibility.Abstractions;

namespace Chain_of_Responsibility
{
    public class FirstHandlerToCallService : ThirdPartyService
    {
        public override int index =>0;

        public override async void SendRequest()
        {
            try
            {
                HttpClient client = new HttpClient();
                var respnse = await client.SendAsync(new HttpRequestMessage() { RequestUri=new Uri("127.0.0.1/welcome") });
                if (respnse.IsSuccessStatusCode)
                {
                    Console.WriteLine($"The proccess is compleated in {nameof(FirstHandlerToCallService)}");
                }
                else
                {
                    thirdPartyService.SendRequest();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("the first handler is falid try next handlers");
                thirdPartyService.SendRequest();

            }

        }
    }
}
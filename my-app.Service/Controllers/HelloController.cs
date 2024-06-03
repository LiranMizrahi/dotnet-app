using Microsoft.AspNetCore.Mvc;

namespace my_app.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        private static readonly HttpClient client = new HttpClient();
        
        [HttpGet]
        [Route("hello")]
        public async Task<IActionResult> GetHelloAsync()
        {
            try
        {
            HttpResponseMessage response = await client.GetAsync("http://user17-dotnet-app.user17-application:8080");
            response.EnsureSuccessStatusCode(); // Throw an exception if the response is not successful

            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
           
            var value = System.Environment.GetEnvironmentVariable("ENDPOINT_URL");
            Console.WriteLine(value);
            return Ok(value);
        }
    }
}

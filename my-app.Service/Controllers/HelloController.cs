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
            HttpResponseMessage response = await client.GetAsync("http://localhost:8080/user17.user17-argocd/hello/test");
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

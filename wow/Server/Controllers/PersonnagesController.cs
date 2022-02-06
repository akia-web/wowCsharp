using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace wow.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonnagesController : ControllerBase
    {
        [HttpGet("get-personnage")]
        public async Task<object> getCharacters()
        {

            string token = Request.Cookies["tokenBnet"];

            string requestUrl = $"https://eu.api.blizzard.com/profile/user/wow?access_token={token}&namespace=profile-eu";
            HttpClient client = new HttpClient();

            var request = await client.GetAsync(requestUrl);
            dynamic response = JsonConvert.DeserializeObject(await request.Content.ReadAsStringAsync());

            Console.WriteLine(response);



            return response;
        }


    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using wow.Server.Models;
using wow.Server.Services;

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

            HttpResponseMessage request = await client.GetAsync(requestUrl);
            APIResult response = JsonConvert.DeserializeObject<APIResult>(await request.Content.ReadAsStringAsync());

            System.Collections.Generic.IEnumerable<Personnages> p = response.wow_accounts.First().characters.Where(i => i.realm.GetFR() == "Hyjal");
            var group = response.wow_accounts.First().characters.GroupBy(i => i.realm.GetFR());
            Console.WriteLine(response);

            var tasks = response.wow_accounts.First().characters.Select(i => Task.Run(async () =>
            {
                try
                {
                    i.contenu = await new HttpClient().GetStringAsync($"{i.character.href}&access_token={token}");
                }
                catch (Exception e)
                {

                }
                
            })).ToArray();

            Task.WaitAll(tasks);

            return response;
        }


    }
}

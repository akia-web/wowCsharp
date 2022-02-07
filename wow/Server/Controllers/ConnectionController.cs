using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using Newtonsoft.Json;

using wow.Server.Models;
using System.Threading.Tasks;
using System.Net;
using Microsoft.Net.Http.Headers;

namespace wow.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConnectionController : Controller
    {

     

        [HttpGet("connexion")]
        public JsonResult connexion()
        {
            string bnetId = "98c2bdee08894fceadeeb67c8da8b84a";
            string urlRedirect = "https://localhost:44367/api/connection/connexionBnet";

            string lien = $"https://eu.battle.net/oauth/authorize?client_id={bnetId}&response_type=code&redirect_uri={urlRedirect}&scope=wow.profile";
            return Json(lien);
        }

        [HttpGet("connexionBnet")]

        public async Task<object> battlenetConnexion()
        {
            string bnetId = "98c2bdee08894fceadeeb67c8da8b84a";
            string bnetSecret = "ThCcekYZWYmEJKcVR0BNPPafTP7paP8M";
            string urlRedirect = "https://localhost:44367/api/connection/connexionBnet";
            string code = Request.Query["code"];


            // récupère le token
            string requestUrl = $"https://eu.battle.net/oauth/token?code={code}&redirect_uri={urlRedirect}&client_id={bnetId}&client_secret={bnetSecret}&grant_type=authorization_code&scope=wow.profile";
            HttpClient client = new HttpClient();
            var request =  await client.PostAsync(requestUrl, null);
            ConnectionModel response = JsonConvert.DeserializeObject<ConnectionModel>( await request.Content.ReadAsStringAsync());
            string token = response.access_token;


            // récupère le battleTag
            requestUrl = $"https://eu.battle.net/oauth/userinfo?access_token={token}";
            request = await client.GetAsync(requestUrl);
            UserBnet user = JsonConvert.DeserializeObject<UserBnet>(await request.Content.ReadAsStringAsync());

            user.token = token;

            string json = JsonConvert.SerializeObject(user);
            System.IO.File.WriteAllText($"Json/identifiants/{user.battleTag}.json", json);

            //création du cookie
            HttpContext.Response.Cookies.Append("TokenBnet", token, new CookieOptions { Expires = DateTime.MaxValue});
            var truc = Request.Cookies["tokenBnet"];
            Console.WriteLine(truc);
            
            return Redirect("https://localhost:44367/counter"); 
        }
    }

    
}

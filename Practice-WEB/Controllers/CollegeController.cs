using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Practice_DataAccessLayer.Models;
using System.Net.Http.Headers;

namespace Practice_WEB.Controllers
{
    public class CollegeController : Controller
    {

        private static string url = "https://localhost:7197/";
        [HttpGet]
        public IActionResult AddNewCollege()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddNewCollege(College college)
        {
            string custommsg = string.Empty;
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var responseMsg = await client.PostAsJsonAsync("/api/v1/College/AddCollege", college);
                if (responseMsg != null)
                {
                    var res = responseMsg.Content.ReadAsStringAsync().Result;
                    custommsg = JsonConvert.DeserializeObject<string>(res);
                }
            }
            return View();
        }
    }
}

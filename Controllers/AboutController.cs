using Microsoft.AspNetCore.Mvc;

namespace CmdProfect.Controllers
{
    [Route("wof/about")]
    public class AboutController : Controller
    {
        [Route("show")]
        public string Index(string id, string param)
        {
            return $"About id = {id} params = {param}";
        }
    }
}

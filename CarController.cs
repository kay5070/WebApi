using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace Webapi
{   
    [Route("api/[controller]")]
    public abstract class BaseController{}
    public class CarController : BaseController
    {
        [Route ("[action]")]
        
        public IActionResult <string> Start()
        {

            return "hi";
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using RoleGameAPI.Models;

namespace RoleGameAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private static Character knight = new Character();
        [HttpGet]

        public IActionResult Get()
        {
            return Ok(knight);
        }
    }
}
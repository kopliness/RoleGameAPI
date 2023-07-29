using Microsoft.AspNetCore.Mvc;

namespace RoleGameAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character>
        {
            new Character(),
            new Character(){ Id=1,Name="Trall", Class=RpgClass.Rogue}
        };

        [HttpGet("GetAll")]
        public ActionResult<List<Character>> Get()
        {
            return Ok(characters);
        }
        [HttpGet("{id}")]
        public ActionResult<List<Character>> GetSingle(int id)
        {
            return Ok(characters.FirstOrDefault(c => c.Id==id));
        }
    }
}
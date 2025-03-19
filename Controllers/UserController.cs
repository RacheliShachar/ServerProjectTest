using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServerProjectMvcWithoutView.Repositories.Interface;
using Swashbuckle.AspNetCore.Annotations;

namespace ServerProjectMvcWithoutView.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository){
            _userRepository = userRepository;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "Gets Users")]
        public async Task<IActionResult> GetUsers()
        {
            return Ok(await _userRepository.GetUsers());
        }

        [HttpGet("{name}")]
        [SwaggerOperation(Summary = "Gets a personalized greeting message")]
        public IActionResult GetByName(string name)
        {
            return Ok(new { Message = $"Hello, {name}!" });
        }
    }
}

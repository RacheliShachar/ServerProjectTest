using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using ServerProjectMvcWithoutView.Models;
using ServerProjectMvcWithoutView.Repositories.Interface;
using Swashbuckle.AspNetCore.Annotations;

namespace ServerProjectMvcWithoutView.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [EnableCors("AllowAngularOrigin")]
    public class QueuesController : ControllerBase
    {
        private readonly IQueuesRepository _queuesRepository;
        public QueuesController(IQueuesRepository queuesRepository){
            _queuesRepository = queuesRepository;
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Add New Queue")]
        public async Task<IActionResult> AddNewQueue([FromBody] CreateQueue queue)
        {
            await _queuesRepository.AddNewQueue(queue);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [SwaggerOperation(Summary = "Delete Queue")]
        public async Task<IActionResult> DeleteQueue(string id)
        {
            await _queuesRepository.DeleteQueue(id);
            return NoContent();
        }

        [HttpGet]
        [SwaggerOperation(Summary = "Get All Queues")]
        public async Task<IActionResult> GetAllQueues()
        {
           return Ok(await _queuesRepository.GetAllQueues());
        }

    }
}

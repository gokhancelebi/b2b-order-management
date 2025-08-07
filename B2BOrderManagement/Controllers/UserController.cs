using B2BOrderManagement.Models.User;
using B2BOrderManagement.Services;
using Microsoft.AspNetCore.Mvc; 


namespace B2BOrderManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private UserService _service { get; set; }
        public UserController(UserService service) {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var list = await _service.GetAllUsersAsync();
            return Ok(new { list });
        }
        [HttpGet("{id}")] 
        public async Task<IActionResult> GetById(int id)
        {
            var user = await _service.GetUserByIdAsync(id);
            if (user == null) return NotFound();
            return Ok(user);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] User user)
        {
            var created = await _service.AddUserAsync(user);
            return Ok(created);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] User user)
        {
            var updated = await _service.UpdateUserAsync(user);
            if (updated == null) return NotFound();
            return Ok(updated);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _service.DeleteUserAsync(id);
            if(!deleted) return NotFound();
            return Ok(deleted);
        }
    }
}

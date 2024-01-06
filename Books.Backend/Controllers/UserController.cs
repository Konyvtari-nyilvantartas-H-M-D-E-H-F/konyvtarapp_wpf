using Books.Backend.Datas.Entities;
using Books.Backend.Repos;
using Microsoft.AspNetCore.Mvc;

namespace Books.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private IUserRepo _userRepo;

        public UserController(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBy(Guid id)
        {
            User? entity = new();
            if (_userRepo is not null)
            {
                entity = await _userRepo.GetBy(id);
                if (entity != null)
                    return Ok(entity);

            }
            return BadRequest("Az adatok elérhetetlenek!");
        }

        [HttpGet]
        public async Task<IActionResult> SelectAllRecordToListAsync()
        {
            List<User>? users = new();

            if (_userRepo != null)
            {
                users = await _userRepo.GetAll();
                return Ok(users);
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }
    }
}

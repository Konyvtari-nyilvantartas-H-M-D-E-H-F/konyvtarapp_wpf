using Books.Backend.Datas.Entities;
using Books.Backend.Repos;
using Microsoft.AspNetCore.Mvc;

namespace Books.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private IBookRepo _bookRepo;

        public BookController(IBookRepo bookRepo)
        {
            _bookRepo = bookRepo;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBy(Guid id)
        {
            Book? entity = new();
            if (_bookRepo is not null)
            {
                entity = await _bookRepo.GetBy(id);
                if (entity != null)
                    return Ok(entity);
              
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }

        [HttpGet]
        public async Task<IActionResult> SelectAllRecordToListAsync()
        {
            List<Book>? books = new();

            if (_bookRepo != null)
            {
                books = await _bookRepo.GetAll();
                return Ok(books);
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }
    }
}

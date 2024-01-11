using Books.Backend.Datas.Entities;
using Books.Backend.Repos;
using Microsoft.AspNetCore.Mvc;

namespace Books.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class KiadoController : ControllerBase
    {
        private IKiadoRepo _kiadoRepo;

        public KiadoController(IKiadoRepo kiadoRepo)
        {
            _kiadoRepo = kiadoRepo;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBy(Guid id)
        {
            Kiado? entity = new();
            if (_kiadoRepo is not null)
            {
                entity = await _kiadoRepo.GetBy(id);
                if (entity != null)
                    return Ok(entity);

            }
            return BadRequest("Az adatok elérhetetlenek!");
        }

        [HttpGet]
        public async Task<IActionResult> SelectAllRecordToListAsync()
        {
            List<Kiado> kiadok = new();

            if (_kiadoRepo != null)
            {
                kiadok = await _kiadoRepo.GetAll();
                return Ok(kiadok);
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }
    }
}

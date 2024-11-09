using CMA.Application.Repositories.RepoCafe;
using CMA.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CMA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CafesController : ControllerBase
    {
        private readonly ICafeReadRepository _cafeReadRepository; 
        private readonly ICafeWriteRepository _cafeWriteRepository;

        public CafesController(ICafeReadRepository cafeReadRepository, ICafeWriteRepository cafeWriteRepository)
        {
            _cafeReadRepository = cafeReadRepository;
            _cafeWriteRepository = cafeWriteRepository;
        }

        [HttpGet]
        public async Task Get()
        {
            Cafe cafe = await _cafeReadRepository.GetByIdAsync("b3347d7a-44c1-4485-a598-20dbd14087af");
            cafe.Name = "Contra Cafe";
            await _cafeWriteRepository.SaveAsync();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            Cafe cafe = await _cafeReadRepository.GetByIdAsync(id);
            return Ok(cafe);
        }
    }
}

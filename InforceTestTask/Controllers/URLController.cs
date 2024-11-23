using InforceTestTask.Data;
using InforceTestTask.Services;
using Microsoft.AspNetCore.Mvc;

namespace InforceTestTask.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class URLController : ControllerBase
    {
        private readonly IRepository<URL> _url;

        public URLController(IRepository<URL> URLrep)
        {
            _url = URLrep;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var uries = await _url.GetByIdAsync(id);
            return uries == null ? NotFound() : Ok(uries);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var uries = await _url.GetAllAsync();
            return Ok(uries);
        }

        [HttpPost]
        public async Task<IActionResult> Create(URL newUrl)
        {
            if (ModelState.IsValid)
                await _url.AddAsync(newUrl);
            
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, URL url)
        {
            if (id != url.Id) 
                return BadRequest();
            await _url.UpdateAsync(url);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _url.DeleteAsync(id);
            return NoContent();
        }
    }
}

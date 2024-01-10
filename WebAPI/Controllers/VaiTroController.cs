using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.IServices;
using WebAPI.Services;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VaiTroController : ControllerBase
    {
        private readonly VaiTroIService _vaiTroService;

        public VaiTroController(VaiTroIService vaiTroService)
        {
            _vaiTroService = vaiTroService;
        }

        // GET: api/<VaiTroController>
        [HttpGet]
        public async Task<IActionResult> GetAllVaiTros()
        {
            var vaitro = _vaiTroService.GetAllVaiTro();
            return Ok(vaitro);
        }

        // GET api/<VaiTroController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var vaitro = _vaiTroService.GetVaiTroById(id);
            if (vaitro == null)
            {
                return NotFound();
            }
            return Ok(vaitro);
        }

        // POST api/<VaiTroController>
        [HttpPost]
        public bool AddVaiTro(string ten, int trangthai)
        {
            return _vaiTroService.CreateVaiTro(ten, trangthai);
        }


        // PUT api/<VaiTroController>/5
        [HttpPut("{id}")]
        public IActionResult UpdateVaiTro(Guid id, string ten, int trnagthai)
        {
            var vt = _vaiTroService.GetVaiTroById(id);
            if (vt != null)
            {
                _vaiTroService.UpdateVaiTro(vt.Id, ten, trnagthai);
                return Ok();
            }
            return BadRequest();


        }

        // DELETE api/<VaiTroController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVaiTro(Guid id)
        {
            var vt = _vaiTroService.DeleteVaiTro(id);
            return Ok();
        }
    }
}

using DPA_EP_23200334.CORE.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DPA_EP_23200334.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarreraController : ControllerBase
    {
        private readonly ICarreraService _carreraService;

        public CarreraController(ICarreraService carreraService)
        {
            _carreraService = carreraService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCarreras()
        {
            var carreras = await _carreraService.CarreraListDTO();
            return Ok("Carreras endpoint");
        }
    }
}

using BLL.DTO;
using BLL.ServiceInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StudenciWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistorieController : ControllerBase
    {
        private readonly IHistorie _service;
        public HistorieController(IHistorie service)
        {
            this._service = service;
        }
        [HttpGet]
        public IEnumerable<HistoriaResponseDTO> WyswietlHistorie(int liczbaElementow, int numerStrony)
        {
            return _service.WyswietlHistorie(liczbaElementow, numerStrony);
        }
    }
}

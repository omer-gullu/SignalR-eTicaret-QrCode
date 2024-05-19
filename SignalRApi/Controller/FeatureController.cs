using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.FeatureDto;

namespace SignalRApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
        private readonly IFeatureService _featureService;

        public FeatureController(IFeatureService featureService)
        {
            _featureService = featureService;
        }
        [HttpGet]
        public IActionResult FeatureList()
        {
            return Ok();
        }
        [HttpPost]
        public IActionResult CreateFeature(CreateFeatureDto createFeatureDto)
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteFeature(int id)
        {
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateFeature(UpdateFeatureDto updateFeatureDto)
        {
            return Ok();
        }
        [HttpGet]
        public IActionResult GetFeature(int id)
        {
            return Ok();
        }
    }
}

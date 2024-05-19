using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.SocialMediaDto;

namespace SignalRApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : ControllerBase
    {
        private readonly ISocialMediaService _socialMediaService;

        public SocialMediaController(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }
        [HttpGet]
        public IActionResult SocialMediaList()
        {
            return Ok();
        }
        [HttpPost]
        public IActionResult CreateSocialMedia(CreateSocialMediaDto createSocialMediaDto)
        {
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateSocialMedia(UpdateSocialMediaDto updateSocialMediaDto)
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteSocialMedia(int id)
        {
            return Ok();
        }
        [HttpGet]
        public IActionResult GetSocialMedia(int id)
        {
            return Ok();
        }
    }
}

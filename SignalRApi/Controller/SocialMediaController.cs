using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.SocialMediaDto;
using SignalR.EntityLayer.Entities;

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
            var value = _socialMediaService.TGetListAll();
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateSocialMedia(CreateSocialMediaDto createSocialMediaDto)
        {
            SocialMedia socialMedia = new SocialMedia()
            {
                Title = createSocialMediaDto.Title,
                Url = createSocialMediaDto.Url,
                Icon = createSocialMediaDto.Icon
            };
            _socialMediaService.TAdd(socialMedia);
            return Ok("Sosyal medya eklendi");
        }
        [HttpPut]
        public IActionResult UpdateSocialMedia(UpdateSocialMediaDto updateSocialMediaDto)
        {
            SocialMedia socialMedia = new SocialMedia()
            {
                Title =updateSocialMediaDto.Title,
                Url = updateSocialMediaDto.Url,
                Icon = updateSocialMediaDto.Icon,
                SocialMediaID = updateSocialMediaDto.SocialMediaID
            };
            _socialMediaService.TUpdate(socialMedia);
            return Ok("Sosyal medya güncellendi");
        }
        [HttpDelete]
        public IActionResult DeleteSocialMedia(int id)
        {
            var value = _socialMediaService.TGetByID(id);
            _socialMediaService.TDelete(value);
            return Ok("Sosyal medya silindi");
        }
        [HttpGet]
        public IActionResult GetSocialMedia(int id)
        {
            var value = _socialMediaService.TGetByID(id);
            return Ok(value);
        }
    }
}

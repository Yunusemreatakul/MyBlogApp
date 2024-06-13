using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyPath.Application.Features.CQRSMediator.Command.ProfileCommands;
using MyPath.Application.Features.CQRSMediator.Queries.ProfileQueries;


namespace MyPath.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProfileController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> ProfileList()
        {
            var values = await _mediator.Send(new GetProfileQuery());
            return Ok(values);
        }
        [HttpGet("by-userid/{UserId}")]
        public async Task<IActionResult> GetProfileListByUserId(int UserId)
        {
            var values = await _mediator.Send(new GetProfileUserIdQuery(UserId));
            return Ok(values);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetProfile(int Id)
        {
            var value = await _mediator.Send(new GetProfileByIdQuery(Id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateProfile(CreateProfileCommand command)
        {
            await _mediator.Send(command);
            return Ok("Değere Başarı ile Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateProfile(UpdateProfileCommand command)
        {
            await _mediator.Send(command);
            return Ok("Değer Başarılı Şekilde Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveProfile(RemoveProfileCommand command)
        {
            await _mediator.Send(command);
            return Ok("Değer Başarılı Şekilde Silindi");
        }
    }
}

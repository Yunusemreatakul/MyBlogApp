using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyPath.Application.Features.CQRSMediator.Command.BlogDetailCommands;
using MyPath.Application.Features.CQRSMediator.Queries.BlogDetailQueries;


namespace MyPath.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogDetailController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BlogDetailController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> BlogDetailList()
        {
            var values = await _mediator.Send(new GetBlogDetailQuery());
            return Ok(values);
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetBlogDetail(int Id)
        {
            var value = await _mediator.Send(new GetBlogDetailByIdQuery(Id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBlogDetail(CreateBlogDetailCommand command)
        {
            await _mediator.Send(command);
            return Ok("Değere Başarı ile Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBlogDetail(UpdateBlogDetailCommand command)
        {
            await _mediator.Send(command);
            return Ok("Değer Başarılı Şekilde Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveBlogDetail(RemoveBlogDetailCommands command)
        {
            await _mediator.Send(command);
            return Ok("Değer Başarılı Şekilde Silindi");
        }
    }
}

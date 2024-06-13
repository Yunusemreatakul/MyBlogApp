using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyPath.Application.Features.CQRSMediator.Command.CommentBlogCommands;
using MyPath.Application.Features.CQRSMediator.Queries.CommentBlogQueries;


namespace MyPath.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentBlogController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CommentBlogController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> CommentBlogList()
        {
            var values = await _mediator.Send(new GetCommentBlogQuery());
            return Ok(values);
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetCommentBlog(int Id)
        {
            var value = await _mediator.Send(new GetCommentBlogByIdQuery(Id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCommentBlog(CreateCommentBlogCommand command)
        {
            await _mediator.Send(command);
            return Ok("Değere Başarı ile Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCommentBlog(UpdateCommentBlogCommand command)
        {
            await _mediator.Send(command);
            return Ok("Değer Başarılı Şekilde Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveCommentBlog(RemoveCommentBlogCommand command)
        {
            await _mediator.Send(command);
            return Ok("Değer Başarılı Şekilde Silindi");
        }
    }
}

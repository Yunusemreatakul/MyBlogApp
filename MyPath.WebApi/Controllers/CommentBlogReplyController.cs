using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyPath.Application.Features.CQRSMediator.Command.CommentBlogReplyCommands;
using MyPath.Application.Features.CQRSMediator.Queries.CommentBlogReplyQueries;


namespace MyPath.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentBlogReplyController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CommentBlogReplyController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> CommentBlogReplyList()
        {
            var values = await _mediator.Send(new GetCommentBlogReplyQuery());
            return Ok(values);
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetCommentBlogReply(int Id)
        {
            var value = await _mediator.Send(new GetCommentBlogReplyByIdQuery(Id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCommentBlogReply(CreateCommentBlogReplyCommand command)
        {
            await _mediator.Send(command);
            return Ok("Değere Başarı ile Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCommentBlogReply(UpdateCommentBlogReplyCommand command)
        {
            await _mediator.Send(command);
            return Ok("Değer Başarılı Şekilde Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveCommentBlogReply(RemoveCommentBlogReplyCommand command)
        {
            await _mediator.Send(command);
            return Ok("Değer Başarılı Şekilde Silindi");
        }
    }
}

using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyPath.Application.Features.CQRSMediator.Command.PortfolioImageListCommands;
using MyPath.Application.Features.CQRSMediator.Queries.PortfolioImageListQueries;


namespace MyPath.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PortfolioImageListController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PortfolioImageListController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> PortfolioImageListList()
        {
            var values = await _mediator.Send(new GetPortfolioImageListQuery());
            return Ok(values);
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetPortfolioImageList(int Id)
        {
            var value = await _mediator.Send(new GetPortfolioImageListByIdQuery(Id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreatePortfolioImageList(CreatePortfolioImageListCommand command)
        {
            await _mediator.Send(command);
            return Ok("Değere Başarı ile Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdatePortfolioImageList(UpdatePortfolioImageListCommand command)
        {
            await _mediator.Send(command);
            return Ok("Değer Başarılı Şekilde Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemovePortfolioImageList(RemovePortfolioImageListCommand command)
        {
            await _mediator.Send(command);
            return Ok("Değer Başarılı Şekilde Silindi");
        }
    }
}

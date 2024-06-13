using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyPath.Application.Features.CQRSMediator.Command.PortfolioDetailCommands;
using MyPath.Application.Features.CQRSMediator.Queries.PortfolioDetailQueries;


namespace MyPath.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PortfolioDetailController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PortfolioDetailController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> PortfolioDetailList()
        {
            var values = await _mediator.Send(new GetPortfolioDetailQuery());
            return Ok(values);
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetPortfolioDetail(int Id)
        {
            var value = await _mediator.Send(new GetPortfolioDetailByIdQuery(Id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreatePortfolioDetail(CreatePortfolioDetailCommand command)
        {
            await _mediator.Send(command);
            return Ok("Değere Başarı ile Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdatePortfolioDetail(UpdatePortfolioDetailCommand command)
        {
            await _mediator.Send(command);
            return Ok("Değer Başarılı Şekilde Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemovePortfolioDetail(RemovePortfolioDetailCommand command)
        {
            await _mediator.Send(command);
            return Ok("Değer Başarılı Şekilde Silindi");
        }
    }
}

using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyPath.Application.Features.CQRSMediator.Command.CategoryPortfolioCommands;
using MyPath.Application.Features.CQRSMediator.Queries.CategoryPortfolioQueries;


namespace MyPath.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryPortfolioController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoryPortfolioController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> CategoryPortfolioList()
        {
            var values = await _mediator.Send(new GetCategoryPortfolioQuery());
            return Ok(values);
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetCategoryPortfolio(int Id)
        {
            var value = await _mediator.Send(new GetCategoryPortfolioByIdQuery(Id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategoryPortfolio(CreateCategoryPortfolioCommand command)
        {
            await _mediator.Send(command);
            return Ok("Değere Başarı ile Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCategoryPortfolio(UpdateCategoryPortfolioCommand command)
        {
            await _mediator.Send(command);
            return Ok("Değer Başarılı Şekilde Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveCategoryPortfolio(RemoveCategoryPortfolioCommand command)
        {
            await _mediator.Send(command);
            return Ok("Değer Başarılı Şekilde Silindi");
        }
    }
}

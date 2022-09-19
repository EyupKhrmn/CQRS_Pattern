using System.Threading.Tasks;
using Handler_Yapisi_deneme.CQRS.Product.Command;
using Handler_Yapisi_deneme.CQRS.Product.Command.Response;
using Handler_Yapisi_deneme.CQRS.Product.Query;
using Handler_Yapisi_deneme.CQRS.Product.Query.Response;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Handler_Yapisi_deneme.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("Createproduct")]
        public async Task<IActionResult> Post([FromBody] ProductCreateCommand request)
        {
            ProductCreateCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById([FromQuery] GetByIdProductQuery request)
        {
            GetByIdProductQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
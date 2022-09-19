using System;
using System.Threading;
using System.Threading.Tasks;
using Handler_Yapisi_deneme.Context;
using Handler_Yapisi_deneme.CQRS.Product.Command;
using Handler_Yapisi_deneme.CQRS.Product.Command.Response;
using MediatR;

namespace Handler_Yapisi_deneme.CQRS.Product.Handler.CommandHandlers
{
    public class ProductCreateCommandHandler: IRequestHandler<ProductCreateCommand,ProductCreateCommandResponse>
    {
        private APPContext _context;
        public ProductCreateCommandHandler(APPContext context)
        {
            _context = context;
        }
        public async Task<ProductCreateCommandResponse> Handle(ProductCreateCommand request, CancellationToken cancellationToken)
        {
            var product = new Entities.Product
            {
                Name = request.Name,
                Quantity = request.Quantity,
                Price = request.Price,
                CreatedDate = DateTime.Now
            };

            _context.Add(product);

            await _context.SaveChangesAsync();
            return new ProductCreateCommandResponse
            {
                IsSuccess = true,
                ProductId = product.Id
            };
        }
    }
}
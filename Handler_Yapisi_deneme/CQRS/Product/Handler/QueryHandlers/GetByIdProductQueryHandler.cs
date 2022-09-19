using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Handler_Yapisi_deneme.Context;
using Handler_Yapisi_deneme.CQRS.Product.Query;
using Handler_Yapisi_deneme.CQRS.Product.Query.Response;
using MediatR;

namespace Handler_Yapisi_deneme.CQRS.Product.Handler.QueryHandlers
{
    public class GetByIdProductQueryHandler: IRequestHandler<GetByIdProductQuery,GetByIdProductQueryResponse>
    {
        private APPContext _context;

        public GetByIdProductQueryHandler(APPContext context)
        {
            _context = context;
        }

        public async Task<GetByIdProductQueryResponse> Handle(GetByIdProductQuery request, CancellationToken cancellationToken)
        {
            var product = _context.Products.FirstOrDefault(_ => _.Id == request.Id);
            if (product != null)
                return new GetByIdProductQueryResponse
                {
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    CreatedDate = product.CreatedDate,
                    Quantity = product.Quantity
                };
            return new GetByIdProductQueryResponse
            {
                Name = "Not Found"
            };
        }
    }
}
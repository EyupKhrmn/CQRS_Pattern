using Handler_Yapisi_deneme.CQRS.Product.Query.Response;
using MediatR;

namespace Handler_Yapisi_deneme.CQRS.Product.Query
{
    public class GetByIdProductQuery: IRequest<GetByIdProductQueryResponse>
    {
        public int Id { get; set; }
    }
}
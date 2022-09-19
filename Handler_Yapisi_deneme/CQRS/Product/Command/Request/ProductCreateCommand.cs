using Handler_Yapisi_deneme.CQRS.Product.Command.Response;
using MediatR;

namespace Handler_Yapisi_deneme.CQRS.Product.Command
{
    public class ProductCreateCommand: IRequest<ProductCreateCommandResponse>
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
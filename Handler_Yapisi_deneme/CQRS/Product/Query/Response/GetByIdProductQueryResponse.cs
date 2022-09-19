using System;

namespace Handler_Yapisi_deneme.CQRS.Product.Query.Response
{
    public class GetByIdProductQueryResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Quantity { get; set; }
    }
}
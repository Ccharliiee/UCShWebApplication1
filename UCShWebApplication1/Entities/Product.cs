namespace UCShWebApplication1.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public long Price { get; set; }
        public string? ProductDescription { get; set; }
        public int ProductCategoryId { get; set; }
        public string? ProductCategoryName { get; set;} 
        public string? Brand { get;set; }
        public string? PictureUrl { get;set; }
        public int QuantityInStock { get; set; }

    }
}

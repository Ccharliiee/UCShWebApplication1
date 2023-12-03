using UCShWebApplication1.Entities;

namespace UCShWebApplication1.DbConnectHelper
{
    public static class InitDbTableWithDummyData
    {
        public static void InitDbTable(ProStoreContext vProStoreContext)
        {
            if (vProStoreContext.Products.Any()) { return; }

            var dummyProducts = new List<Product> {
                new Product
                {
                    ProductName = "Alpine Salo Board 700",
                    ProductDescription =
                        "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit",
                    Price = 40000,
                    PictureUrl = "/images/products/sb-p1.png",
                    Brand = "Alpine",
                    ProductCategoryId=1,
                    ProductCategoryName = "Boards",
                    QuantityInStock = 100
                },
                new Product
                {
                    ProductName = "Blue Alpine Board 300",
                    ProductDescription = "Lorem  est, Vivamus a tellus.",
                    Price = 29000,
                    PictureUrl = "/images/products/sb-p2.png",
                    Brand = "Alpine",
                    ProductCategoryId=1,
                    ProductCategoryName = "Boards",
                    QuantityInStock = 100
                },
                new Product
                {
                    ProductName = "Core Board Speed K 3",
                    ProductDescription =
                        "Qretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "/images/products/sb-p3.png",
                    Brand = "KII",
                    ProductCategoryId=1,
                    ProductCategoryName = "Boards",
                    QuantityInStock = 100
                },
                new Product
                {
                    ProductName = "Net Core Super Board 800",
                    ProductDescription =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 37000,
                    PictureUrl = "/images/products/sb-p4.png",
                    Brand = "NetCore",
                    ProductCategoryId=1,
                    ProductCategoryName = "Boards",
                    QuantityInStock = 100
                },
                new Product
                {
                    ProductName = "ReactTS Board Super WOW",
                    ProductDescription =
                        "Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 35000,
                    PictureUrl = "/images/products/sb-p5.png",
                    Brand = "ReactTS",
                    ProductCategoryId=1,
                    ProductCategoryName = "Boards",
                    QuantityInStock = 100
                },
                new Product
                {
                    ProductName = "Typescript Entry LV Board",
                    ProductDescription =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 42000,
                    PictureUrl = "/images/products/sb-p6.png",
                    Brand = "TypeScriptCP",
                    ProductCategoryId=1,
                    ProductCategoryName = "Boards",
                    QuantityInStock = 100
                },
                new Product
                {
                    ProductName = "Core Blue Helmet",
                    ProductDescription =
                        "Fusce posuere, Lorem ipmagna sed pulvinar ultriciessum. ",
                    Price = 12000,
                    PictureUrl = "/images/products/helmet-p7.png",
                    Brand = "NetCore",
                    ProductCategoryId=6,
                    ProductCategoryName = "Helmet",
                    QuantityInStock = 100
                },
                new Product
                {
                    ProductName = "Black Mari Helmet",
                    ProductDescription =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 18000,
                    PictureUrl = "/images/products/helmet-p8.png",
                    Brand = "React",
                    ProductCategoryId=6,
                    ProductCategoryName = "Helmet",
                    QuantityInStock = 100
                },
                new Product
                {
                    ProductName = "Purple React TPS Helmet",
                    ProductDescription =
                        "Fusce posuere, magna sed pulvinar  amet commodo magna eros quis.",
                    Price = 152000,
                    PictureUrl = "/images/products/helmet-P9.png",
                    Brand = "ReactTPS",
                    ProductCategoryId=6,
                    ProductCategoryName = "Helmet",
                    QuantityInStock = 100
                },
                new Product
                {
                    ProductName = "Blue Code Gloves",
                    ProductDescription =
                        "Fusce posuere, libero, sit amet commodo magna eros quis urna.",
                    Price = 3800,
                    PictureUrl = "/images/products/glove-P10.png",
                    Brand = "VS Code",
                    ProductCategoryId=11,
                    ProductCategoryName = "Gloves",
                    QuantityInStock = 100
                },
                new Product
                {
                    ProductName = "Green Code Gloves",
                    ProductDescription =
                        "Fusce posuers quis urna.",
                    Price = 1500,
                    PictureUrl = "/images/products/glove-P11.png",
                    Brand = "VSTTT",
                    ProductCategoryId=11,
                    ProductCategoryName = "Gloves",
                    QuantityInStock = 100
                },
                new Product
                {
                    ProductName = "BLACK React Gloves",
                    ProductDescription =
                        "Fusce libero, sit amet commodo magna eros quis urna.",
                    Price = 6600,
                    PictureUrl = "/images/products/glove-P12.png",
                    Brand = "React",
                    ProductCategoryId=11,
                    ProductCategoryName = "Gloves",
                    QuantityInStock = 100
                },
                new Product
                {
                    ProductName = "Green Vi Gloves",
                    ProductDescription =
                        "Fusce libero, sit amet commodo magna eros quis urna.",
                    Price = 5400,
                    PictureUrl = "/images/products/glove-P13.png",
                    Brand = "React",
                    ProductCategoryId=11,
                    ProductCategoryName = "Gloves",
                    QuantityInStock = 100
                },
                new Product
                {
                    ProductName = "Redis Red Boots",
                    ProductDescription =
                        "Suspendisses eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 25000,
                    PictureUrl = "/images/products/boot-p14.png",
                    Brand = "Redis",
                    ProductCategoryId=22,
                    ProductCategoryName = "Boots",
                    QuantityInStock = 100
                },
                new Product
                {
                    ProductName = "Core Red Boots",
                    ProductDescription =
                        "Maecenas porttitor congue massa ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 18999,
                    PictureUrl = "/images/products/boot-p15.png",
                    Brand = "NetCore",
                    ProductCategoryId=22,
                    ProductCategoryName = "Boots",
                    QuantityInStock = 100
                },
                new Product
                {
                    ProductName = "Core Purple Boots",
                    ProductDescription =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 19999,
                    PictureUrl = "/images/products/boot-p16.png",
                    Brand = "DoNet",
                    ProductCategoryId=22,
                    ProductCategoryName = "Boots",
                    QuantityInStock = 100
                },
                new Product
                {
                    ProductName = "Alpine Purple Boots",
                    ProductDescription = "Aenean nec laoreet nonummy augue.",
                    Price = 15000,
                    PictureUrl = "/images/products/boot-p17.png",
                    Brand = "Alpine",
                    ProductCategoryId=22,
                    ProductCategoryName = "Boots",
                    QuantityInStock = 100
                },
                new Product
                {
                    ProductName = "Alpine Blue Boots",
                    ProductDescription =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "/images/products/boot-p18.png",
                    Brand = "Alpine",
                    ProductCategoryId=22,
                    ProductCategoryName = "Boots",
                    QuantityInStock = 100
                }, 
            };

            vProStoreContext.Products.AddRange(dummyProducts);
            vProStoreContext.SaveChanges();


        }
    }
}



namespace TechStore.DataAccess
{
    public class DatabaseInitializer
    {
        private readonly TechStoreDbContext _dbContext;

        public DatabaseInitializer(TechStoreDbContext dbContext)
        {
            _dbContext = dbContext;

        }

        public void Initialize()
        {
            // Create the database if it doesn't exist
            _dbContext.Database.EnsureCreated();

            // Si no hay categorías, las creamos
            if (!_dbContext.Categories.Any())
            {
                _dbContext.Categories.Add(new Models.Category
                {
                    CategoryId = 1001,
                    Name = "Phones",
                    ImageUrl = "Resources/Images/iconphone.svg"

                });

                _dbContext.Categories.Add(new Models.Category
                {
                    CategoryId = 1002,
                    Name = "Laptops",
                    ImageUrl = "Resources/Images/iconlaptop.svg"
                });

                _dbContext.Categories.Add(new Models.Category
                {
                    CategoryId = 1003,
                    Name = "Tablets",
                    ImageUrl = "Resources/Images/icontablet.svg"
                });

                _dbContext.Categories.Add(new Models.Category
                {
                    CategoryId = 1004,
                    Name = "Smartwatches",
                    ImageUrl = "Resources/Images/iconsmartwatch.svg"
                });

                _dbContext.Categories.Add(new Models.Category
                {
                    CategoryId = 1005,
                    Name = "Cameras",
                    ImageUrl = "Resources/Images/iconcamera.svg"
                });

                _dbContext.Categories.Add(new Models.Category
                {
                    CategoryId = 1006,
                    Name = "Headphones",
                    ImageUrl = "Resources/Images/iconheadphones.svg"
                });

                _dbContext.Categories.Add(new Models.Category
                {
                    CategoryId = 1007,
                    Name = "Desktops",
                    ImageUrl = "Resources/Images/iconcomputer.svg"
                });

                _dbContext.SaveChanges();
            }

            if (!_dbContext.Products.Any())
            {
                _dbContext.Products.Add(new Models.Product
                {
                    ProductId = 2001,
                    Name = "iPhone 14",
                    Price = 999.99,
                    Stock = 10,
                    ImageUrl = "Resources/Images/iphone14.jpg",
                    CategoryId = 1001,
                });

                _dbContext.Products.Add(new Models.Product
                {
                    ProductId = 2002,
                    Name = "Samsung Galaxy S10",
                    Price = 899.99,
                    Stock = 5,
                    ImageUrl = "Resources/Images/samsungs10.jpg",
                    CategoryId = 1001
                });

                _dbContext.Products.Add(new Models.Product
                {
                    ProductId = 2003,
                    Name = "MacBook Pro",
                    Price = 1999.99,
                    Stock = 3,
                    ImageUrl = "Resources/Images/mackbookpro.jpg",
                    CategoryId = 1002
                });

                _dbContext.Products.Add(new Models.Product
                {
                    ProductId = 2004,
                    Name = "Samsung S20",
                    Price = 799.99,
                    Stock = 7,
                    ImageUrl = "Resources/Images/sansungs20.jpg",
                    CategoryId = 1001
                });

                _dbContext.Products.Add(new Models.Product
                {
                    ProductId = 2005,
                    Name = "iPad Pro",
                    Price = 799.99,
                    Stock = 8,
                    ImageUrl = "Resources/Images/ipadpro.jpg",
                    CategoryId = 1003
                });

                _dbContext.Products.Add(new Models.Product
                {
                    ProductId = 2006,
                    Name = "Apple Watch Series 7",
                    Price = 399.99,
                    Stock = 6,
                    ImageUrl = "Resources/Images/applewatch.jpg",
                    CategoryId = 1004
                });

                _dbContext.SaveChanges();
            }

            if (!_dbContext.Advertisements.Any())
            {
                _dbContext.Advertisements.Add(new Models.Advertisements
                {
                    AdvertisementsId = 3001,
                    ImageUrl = "Resources/Images/anuncio1.png"
                });

                _dbContext.Advertisements.Add(new Models.Advertisements
                {
                    AdvertisementsId = 3002,
                    ImageUrl = "Resources/Images/anuncio2.png"
                });

                _dbContext.Advertisements.Add(new Models.Advertisements
                {
                    AdvertisementsId = 3003,
                    ImageUrl = "Resources/Images/anuncio3.png"
                });

                _dbContext.Advertisements.Add(new Models.Advertisements
                {
                    AdvertisementsId = 3004,
                    ImageUrl = "Resources/Images/anuncio4.png"
                });

                _dbContext.SaveChanges();
            }
        }
    }
}
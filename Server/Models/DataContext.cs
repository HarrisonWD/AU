namespace AU.Server.Models
{
    public partial class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<ProductType> ProductTypes { get; set; } = null!;
        public virtual DbSet<ProductVariant> ProductVariants { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Name=db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductVariant>()
                .HasKey(p => new {p.ProductId, p.ProductTypeId});

            modelBuilder.Entity<ProductType>().HasData(
                new ProductType { Id = 1, Name = "Default" },
                new ProductType { Id = 2, Name = "Small" },
                new ProductType { Id = 3, Name = "Medium"},
                new ProductType { Id = 4, Name = "Large"},
                new ProductType { Id = 5, Name= "XLarge"},
                new ProductType { Id = 6, Name= "Standard"}
            );

            modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 1,
                    Price = 14.99m,
                    OriginalPrice = 15.99m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    ProductTypeId = 1,
                    Price = 14.99m,
                    OriginalPrice = 15.99m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    ProductTypeId = 1,
                    Price = 14.99m,
                    OriginalPrice = 15.99m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 1,
                    Price = 14.99m,
                    OriginalPrice = 15.99m
                },
                new ProductVariant
                {
                    ProductId = 5,
                    ProductTypeId = 1,
                    Price = 14.99m,
                    OriginalPrice = 15.99m
                },
                new ProductVariant
                {
                    ProductId = 6,
                    ProductTypeId = 6,
                    Price = 249.99m,
                    OriginalPrice = 299.99m
                }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Hoodies",
                    Url = "hoodie"
                },
                new Category
                {
                    Id = 2,
                    Name = "Beanies",
                    Url = "beanie"
                },
                new Category
                {
                    Id = 3,
                    Name = "T-Shirts",
                    Url = "tshirt"
                },
                new Category
                {
                    Id = 4,
                    Name = "Mugs",
                    Url = "mug"
                },
                new Category
                {
                    Id = 5,
                    Name = "Chairs",
                    Url = "chair"
                }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Hoodie",
                    Description = "Warm and cosey, available in mutliple colours and sizes.",
                    Image = "hoodie",
                    CategoryId = 1,
                    Featured = true
                },
                new Product
                {
                    Id = 2,
                    Name = "Beanie",
                    Description = "Stylish headwear to keep warm as well as represent the team",
                    Image = "beanie",
                    CategoryId = 2,
                    Featured = true
                },
                new Product
                {
                    Id = 3,
                    Name = "Mug",
                    Description = "Customised and ergonimically designed mug for the warmest brews",
                    Image = "",
                    CategoryId = 4,
                    Featured = false
                },
                new Product
                {
                    Id = 4,
                    Name = "T-Shirt",
                    Description = "Stylish 2019 Edition Team T-Shirt",
                    Image = "tshirt",
                    CategoryId = 3,
                    Featured = false
                },
                new Product
                {
                    Id = 5,
                    Name = "Hoodie 2020E",
                    Description = "Styilish 2020 Edition Team Hoodie",
                    Image = "hoodie2020",
                    CategoryId = 1,
                    Featured = false
                },
                new Product
                {
                    Id = 6,
                    Name = "Secret Chair",
                    Description = "Secret Labs sponsor chair",
                    Image = "chair",
                    CategoryId = 5,
                    Featured = false
                }
            );
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

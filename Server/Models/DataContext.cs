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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Name=db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
                    Name = "Beanie",
                    Url = "beanie"
                },
                new Category
                {
                    Id = 3,
                    Name = "T-Shirt",
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
                    Price = 99.99m,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Name = "Beanie",
                    Description = "Stylish headwear to keep warm as well as represent the team",
                    Image = "beanie",
                    Price = 14.99m,
                    CategoryId = 2
                },
                new Product
                {
                    Id = 3,
                    Name = "Mug",
                    Description = "Customised and ergonimically designed mug for the warmest brews",
                    Image = "",
                    Price = 9.99m,
                    CategoryId = 4
                },
                new Product
                {
                    Id = 4,
                    Name = "T-Shirt",
                    Description = "Stylish 2019 Edition Team T-Shirt",
                    Image = "tshirt",
                    Price = 17.99m,
                    CategoryId = 3
                },
                new Product
                {
                    Id = 5,
                    Name = "Hoodie 2020E",
                    Description = "Styilish 2020 Edition Team Hoodie",
                    Image = "hoodie2020",
                    Price = 79.99m,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 6,
                    Name = "Secret Chair",
                    Description = "Secret Labs sponsor chair",
                    Image = "chair",
                    Price = 299.99m,
                    CategoryId = 5
                }
            );
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

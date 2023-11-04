namespace MediaStore.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                 new Product
                 {
                     Id = 1,
                     Title = "Suburbicon",
                     Description = "This is a terrible movie",
                     ImageUrl = "https://upload.wikimedia.org/wikipedia/en/0/09/Suburbicon.jpg",
                     Price = 2.99M
                 },
        new Product
        {
            Id = 2,
            Title = "Sliders (TV series)",
            Description = "Sliders is an American science fiction and fantasy television series created by Robert K. Weiss and Tracy Tormé. It was broadcast for five seasons between 1995 and 2000. The series follows a group of travelers as they use a wormhole to 'slide' between different parallel universes. Tracy Tormé, Robert K. Weiss, Leslie Belzberg, John Landis, David Peckinpah, Bill Dial and Alan Barnette served as executive producers at different times of the production. For its first two seasons, it was produced in Vancouver, British Columbia. It was filmed primarily in Los Angeles, California, in the last three seasons.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/e/e3/Sliders2.JPG",
            Price = 29.99M
        },
        new Product
        {
            Id = 3,
            Title = "Charmed",
            Description = "Charmed is an American fantasy drama television series created by Constance M. Burge and produced by Aaron Spelling and his production company Spelling Television, with Brad Kern serving as showrunner. The series was originally broadcast by The WB from October 7, 1998, until May 21, 2006",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/af/Charmedtitlelogo1.jpg",
            Price = 29.99M
        },
        new Product
        {
            Id = 4,
            Title = "Buffy The Vampire Slayer",
            Description = "Buffy the Vampire Slayer is a 1992 American comedy vampire film directed by Fran Rubel Kuzui and starring Kristy Swanson, Donald Sutherland, Paul Reubens, Rutger Hauer, Luke Perry, Hilary Swank, and David Arquette.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/9/90/Buffy_Season_%281%29.jpg",
            Price = 29.99M
        }
                );
        }
    }
}

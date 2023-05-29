using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace EF6SQLiteTutorial.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite("Data Source=D:\\database.db");
		}

		public DbSet<RpgCharacter> RpgCharacters => Set<RpgCharacter>();
    }
}

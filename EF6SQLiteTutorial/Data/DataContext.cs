﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace EF6SQLiteTutorial.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }	

		public DbSet<RpgCharacter> RpgCharacters => Set<RpgCharacter>();
    }
}

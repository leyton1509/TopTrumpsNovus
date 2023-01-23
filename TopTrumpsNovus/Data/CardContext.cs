using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TopTrumpsNovus.Models;

namespace TopTrumpsNovus.Data
{
    public class CardContext : DbContext
    {
        public CardContext (DbContextOptions<CardContext> options)
            : base(options)
        {
        }

        public DbSet<TopTrumpsNovus.Models.Card> Card { get; set; } = default!;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HQ_Lib;

namespace RazorPagesHeroes.Data
{
    public class RazorPagesHeroesContext : DbContext
    {
        public RazorPagesHeroesContext (DbContextOptions<RazorPagesHeroesContext> options)
            : base(options)
        {
        }

        public DbSet<HQ_Lib.Heroes> Heroes { get; set; } = default!;
        public DbSet<HQ_Lib.Weapon> Weapon { get; set; } = default!;
        public DbSet<HQ_Lib.Rough> Rough { get; set; } = default!;
        public DbSet<HQ_Lib.Item> Item { get; set; } = default!;
        public DbSet<HQ_Lib.Elf> Elf { get; set; } = default!;
        public DbSet<HQ_Lib.Dwarf> Dwarf { get; set; } = default!;
        public DbSet<HQ_Lib.Barbarian> Barbarian { get; set; } = default!;
    }
}

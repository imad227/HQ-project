using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HQ_Lib;
using RazorPagesHeroes.Data;

namespace HQ_Webb.Pages_Heroes
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesHeroes.Data.RazorPagesHeroesContext _context;

        public IndexModel(RazorPagesHeroes.Data.RazorPagesHeroesContext context)
        {
            _context = context;
        }

        public IList<Heroes> Heroes { get;set; } = default!;
        public IList<Item> Item { get;set; } = default!;
        public IList<Weapon> Weapon { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Heroes = await _context.Heroes.ToListAsync();
            Item = await _context.Item.ToListAsync();
            Weapon = await _context.Weapon.ToListAsync();
        }
    }
}

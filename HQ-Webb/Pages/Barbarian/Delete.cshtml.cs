using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HQ_Lib;
using RazorPagesHeroes.Data;

namespace HQ_Webb.Pages_Barbarian
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesHeroes.Data.RazorPagesHeroesContext _context;

        public DeleteModel(RazorPagesHeroes.Data.RazorPagesHeroesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Barbarian Barbarian { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var barbarian = await _context.Barbarian.FirstOrDefaultAsync(m => m.Id == id);

            if (barbarian == null)
            {
                return NotFound();
            }
            else
            {
                Barbarian = barbarian;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var barbarian = await _context.Barbarian.FindAsync(id);
            if (barbarian != null)
            {
                Barbarian = barbarian;
                _context.Barbarian.Remove(Barbarian);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("/Heroes/Index");
        }
    }
}

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
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesHeroes.Data.RazorPagesHeroesContext _context;

        public DeleteModel(RazorPagesHeroes.Data.RazorPagesHeroesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Heroes Heroes { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var heroes = await _context.Heroes.FirstOrDefaultAsync(m => m.Id == id);

            if (heroes == null)
            {
                return NotFound();
            }
            else
            {
                Heroes = heroes;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var heroes = await _context.Heroes.FindAsync(id);
            if (heroes != null)
            {
                Heroes = heroes;
                _context.Heroes.Remove(Heroes);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

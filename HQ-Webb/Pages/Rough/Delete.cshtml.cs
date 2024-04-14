using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HQ_Lib;
using RazorPagesHeroes.Data;

namespace HQ_Webb.Pages_Rough
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesHeroes.Data.RazorPagesHeroesContext _context;

        public DeleteModel(RazorPagesHeroes.Data.RazorPagesHeroesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Rough Rough { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rough = await _context.Rough.FirstOrDefaultAsync(m => m.Id == id);

            if (rough == null)
            {
                return NotFound();
            }
            else
            {
                Rough = rough;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rough = await _context.Rough.FindAsync(id);
            if (rough != null)
            {
                Rough = rough;
                _context.Rough.Remove(Rough);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("/Heroes/Index");
        }
    }
}

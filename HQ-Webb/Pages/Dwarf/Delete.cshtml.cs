using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HQ_Lib;
using RazorPagesHeroes.Data;

namespace HQ_Webb.Pages_Dwarf
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesHeroes.Data.RazorPagesHeroesContext _context;

        public DeleteModel(RazorPagesHeroes.Data.RazorPagesHeroesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Dwarf Dwarf { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dwarf = await _context.Dwarf.FirstOrDefaultAsync(m => m.Id == id);

            if (dwarf == null)
            {
                return NotFound();
            }
            else
            {
                Dwarf = dwarf;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dwarf = await _context.Dwarf.FindAsync(id);
            if (dwarf != null)
            {
                Dwarf = dwarf;
                _context.Dwarf.Remove(Dwarf);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("/Heroes/Index");
        }
    }
}

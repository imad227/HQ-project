using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HQ_Lib;
using RazorPagesHeroes.Data;

namespace HQ_Webb.Pages_Wizard
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesHeroes.Data.RazorPagesHeroesContext _context;

        public DeleteModel(RazorPagesHeroes.Data.RazorPagesHeroesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Wizard Wizard { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wizard = await _context.Wizard.FirstOrDefaultAsync(m => m.Id == id);

            if (wizard == null)
            {
                return NotFound();
            }
            else
            {
                Wizard = wizard;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wizard = await _context.Wizard.FindAsync(id);
            if (wizard != null)
            {
                Wizard = wizard;
                _context.Wizard.Remove(Wizard);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("/Heroes/Index");
        }
    }
}

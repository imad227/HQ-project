using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HQ_Lib;
using RazorPagesHeroes.Data;

namespace HQ_Webb.Pages_Weapon
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesHeroes.Data.RazorPagesHeroesContext _context;

        public DeleteModel(RazorPagesHeroes.Data.RazorPagesHeroesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Weapon Weapon { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var weapon = await _context.Weapon.FirstOrDefaultAsync(m => m.Id == id);

            if (weapon == null)
            {
                return NotFound();
            }
            else
            {
                Weapon = weapon;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var weapon = await _context.Weapon.FindAsync(id);
            if (weapon != null)
            {
                Weapon = weapon;
                _context.Weapon.Remove(Weapon);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("/Heroes/Index");
        }
    }
}

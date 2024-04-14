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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesHeroes.Data.RazorPagesHeroesContext _context;

        public DetailsModel(RazorPagesHeroes.Data.RazorPagesHeroesContext context)
        {
            _context = context;
        }

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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Puppy.Models;

namespace Lunas_mini_aussies_.PagesPuppies
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesPuppyDbContext _context;

        public DeleteModel(RazorPagesPuppyDbContext context)
        {
            _context = context;
        }

       [BindProperty]
      public Puppy Puppy { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Puppy == null)
            {
                return NotFound();
            }

            var puppy = await _context.Puppy.FirstOrDefaultAsync(m => m.PuppyID == id);

            if (puppy == null)
            {
                return NotFound();
            }
            else 
            {
                Puppy = puppy;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Puppy == null)
            {
                return NotFound();
            }
            var puppy = await _context.Puppy.FindAsync(id);

            if (puppy != null)
            {
                Puppy = puppy;
                _context.Puppy.Remove(Puppy);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

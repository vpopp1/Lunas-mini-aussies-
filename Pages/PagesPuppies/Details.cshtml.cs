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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesPuppyDbContext _context;

        public DetailsModel(RazorPagesPuppyDbContext context)
        {
            _context = context;
        }

      public Puppy Puppy { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Puppy == null)
            {
                return NotFound();
            }

            var puppy = await _context.Puppy.Include(m=> m.Client).FirstOrDefaultAsync(m => m.PuppyID == id);
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
    }
}

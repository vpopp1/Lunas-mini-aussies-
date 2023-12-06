using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Puppy.Models;

namespace Lunas_mini_aussies_.PagesPuppies
{
    public class EditModel : PageModel
    {
        private readonly RazorPagesPuppyDbContext _context;

        public EditModel(RazorPagesPuppyDbContext context)
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

            var puppy =  await _context.Puppy.FirstOrDefaultAsync(m => m.PuppyID == id);
            if (puppy == null)
            {
                return NotFound();
            }
            Puppy = puppy;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Puppy).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PuppyExists(Puppy.PuppyID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PuppyExists(int id)
        {
          return (_context.Puppy?.Any(e => e.PuppyID == id)).GetValueOrDefault();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Puppy.Models;

namespace Lunas_mini_aussies_.PagesPuppies
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesPuppyDbContext _context;

        public CreateModel(RazorPagesPuppyDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Puppy Puppy { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Puppy == null || Puppy == null)
            {
                return Page();
            }

#pragma warning disable CS8602 // Dereference of a possibly null reference.
            _context.Puppy.Add(Puppy);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

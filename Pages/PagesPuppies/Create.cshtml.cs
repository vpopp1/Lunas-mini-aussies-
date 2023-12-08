using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Lunas_mini_aussies.Models;

namespace Lunas_mini_aussies_.PagesPuppies
{
    public class CreateModel : PageModel
    {
        private readonly Lunas_mini_aussies.Models.PuppyDbContext _context;

        public CreateModel(Lunas_mini_aussies.Models.PuppyDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ClientID"] = new SelectList(_context.Client, "ClientID", "CName");
            return Page();
        }

        [BindProperty]
        public Puppy Puppy { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Puppies == null || Puppy == null)
            {
                return Page();
            }

            _context.Puppies.Add(Puppy);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

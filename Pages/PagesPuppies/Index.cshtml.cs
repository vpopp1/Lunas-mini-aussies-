using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lunas_mini_aussies.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lunas_mini_aussies_.PagesPuppies
{
    public class IndexModel : PageModel
    {
        private readonly Lunas_mini_aussies.Models.PuppyDbContext _context;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public IndexModel(Lunas_mini_aussies.Models.PuppyDbContext context)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            _context = context;
        }

        public IList<Puppy> Puppy { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public int PageNum {get;set;} = 1;

        public int PageSize {get;set;} =10;

        [BindProperty(SupportsGet = true)]
        public string? CurrentSort {get;set;}
        public SelectList SortPups {get; set;}



        public async Task OnGetAsync()
        {
           if (_context.Puppies != null)
            {
                List<SelectListItem> sortItems = new List<SelectListItem> {
	            new SelectListItem { Text = "First Name Ascending", Value = "first_asc" },
	            new SelectListItem { Text = "First Name Descending", Value = "first_desc"},
                new SelectListItem { Text = "Mom", Value = "third_asc" },
	            new SelectListItem { Text = "Height Descending", Value = "fourth_desc"},
                };
            SortPups = new SelectList(sortItems, "Value", "Text", CurrentSort);

                Puppy = await _context.Puppies.Include(p => p.Client).ToListAsync(); 
                Puppy = await _context.Puppies.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
            }
        }
    
    }
}

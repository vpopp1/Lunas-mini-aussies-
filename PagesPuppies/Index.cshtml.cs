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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesPuppyDbContext _context;

        public IndexModel(RazorPagesPuppyDbContext context)
        {
            _context = context;
        }

        public IList<Puppy> Puppy { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Puppy != null)
            {
                Puppy = await _context.Puppy.ToListAsync();
            }
        }
    }
}

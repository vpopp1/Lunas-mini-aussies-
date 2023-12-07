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
    public class CurrentModel : PageModel
    {
        private readonly RazorPagesPuppyDbContext _context;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public CurrentModel(RazorPagesPuppyDbContext context)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            _context = context;
        }

        public IList<Client> Client { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public int PageNumC {get;set;} = 1;

        public int PageSizeC {get;set;} =10;

        public async Task OnGetAsync()
        {
            if (_context.Client != null)
            {
                Client = await _context.Client.Include(c => c.Puppys).Skip((PageNumC-1)*PageSizeC).Take(PageSizeC).ToListAsync();
            }
        }

    }
}

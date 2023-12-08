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
    public class AddClientModel : PageModel
    {
        private readonly ILogger<AddClientModel> _logger;
        private readonly PuppyDbContext _context;
        [BindProperty]
        public Client Client {get; set;} = default!;
        public SelectList PuppiesDropDown {get; set;} = default!;

        public AddClientModel(PuppyDbContext context, ILogger<AddClientModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            PuppiesDropDown = new SelectList(_context.Puppies.Include(p => p.Client).Where(p => p.Client==null).ToList(), "PuppyId", "Name");
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Client.Add(Client);
            _context.SaveChanges();

            return RedirectToPage("./Index");
        }
    }
}
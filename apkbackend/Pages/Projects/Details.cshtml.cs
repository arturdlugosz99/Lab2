using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using apkbackend.Data;
using apkbackend.Pages.Models;

namespace apkbackend.Pages.Projects
{
    public class DetailsModel : PageModel
    {
        private readonly apkbackend.Data.apkbackendContext _context;

        public DetailsModel(apkbackend.Data.apkbackendContext context)
        {
            _context = context;
        }

      public Project Project { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Project = await _context.Project.FirstOrDefaultAsync(m => m.Id == id);

            if (Project == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

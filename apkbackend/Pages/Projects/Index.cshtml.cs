using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using apkbackend.Data;
using apkbackend.Pages.Models;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace apkbackend.Pages.Projects
{
    public class IndexModel : PageModel
    {
        private readonly apkbackend.Data.apkbackendContext _context;

        public IndexModel(apkbackend.Data.apkbackendContext context)
        {
            _context = context;
        }

        public IList<Project> Project { get;set; } = default!;
        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }
        public SelectList? Genres { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? MovieGenre { get; set; }

        public async Task OnGetAsync()
        {
            var movies = from m in _context.Project
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.Nazwa.Contains(SearchString));
            }

            Project = await movies.ToListAsync();
        }
    }
}

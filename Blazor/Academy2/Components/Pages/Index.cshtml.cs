using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Academy2.Data;
using Academy2.Models;

namespace Academy2.Components.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Academy2.Data.Academy2Context _context;

        public IndexModel(Academy2.Data.Academy2Context context)
        {
            _context = context;
        }

        public IList<Direction> Direction { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Direction = await _context.Directions.ToListAsync();
        }
    }
}

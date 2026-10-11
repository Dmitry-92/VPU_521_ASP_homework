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
    public class DetailsModel : PageModel
    {
        private readonly Academy2.Data.Academy2Context _context;

        public DetailsModel(Academy2.Data.Academy2Context context)
        {
            _context = context;
        }

        public Direction Direction { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var direction = await _context.Directions.FirstOrDefaultAsync(m => m.directionId == id);

            if (direction is not null)
            {
                Direction = direction;

                return Page();
            }

            return NotFound();
        }
    }
}

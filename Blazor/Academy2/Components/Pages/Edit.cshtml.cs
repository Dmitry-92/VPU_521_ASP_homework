using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Academy2.Data;
using Academy2.Models;

namespace Academy2.Components.Pages
{
    public class EditModel : PageModel
    {
        private readonly Academy2.Data.Academy2Context _context;

        public EditModel(Academy2.Data.Academy2Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Direction Direction { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var direction =  await _context.Directions.FirstOrDefaultAsync(m => m.directionId == id);
            if (direction == null)
            {
                return NotFound();
            }
            Direction = direction;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Direction).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DirectionExists(Direction.directionId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool DirectionExists(byte id)
        {
            return _context.Directions.Any(e => e.directionId == id);
        }
    }
}

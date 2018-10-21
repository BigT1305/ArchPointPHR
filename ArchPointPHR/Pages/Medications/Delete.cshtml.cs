using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ArchPointPHR.Models;

namespace ArchPointPHR.Pages.Medications
{
    public class DeleteModel : PageModel
    {
        private readonly ArchPointPHR.Models.ArchPointPHRContext _context;

        public DeleteModel(ArchPointPHR.Models.ArchPointPHRContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Medication Medication { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Medication = await _context.Medication.FirstOrDefaultAsync(m => m.ID == id);

            if (Medication == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Medication = await _context.Medication.FindAsync(id);

            if (Medication != null)
            {
                _context.Medication.Remove(Medication);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

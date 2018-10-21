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
    public class IndexModel : PageModel
    {
        private readonly ArchPointPHR.Models.ArchPointPHRContext _context;

        public IndexModel(ArchPointPHR.Models.ArchPointPHRContext context)
        {
            _context = context;
        }

        public IList<Medication> Medication { get;set; }

        public async Task OnGetAsync()
        {
            Medication = await _context.Medication.ToListAsync();
        }
    }
}

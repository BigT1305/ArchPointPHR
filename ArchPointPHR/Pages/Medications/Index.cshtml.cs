using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ArchPointPHR.Models;
using Microsoft.AspNetCore.Mvc.Rendering;



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
        public SelectList Name { get; set; }
        public string MedClassification { get; set; }

        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public async Task OnGetAsync(string medClassification, string searchString)
        {
            //Use LINQ to generate Classifications
            IQueryable<string> classficationQuery = from m in _context.Medication
                                                    orderby m.Name
                                                    select m.Name;
            //using System.Linq
            var medications = from m in _context.Medication
                              select m;
            if (!String.IsNullOrEmpty(searchString))
            {
                medications = medications.Where(s => s.Name.Contains(searchString));
            }
            if(!String.IsNullOrEmpty(medClassification))
            {
                medications = medications.Where(x => x.Name == medClassification);
            }
            Name = new SelectList(await classficationQuery.Distinct().ToListAsync());
            Medication = await _context.Medication.ToListAsync();
        }
    }
}

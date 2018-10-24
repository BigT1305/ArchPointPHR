using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ArchPointPHR.Pages.Medications
{
    public class MedicationsPageModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int ID { get; set; }
        public void OnGet(int id)
        {
        }
         
    }
}
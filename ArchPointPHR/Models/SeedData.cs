using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace ArchPointPHR.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ArchPointPHRContext(
                 serviceProvider.GetRequiredService<DbContextOptions<ArchPointPHRContext>>()))
            {
                //Look for any medication
                if (context.Medication.Any())
                {
                    return;     //DB has been seeded

                }

                context.Medication.AddRange(
                    new Medication
                    {
                        Name = "Lipitor",
                        Physician = "John Dee, MD",
                        Quantity = 2,
                        Dosage = "20mg",
                        Reason = "",
                        Type = "Cholesterol Medication"
                    },

                    new Medication
                    {
                        Name = "Plavix",
                        Physician = "John Dee, MD",
                        Quantity = 2,
                        Dosage = "30mg",
                        Reason = "",
                        Type = "Heart and Stroke"
                    },

                    new Medication
                    {
                        Name = "Celebrex",
                        Physician = "John Dee, MD",
                        Quantity = 2,
                        Dosage = "200mg",
                        Reason = "",
                        Type = "Arthritis"
                    }
                   );
                context.SaveChanges();

            }
        }
    }
}

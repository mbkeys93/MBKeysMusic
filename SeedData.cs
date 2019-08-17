using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MBKeysMusic.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MBKeysMusicContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MBKeysMusicContext>>()))
            {
                // Look for any movies.
                if (context.Gig.Any())
                {
                    return;   // DB has been seeded
                }

                context.Gig.AddRange(
                    new Gig
                    { 
                        Name = "GSU Recital",
                        Description = "Playing for my friend's recital for school.",
                        Payment = 0M,
                        PerformanceDate = DateTime.Parse("2019-2-21"),
                        Practices = 3                
                    },

                    new Gig
                    {
                        Name = "Youth Service",
                        Description = "Playing for teen/children's church every week.",
                        Payment = 200M,
                        PerformanceDate = DateTime.Parse("2019-2-17"),
                        Practices = 1,
                    },

                    new Gig
                    {
                        Name = "Wedding",
                        Description = "Playing for a wedding.",
                        Payment = 200M,
                        PerformanceDate = DateTime.Parse("2019-3-21"),
                        Practices = 3,
                    },

                    new Gig
                    {
                        Name = "Club Gig",
                        Description = "Playing at a club/bar.",
                        Payment = 200M,
                        PerformanceDate = DateTime.Parse("2019-4-21"),
                        Practices = 2,
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

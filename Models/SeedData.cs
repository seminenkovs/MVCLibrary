using Microsoft.EntityFrameworkCore;
using MVCLibrary.Data;

namespace MVCLibrary.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider service)
        {
            using (var context = new LibraryContext(
                
                service.GetRequiredService<DbContextOptions<LibraryContext>>()))
            {
                if (context.Book.Any())
                {
                    return;
                }

                context.Book.AddRange(
                    new Book { Title = "Tiny C4 book", CallNumber = "Axd 38947" },
                    new Book { Title = "Blazor book", CallNumber = "df H454"},
                    new Book { Title = "Fire Bird", CallNumber = " ABC 37"},
                    new Book { Title = "Fairy tail", CallNumber = " pio 373737"}
                );

                context.SaveChanges();

            }
        }
    }
}

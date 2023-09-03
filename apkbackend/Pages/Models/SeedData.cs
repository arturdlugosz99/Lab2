using Microsoft.EntityFrameworkCore;
using apkbackend.Data;
using apkbackend.Pages.Models;

namespace RazorPagesMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new apkbackendContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<apkbackendContext>>()))
        {
            if (context == null || context.Project == null)
            {
                throw new ArgumentNullException("Null ProjectContext");
            }

            // Look for any movies.
            if (context.Project.Any())
            {
                return;   // DB has been seeded
            }

            context.Project.AddRange(
                new Project
                {
                    Nazwa = "Java project",
                    Data_zgloszenia = DateTime.Parse("2023-06-01"),
                    status = "done",
                    Opiekun = "Jan Kowalski"

                },

                new Project
                {
                    Nazwa = "Python project",
                    Data_zgloszenia = DateTime.Parse("2023-06-02"),
                    status = "in progress",
                    Opiekun = "Jan Kowalski"

                },

                new Project
                {
                    Nazwa = "C# project",
                    Data_zgloszenia = DateTime.Parse("2023-06-03"),
                    status = "paused",
                    Opiekun = "Jan Kowalski"

                }


            );
            context.SaveChanges();
        }
    }
}
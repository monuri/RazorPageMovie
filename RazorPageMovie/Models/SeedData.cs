using Humanizer.Localisation;
using Microsoft.EntityFrameworkCore;
using RazorPageMovie.Data;

namespace RazorPageMovie.Models
{
    public class SeedData
    {
        public static void initialize(IServiceProvider serviceProvider)
        {
            using (var context=new RazorPageMovieContext1(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPageMovieContext1>>()
                ) )
            {
                if( context == null || context.Movie == null) { 
                    throw new ArgumentNullException( "Null context RazorPages Movies" );
                }

                if( context.Movie.Any() ) {
                    //la base de datos retorna todo lo que contiene esta clase
                    return;
                }

                context.Movie.AddRange(
                     new Movie
                     {
                         Title = "When harry meeet Sally",
                         ReleaseDate = DateTime.Parse("1984-3-13"),
                         Genre = "Comedy",
                         Price = 8.99M,
                         Rating="R"
                     },

                    new Movie
                    {
                        Title= "Ghostbusters 1",
                        ReleaseDate=DateTime.Parse("1984-3-13"),
                        Genre="Comedy",
                        Price=8.99M,
                        Rating = "R"
                    },
                     new Movie
                     {
                    Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1989-2-23"),
                        Genre = "Comedy",
                        Price =9.99M,
                         Rating = "G"
                     },
                    new Movie
                      {
                        Title = "Rrio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "western",
                        Price =3.99M,
                        Rating = "NA"
                    }

                    );
                context.SaveChanges();
            }
        }
    }
}

namespace BasicBlazorMovieApp.Services
{
    public class MovieReviewService : IMovieReviewService
    {
        public static readonly List<MovieModel> Movies = new List<MovieModel>
        {
            new MovieModel
            {
                Id = 1,
                Title = "Police Academy 6",
                Description = "Ut vitae venenatis eros, vel tincidunt nibh. Sed ac bibendum orci, interdum semper augue.",
                ImageUrl = "/images/movies/PoliceAcademy6.png",
                Review = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer sed aliquet tortor. Ut vitae venenatis eros, vel tincidunt nibh. Sed ac bibendum orci, interdum semper augue. Integer volutpat odio quis nunc convallis, in placerat nibh congue."
            },

            new MovieModel{
                Id=2,
                Title = "Godfather",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vitae nunc risus. ",
                ImageUrl = "/images/movies/Godfather.png",
                Review = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vitae nunc risus. Cras sed ex augue. Etiam rutrum massa at enim sollicitudin scelerisque. Pellentesque dignissim, velit vitae lacinia"
            },
            new MovieModel{
                Id=3,
                Title = "Last of the Mohicans",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vitae nunc risus. ",
                ImageUrl = "/images/movies/LastOfTheMohicans.png",
                Review = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vitae nunc risus. Cras sed ex augue. Etiam rutrum massa at enim sollicitudin scelerisque. Pellentesque dignissim, velit vitae lacinia"
            },
            new MovieModel{
                Id=4,
                Title = "Rear Window",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vitae nunc risus. ",
                ImageUrl = "/images/movies/RearWindow.png",
                Review = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vitae nunc risus. Cras sed ex augue. Etiam rutrum massa at enim sollicitudin scelerisque. Pellentesque dignissim, velit vitae lacinia"
            },
            new MovieModel{
                Id=5,
                Title = "Road House",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vitae nunc risus. ",
                ImageUrl = "/images/movies/RoadHouse.png",
                Review = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vitae nunc risus. Cras sed ex augue. Etiam rutrum massa at enim sollicitudin scelerisque. Pellentesque dignissim, velit vitae lacinia"
            },
            new MovieModel{
                Id=6,
                Title = "Star Treck IV",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vitae nunc risus. ",
                ImageUrl = "/images/movies/StarTreck4.png",
                Review = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vitae nunc risus. Cras sed ex augue. Etiam rutrum massa at enim sollicitudin scelerisque. Pellentesque dignissim, velit vitae lacinia"
            }
            };
        public MovieModel GetMovieById(int id)
        {
            return Movies.SingleOrDefault(m => m.Id == id);
        }

        public List<MovieModel>? GetMovies()
        {
            return Movies;

        }
    }
}

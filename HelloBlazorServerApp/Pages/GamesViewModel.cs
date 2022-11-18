using HelloBlazorServerApp.Models;

namespace HelloBlazorServerApp.Pages
{
    public class GamesViewModel
    {
        public List<Game> Games { get; set; } = new List<Game>();

        public async void LoadGamesAsync()
        {
            await Task.Delay(3000);
            Games = new List<Game>
            {
                new Game()
                {
                    Name = "Farming simulator",
                    Genre = "simulator",
                    ReleaseDate = new DateTime(2018,11,19)
                },
                new Game()
                {
                    Name = "Destroy All Humans!",
                    Genre = "Action Adventure",
                    ReleaseDate = new DateTime(2020,07,12)
                },
                new Game()
                {
                    Name = "The Weather Three",
                    Genre = "Action/RPG",
                    ReleaseDate = new DateTime(2015,05,18)
                },
            };

            Console.WriteLine(Games.Count);
        }
    }
}

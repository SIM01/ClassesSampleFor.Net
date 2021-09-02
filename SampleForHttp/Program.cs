using System;
using System.Linq;
using System.Threading.Tasks;
using SampleForHttp.Models;
using SampleForHttp.Service;

namespace SampleForHttp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string token =
                "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1c2VyIjoi0JHQvtCz0LTQsNC9IiwidGVuYW50IjoiNzI5IiwibmJmIjoxNjI5OTk0MTcxLCJleHAiOjE2MzAwODA1NzEsImlzcyI6IlRlc3QtQmFja2VuZC0xIiwiYXVkIjoiQmFza2V0QmFsbENsdWJTYW1wbGUifQ.bajWd2_y9qFbWLsGrAAQayxg2GPbg-USKUVKLhGYOyU";
            TeamService teamService = new TeamService(token);
            Team team = new Team()
            {
                Id = 1123,
                Name = "Arsenall",
                FoundationYear = 2006,
                Division = "abc",
                Conference = "A",
                ImageUrl = "myImage"
            };
            //await teamService.Add(team);

            var findteams = await teamService.GetTeams(team.Name);
            var findteam= findteams.Teams.Where(p => p.Name.ToUpper().Contains(team.Name)).SingleOrDefault();

            PlayerService playerService = new PlayerService(token);
            Player player = new Player()
            {
                Id = 42069,
                Name = "Bekhem The Second",
                Number = 69,
                Position = "Guard",
                Team = findteam.Id,
                Birthday = DateTime.Now,
                Height = 80,
                Weight = 200,
                AvatarUrl = "Picture.png"
            };
            await playerService.Add(player);

            await playerService.GetPlayers();
        }
    }
}
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SampleForHttp.Models;

namespace SampleForHttp.Service
{
    public class TeamService
    {
        private readonly string _token;

        public TeamService(string token)
        {
            _token = token ?? throw new ArgumentException(nameof(token));
        }

        public async Task Add(Team team)
        {
            string serializedTeam = JsonConvert.SerializeObject(team);
            var content = new StringContent(serializedTeam, Encoding.UTF8, "application/json");
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = AuthenticationHeaderValue.Parse(_token);
                await client.PostAsync("http://dev.trainee.dex-it.ru/api/Team/Add", content);
            }
        }

        public async Task<TeamResponse> GetTeams(string name=null)
        {
            HttpResponseMessage responseMessage;
            TeamResponse teamResponse;
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = AuthenticationHeaderValue.Parse(_token);
                string url = "http://dev.trainee.dex-it.ru/api/Team/GetTeams";
                if (name != null)
                {
                    url = url + "?Name="+name;
                }

                responseMessage = await client.GetAsync(url);
                responseMessage.EnsureSuccessStatusCode();
                string serializeMessage = await responseMessage.Content.ReadAsStringAsync();
                teamResponse = JsonConvert.DeserializeObject<TeamResponse>(serializeMessage);
            }

            return teamResponse;
        }
        
    }
}
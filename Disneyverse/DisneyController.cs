using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Disneyverse.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Disneyverse
{
    [ApiController]
    [Route("[api]")]
    public class DisneyController : ControllerBase
    {
        private readonly HttpClient _httpClient;


        public DisneyController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpGet("/api/characters")]
        public async Task<DisneyCharacterResponse> GetDisneyCharacters(int pageSize)
        {
            var response = await _httpClient.GetAsync($"https://api.disneyapi.dev/characters?page_size={pageSize}");

            response.EnsureSuccessStatusCode();

            using var responseStream = await response.Content.ReadAsStreamAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var charactersResponse = await JsonSerializer.DeserializeAsync<DisneyCharacterResponse>(responseStream, options);

            return charactersResponse;
        }
    }
}

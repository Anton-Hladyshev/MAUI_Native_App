using System.Net.Http.Json;
using AntonLeoApp.Model.Dtos;

namespace AntonLeoApp.Model.Services;

public class AppService: IAppService
{
    private readonly HttpClient _httpClient;
    
    public AppService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<CharacterDto>> GetCharacters()
    {
        try
        {
            var dto = await _httpClient.GetFromJsonAsync<List<CharacterDto>>(AppSettings.API_DEFAULT_URL + "characters");

            if (dto == null) return null;
            
            return dto;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<CharacterDto> GetCharacter(string characterId)
    {
        try
        {
            var dto = await _httpClient.GetFromJsonAsync<CharacterDto>(AppSettings.API_DEFAULT_URL + characterId);
            
            if (dto == null) return null;
            
            return dto;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
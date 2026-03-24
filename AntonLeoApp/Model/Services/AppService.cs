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
            var dto = await _httpClient.GetFromJsonAsync<ApiResponse<List<CharacterDto>>>(AppSettings.API_DEFAULT_URL + "characters");

            if (dto?.Data == null) return null;
            
            return dto.Data;
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
    
    public async Task<CreatureDto> GetCreature(string creatureId)
    {
        try
        {
            var dto = await _httpClient.GetFromJsonAsync<CreatureDto>(AppSettings.API_DEFAULT_URL + creatureId);
            
            if (dto == null) return null;
            
            return dto;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    public async Task<List<CreatureDto>> GetCreatures()
    {
        try
        {
            var dto = await _httpClient.GetFromJsonAsync<ApiResponse<List<CreatureDto>>>(AppSettings.API_DEFAULT_URL + "creatures");

            if (dto?.Data == null) return null;
            
            return dto.Data;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    public async Task<DroidDto> GetDroid(string creatureId)
    {
        try
        {
            var dto = await _httpClient.GetFromJsonAsync<DroidDto>(AppSettings.API_DEFAULT_URL + creatureId);
            
            if (dto == null) return null;
            
            return dto;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    public async Task<List<DroidDto>> GetDroids()
    {
        try
        {
            var dto = await _httpClient.GetFromJsonAsync<ApiResponse<List<DroidDto>>>(AppSettings.API_DEFAULT_URL + "droids");

            if (dto?.Data == null) return null;
            
            return dto.Data;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
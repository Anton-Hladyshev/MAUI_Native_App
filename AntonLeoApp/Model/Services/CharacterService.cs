using AntonLeoApp.Model.Dtos;

namespace AntonLeoApp.Model.Services;

public class CharacterService(HttpClient httpClient) : AppServiceSupper(httpClient)
{
    public async Task<ApiResponse<List<CharacterDto>>?> GetCharacters(int page = 1, int limit = 10)
    {
        return await GetAll<CharacterDto>("characters", page, limit);
    }

    public async Task<CharacterDto?> GetCharacter(string id)
    {
        return await GetById<CharacterDto>(id);
    }
}
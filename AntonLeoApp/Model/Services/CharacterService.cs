using AntonLeoApp.Model.Dtos;

namespace AntonLeoApp.Model.Services;

public class CharacterService(HttpClient httpClient) : AppServiceSupper(httpClient)
{
    public async Task<ApiResponse<List<CharacterDto>>?> GetCharacters()
    {
        return await GetAll<CharacterDto>("characters");
    }

    public async Task<CharacterDto?> GetCharacter(string id)
    {
        return await GetById<CharacterDto>(id);
    }
}
using AntonLeoApp.Model.Dtos;

namespace AntonLeoApp.Model.Services;

public class CreatureService(HttpClient httpClient) : AppServiceSupper(httpClient)
{
    public async Task<ApiResponse<List<CreatureDto>>?> GetCreatures()
    {
        return await GetAll<CreatureDto>("creatures");
    }

    public async Task<CreatureDto?> GetCreature(string id)
    {
        return await GetById<CreatureDto>(id);
    }
}
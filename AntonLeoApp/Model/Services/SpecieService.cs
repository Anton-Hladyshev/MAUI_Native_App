using AntonLeoApp.Model.Dtos;

namespace AntonLeoApp.Model.Services;

public class SpecieService(HttpClient httpClient) : AppServiceSupper(httpClient)
{
    public async Task<ApiResponse<List<SpecieDto>>?> GetSpecies()
    {
        return await GetAll<SpecieDto>("species");
    }

    public async Task<SpecieDto?> GetSpecie(string id)
    {
        return await GetById<SpecieDto>(id);
    }
}
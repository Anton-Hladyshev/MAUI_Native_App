using AntonLeoApp.Model.Dtos;

namespace AntonLeoApp.Model.Services;

public class DroidService(HttpClient httpClient) : AppServiceSupper(httpClient)
{
    public async Task<ApiResponse<List<DroidDto>>?> GetDroids()
    {
        return await GetAll<DroidDto>("droids");
    }

    public async Task<DroidDto?> GetDroid(string id)
    {
        return await GetById<DroidDto>(id);
    }
}
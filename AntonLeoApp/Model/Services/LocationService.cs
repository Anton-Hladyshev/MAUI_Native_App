using AntonLeoApp.Model.Dtos;

namespace AntonLeoApp.Model.Services;

public class LocationService(HttpClient httpClient) : AppServiceSupper(httpClient)
{
    public async Task<ApiResponse<List<LocationDto>>?> GetLocations()
    {
        return await GetAll<LocationDto>("locations");
    }

    public async Task<LocationDto?> GetLocation(string id)
    {
        return await GetById<LocationDto>(id);
    }
}
using AntonLeoApp.Model.Dtos;

namespace AntonLeoApp.Model.Services;

public class VehicleService(HttpClient httpClient) : AppServiceSupper(httpClient)
{
    public async Task<ApiResponse<List<VehicleDto>>?> GetVehicles()
    {
        return await GetAll<VehicleDto>("vehicles");
    }

    public async Task<VehicleDto?> GetVehicle(string id)
    {
        return await GetById<VehicleDto>(id);
    }
}
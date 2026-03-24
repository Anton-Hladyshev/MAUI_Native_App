using AntonLeoApp.Model.Dtos;

namespace AntonLeoApp.Model.Services;

public class OrganizationService(HttpClient httpClient) : AppServiceSupper(httpClient)
{
    public async Task<ApiResponse<List<OrganizationDto>>?> GetOrganizations()
    {
        return await GetAll<OrganizationDto>("organizations");
    }

    public async Task<OrganizationDto?> GetOrganization(string id)
    {
        return await GetById<OrganizationDto>(id);
    }
}
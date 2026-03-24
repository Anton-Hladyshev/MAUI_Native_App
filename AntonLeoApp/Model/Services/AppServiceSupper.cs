using System.Net.Http.Json;
using AntonLeoApp.Model.Dtos;

namespace AntonLeoApp.Model.Services;

public abstract class AppServiceSupper(HttpClient httpClient)
{
    protected async Task<ApiResponse<List<T>>?> GetAll<T>(string endpoint, int page = 1, int limit = 10) where T : IDto
    {
        try
        {
            var dto = await httpClient.GetFromJsonAsync<ApiResponse<List<T>>>(AppSettings.API_DEFAULT_URL + endpoint + "?page=" + page + "&limit=" + limit);

            return dto;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    protected async Task<T?> GetById<T>(string id) where T : IDto
    {
        try
        {
            var dto = await httpClient.GetFromJsonAsync<T>(AppSettings.API_DEFAULT_URL + id);
            
            return dto;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
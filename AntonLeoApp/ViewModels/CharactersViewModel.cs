using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using AntonLeoApp.Model.Services;
using System.Text.Json;
using System.Threading.Tasks;

namespace AntonLeoApp.ViewModels;

public partial class CharactersViewModel : ObservableObject
{
    private readonly IAppService _appService;

    [ObservableProperty]
    private string _rawJsonResponse;

    public CharactersViewModel(IAppService appService)
    {
        _appService = appService;
    }

    [RelayCommand]
    public async Task CheckApi()
    {
        var data = await _appService.GetCharacters();

        if (data != null)
        {
            RawJsonResponse = JsonSerializer.Serialize(data, new JsonSerializerOptions 
            { 
                WriteIndented = true
            });
        }
        else
        {
            RawJsonResponse = "Error: No data retrieved";
        }
    }
}

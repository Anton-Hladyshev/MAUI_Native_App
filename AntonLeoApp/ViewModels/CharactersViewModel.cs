using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using AntonLeoApp.Model.Services;
using System.Text.Json;
using System.Threading.Tasks;

namespace AntonLeoApp.ViewModels;

public partial class CharactersViewModel : ObservableObject
{
    private readonly CharacterService _characterService;

    [ObservableProperty]
    private string? _rawJsonResponse;

    public CharactersViewModel(CharacterService characterService)
    {
        _characterService = characterService;
    }

    [RelayCommand]
    public async Task CheckApi()
    {
        var data = await _characterService.GetCharacters();

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

using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using AntonLeoApp.Model.Dtos;
using AntonLeoApp.Model.Services;

namespace AntonLeoApp.ViewModels;

public partial class CharactersViewModel : ObservableObject
{
    private readonly CharacterService _characterService;
    
    public ObservableCollection<CharacterDto> Characters { get; } = new();
    
    [ObservableProperty]
    private bool _isLoading;

    [ObservableProperty]
    private bool _isRefreshing;

    public CharactersViewModel(CharacterService characterService)
    {
        _characterService = characterService;
    }

    [RelayCommand]
    public async Task LoadCharacters()
    {
        if (IsLoading) return;

        try
        {
            IsLoading = true;
            var response = await _characterService.GetCharacters();

            if (response?.Data != null)
            {
                Characters.Clear();
                foreach (var character in response.Data)
                {
                    Characters.Add(character);
                }
            }
        }
        finally
        {
            IsLoading = false;
        }
    }

    [RelayCommand]
    public async Task GoToDetails(CharacterDto character)
    {
        if (character == null) return;

        // Navigation vers la page de détails en passant l'objet
        await Shell.Current.GoToAsync("CharacterDetailsPage", new Dictionary<string, object>
        {
            { "Character", character }
        });
    }
}
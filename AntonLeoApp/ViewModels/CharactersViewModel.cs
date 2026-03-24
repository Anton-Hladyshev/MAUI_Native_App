using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using AntonLeoApp.Model.Dtos;
using AntonLeoApp.Model.Services;

namespace AntonLeoApp.ViewModels;

public partial class CharactersViewModel : ObservableObject
{
    private readonly CharacterService _characterService;
    private int _currentPage = 1;
    private bool _hasMoreData = true;
    private bool _isFirstLoad = true;
    
    public ObservableCollection<CharacterDto> Characters { get; } = new();
    
    [ObservableProperty]
    private bool _isLoading;
    
    [ObservableProperty]
    private bool _isLoadingMore;

    public CharactersViewModel(CharacterService characterService)
    {
        _characterService = characterService;
    }
    
    [RelayCommand]
    public async Task InitialLoad()
    {
        if (!_isFirstLoad || Characters.Count > 0) return;

        IsLoading = true;
        await LoadData();
        _isFirstLoad = false;
        IsLoading = false;
    }
    
    [RelayCommand]
    public async Task LoadMore()
    {
        if (IsLoading || IsLoadingMore || !_hasMoreData) return;

        IsLoadingMore = true;
        _currentPage++;
        await LoadData();
        IsLoadingMore = false;
    }
    
    private async Task LoadData()
    {
        try
        {
            var response = await _characterService.GetCharacters(_currentPage, 10);

            if (response?.Data != null && response.Data.Any())
            {
                foreach (var character in response.Data)
                {
                    if (!Characters.Any(c => c.Id == character.Id))
                    {
                        Characters.Add(character);
                    }
                }
                
                if (response.Data.Count < 10)
                {
                    _hasMoreData = false;
                }
            }
            else
            {
                _hasMoreData = false;
            }
        }
        catch (Exception ex)
        {
            _currentPage--;
            Console.WriteLine($"Erreur API: {ex.Message}");
        }
    }

    [RelayCommand]
    public async Task GoToDetails(CharacterDto character)
    {
        if (character == null) return;
        
        await Shell.Current.GoToAsync("CharacterDetailsPage", new Dictionary<string, object>
        {
            { "Character", character }
        });
    }
}
using AntonLeoApp.Model.Services.UserIO;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AntonLeoApp.ViewModels;

public partial class UserIOViewModel: ObservableObject
{
    [ObservableProperty] private string name;
    [ObservableProperty] private string description;
    [ObservableProperty] private string image;

    private readonly UserIOController _controller = new();

    [RelayCommand]
    async Task AddCharacter()
    {
        var character = UserCharacter.CreateBuilder()
            .WithName(name)
            .WithDescription(description)
            .WithImage(image)
            .Build();
        
        await _controller.SaveCharacterAsync(character);
    }
}
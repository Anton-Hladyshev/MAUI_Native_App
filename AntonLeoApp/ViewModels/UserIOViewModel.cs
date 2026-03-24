using AntonLeoApp.Model.Services.UserIO;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AntonLeoApp.ViewModels;

public partial class UserIOViewModel: ObservableObject
{
    [ObservableProperty] 
    private string name;
    
    [ObservableProperty] 
    private string description;
    
    [ObservableProperty] 
    [NotifyPropertyChangedFor(nameof(HasPhoto))]
    private string image;

    private readonly UserIOController _controller = new();

    public bool HasPhoto => !string.IsNullOrEmpty(Image);
    public string PhotoStatusText => HasPhoto ? "Photo Selected" : "No Photo Selected";

    [RelayCommand]
    async Task AddCharacter()
    {
        var character = UserCharacter.CreateBuilder()
            .WithName(Name)
            .WithDescription(Description)
            .WithImage(Image)
            .Build();
        
        await _controller.SaveCharacterAsync(character);
        
        // Clear fields after saving optionally
        Name = string.Empty;
        Description = string.Empty;
        Image = string.Empty;
    }

    [RelayCommand]
    async Task SelectPhotoAsync()
    {
        try
        {
            var photo = await MediaPicker.Default.PickPhotoAsync();

            if (photo != null)
            {
                Image = photo.FullPath;
                OnPropertyChanged(nameof(PhotoStatusText));
            }
        }
        catch (Exception e)
        {
            await Shell.Current.DisplayAlert("Error", e.Message, "OK");
        }
    }
}
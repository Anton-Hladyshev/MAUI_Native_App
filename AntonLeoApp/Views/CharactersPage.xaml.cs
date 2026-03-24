using AntonLeoApp.ViewModels;

namespace AntonLeoApp;

public partial class CharactersPage : ContentPage
{
    private readonly ViewModels.CharactersViewModel _viewModel;
    
    public CharactersPage(CharactersViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = _viewModel = viewModel;
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _viewModel.LoadCharactersCommand.ExecuteAsync(null);
    }
}

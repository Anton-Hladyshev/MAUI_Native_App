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
        await _viewModel.InitialLoadCommand.ExecuteAsync(null);
        await _viewModel.RefreshLocalCharactersCommand.ExecuteAsync(null);
    }
    
    private async void OnCardLoaded(object sender, EventArgs e)
    {
        if (sender is Border card)
        {
            card.Opacity = 0;

            await Task.WhenAll(
                card.FadeTo(1, 250, Easing.CubicOut),
                card.ScaleTo(1, 200, Easing.SinOut)
            );
        }
    }
}

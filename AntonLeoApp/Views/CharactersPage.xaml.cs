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
    }
    
    private void OnImageLoaded(object sender, EventArgs e)
    {
        if (sender is Image image)
        {
            Element parent = image.Parent;
            while (parent != null && !(parent is Border && ((Border)parent).StrokeShape is null)) 
            {
                if (parent is Border border && border.Opacity == 0)
                {
                    border.FadeTo(1, 400, Easing.CubicIn);
                    return;
                }
                parent = parent.Parent;
            }
        }
    }
}

using AntonLeoApp.ViewModels;

namespace AntonLeoApp;

public partial class CharactersPage : ContentPage
{
    public CharactersPage(CharactersViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}

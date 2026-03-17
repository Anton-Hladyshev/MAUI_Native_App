namespace AntonLeoApp;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(CharactersPage), typeof(CharactersPage));
        Routing.RegisterRoute(nameof(UserIOPage), typeof(UserIOPage));
        Routing.RegisterRoute(nameof(UnknownPage),  typeof(UnknownPage));
    }
}
namespace AntonLeoApp;

public partial class MainPage : ContentPage
{
    public List<string> carouselImages { get; set; }
    
    public MainPage()
    {
        InitializeComponent();
        
        carouselImages = new List<string> { "death_star.png", "dotnet_bot.png", "yoda_attack.png" };
        
        MyCarousel.ItemsSource = carouselImages;
        MyCarousel.IndicatorView = MyIndicator;
    }
    private async void OnButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GifPage());
    }
    
    private void OnCurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
    {
        var currentItem = e.CurrentItem as string;
        int index = carouselImages.IndexOf(currentItem);
    }
    
}
namespace AntonLeoApp;

public partial class MainPage : ContentPage
{
    private List<string> CarouselImages { get; set; }
    
    public MainPage()
    {
        InitializeComponent();
        
        CarouselImages = new List<string> { "trilogie_1_poster.png", "trilogie_2_poster.png", "trilogie_3_poster.png" };
        
        MyCarousel.ItemsSource = CarouselImages;
        MyCarousel.IndicatorView = MyIndicator;
    }
    private async void OnButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GifPage());
    }
    
    private void OnCurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
    {
        var currentItem = e.CurrentItem as string;
        int index = CarouselImages.IndexOf(currentItem);
    }
    
}
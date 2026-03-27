namespace AntonLeoApp;

public partial class HologramPage : ContentPage
{
    
    private bool _isProcessing = false;
    
    public HologramPage()
    {
        InitializeComponent();
    }

    private async void OnCommuneClicked(object sender, EventArgs e)
    {
        if (_isProcessing) return;
        _isProcessing = true;

        try 
        {
            string nouvelleCitation = Services.HolocronService.GetRandomQuote();
            
            if (HoloContainer.IsVisible)
            {
                this.AbortAnimation("HoloFloat");
                await Task.WhenAll(
                    HoloOn.FadeTo(0, 200),
                    HoloContainer.FadeTo(0, 200)
                );
                HoloContainer.IsVisible = false;
            }
            
            QuoteDisplay.Text = nouvelleCitation;
            HoloContainer.RotationY = -10;
            HoloContainer.TranslationY = 5;
            HoloContainer.Opacity = 0;
            HoloContainer.IsVisible = true;
            
            ConnexionButton.Text = "Changer Connexion";
            
            await Task.WhenAll(
                HoloOn.FadeTo(1, 1000, Easing.SinIn),
                HoloContainer.FadeTo(1, 1000),
                HoloContainer.RotateYTo(10, 1000, Easing.SinOut)
            );
            
            StartHologramAnimation();
        }
        finally 
        {
            _isProcessing = false;
        }
    }

    private void StartHologramAnimation()
    {
        this.AbortAnimation("HoloFloat");
        this.AbortAnimation("LedBlink");
        
        var continuousAnim = new Animation(v => 
        {
            double angle = Math.Sin((v * Math.PI * 2) + (Math.PI / 2));
            HoloContainer.RotationY = angle * 10;
            HoloContainer.TranslationY = angle * 5;
        }, 0, 1);
    
        continuousAnim.Commit(this, "HoloFloat", length: 4500, repeat: () => true);
        
        var blinkAnim = new Animation(v => StatusLed.Opacity = v, 0.1, 0.8);
        blinkAnim.Commit(this, "LedBlink", length: 800, repeat: () => true, easing: Easing.SinInOut);
    }
    
}
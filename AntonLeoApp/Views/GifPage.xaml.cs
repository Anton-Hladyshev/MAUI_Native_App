using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntonLeoApp;

public partial class GifPage : ContentPage
{
    public GifPage()
    {
        InitializeComponent();
        WaitAndShowButton();
    }
    
    private async void WaitAndShowButton()
    {
        await Task.Delay(2400); 
        
        BtnBack.IsVisible = true;
        
        MainGif.IsAnimationPlaying = false;
    }
    
    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
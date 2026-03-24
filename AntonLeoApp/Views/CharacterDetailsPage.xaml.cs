using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AntonLeoApp.ViewModels;

namespace AntonLeoApp.Views;

public partial class CharacterDetailsPage : ContentPage
{
    public CharacterDetailsPage(CharacterDetailsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
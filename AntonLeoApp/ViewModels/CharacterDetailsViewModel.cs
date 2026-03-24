using CommunityToolkit.Mvvm.ComponentModel; 
using AntonLeoApp.Model.Dtos;     
using Microsoft.Maui.Controls;           

namespace AntonLeoApp.ViewModels;

[QueryProperty(nameof(Character), "Character")]
public partial class CharacterDetailsViewModel : ObservableObject
{
    [ObservableProperty]
    private CharacterDto? _character;
}
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace maui_tutorial_app.ViewModel
{
    [QueryProperty("Item", "Item")]
    public partial class DetailViewModel : ObservableObject 
    {
        [ObservableProperty]
        string item;

        [RelayCommand]
        async Task GoBack()
        {
           await Shell.Current.GoToAsync("..");
        }
    }
}

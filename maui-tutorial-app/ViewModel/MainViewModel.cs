using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace maui_tutorial_app.ViewModel;

public partial class MainViewModel : ObservableObject
{

    public MainViewModel()     
    {
        Items = new ObservableCollection<string>();
    }

    [ObservableProperty] 
    ObservableCollection<string> items;

    [ObservableProperty] 
    string text;

    [RelayCommand]
    private void Add()
    {
        if(string.IsNullOrWhiteSpace(Text))
            return;

        text = text.Trim();
        Items.Add(text);
        // add our item
        Text = string.Empty;
    }

    [RelayCommand]
    private void Delete(string s)
    {
        if (Items.Contains(s))
        {
            Items.Remove(s);
        }
    }

    [RelayCommand]
    async Task Tap(string s)
    {
        if (s == null)
            return;

        // navigate to detail page
        // await Shell.Current.GoToAsync(nameof(DetailPage));
        await Shell.Current.GoToAsync(nameof(DetailPage), true, new Dictionary<string, object>
        {
            {"Item", s }
        });
    }
}
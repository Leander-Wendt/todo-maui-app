
using maui_tutorial_app.ViewModel;

namespace maui_tutorial_app;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
    }
}
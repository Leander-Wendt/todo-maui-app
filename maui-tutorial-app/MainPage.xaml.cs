using maui_tutorial_app.ViewModel;

namespace maui_tutorial_app
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }

      
    }
}

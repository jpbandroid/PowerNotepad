using Microsoft.UI.Xaml.Controls;

using PowerNotepad.ViewModels;

namespace PowerNotepad.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}

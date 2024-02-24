using System.Collections.Generic;
using Microsoft.UI.Xaml.Controls;

using PowerNotepad.ViewModels;
using Windows.Storage;
using Windows.Storage.Pickers;
using WinUIEditor;

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



    private void MenuFlyoutItem_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private async void MenuFlyoutItem_Click_1(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
    }
}

using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace StartConfigurator.Views;

public partial class MainWindow : Window
{
    private ContentControl _mainContent;
    private StackPanel _mainPage;
    private StackPanel _configPage;
    public MainWindow()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
        _mainContent = this.FindControl<ContentControl>("MainContent");
        _mainPage = this.FindControl<StackPanel>("MainPage");
        _configPage = this.FindControl<StackPanel>("ConfigPage");
        if (!_configPage.IsInitialized)
            Console.WriteLine("ConfigPage is not initialized");
    }

    private void OnInstallButtonClick(object sender, RoutedEventArgs e)
    {
        _mainPage.IsVisible = false;
        _configPage.IsVisible = true;
    }
}
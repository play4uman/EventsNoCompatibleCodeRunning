using System.Diagnostics;

namespace MauiBlazorHybridSandbox.Pages;

public partial class TestXamlPage : ContentPage
{
	public TestXamlPage()
	{
		InitializeComponent();
	}

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        Debug.WriteLine($"*************** TEXT CHANGED: {e.NewTextValue}");
    }

    private void Entry_Focused(object sender, FocusEventArgs e)
    {
        Debug.WriteLine("*************** Focused");
    }
}
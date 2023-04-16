using Microsoft.Maui.ApplicationModel;

namespace MAUI_Calculator;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{

        InitializeComponent();
        Application.Current.UserAppTheme = AppTheme.Light;
    }

    void OnClear(object sender, EventArgs e)
    {

    }

    void OnSquareRoot(object sender, EventArgs e)
    {

    }
}


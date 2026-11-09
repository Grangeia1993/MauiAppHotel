
namespace MauiAppHotel;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnConhecerHotelClicked(
        object sender, EventArgs e)
    {
        await DisplayAlert(
            "Hotel MAUI",
            "Em breve você poderá solicitar sua hospedagem!",
            "OK");
    }
}

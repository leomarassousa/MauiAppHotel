namespace MauiAppHotel.Views;

public partial class sobre : ContentPage
{
    public sobre()
    {
        InitializeComponent();
    }


    private async void Button_Clicked(object sender, EventArgs e) => App.Current.MainPage = new ContratacaoHospedagem();
}
using MauiAppHotel.Views;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }



        protected override Window CreateWindow(IActivationState activationState)
        {
            MainPage = new ContratacaoHospedagem();
            return base.CreateWindow(activationState);
        }

    }
}
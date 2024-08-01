namespace Practica13MVVM_6011464
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sumadenumeros());
        }

        private async void OnCounterClicked2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TrianguloBase());

        }
        private async void OnCounterClicked3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Distancia());

        }
        private async void OnCounterClicked4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LaBrochaGorda());
        }
        private async void OnCounterClicked5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sueldito());

        }
    }

}

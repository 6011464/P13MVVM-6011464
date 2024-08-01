namespace Practica13MVVM_6011464;

public partial class Distancia : ContentPage
{
	public Distancia()
	{
		InitializeComponent();
        BindingContext = new DistanciaViewModel();
    }
}